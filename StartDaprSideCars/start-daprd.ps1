# pre-requisites:
# - initialized with: dapr init --slim
#   so that redis is running as container and placement service is started on demand

# --------------------------------------------------------------------------------
# projects
# - appId       = needs to be Dapr id commonly used to address service

$configProjects = @(
    @{
        appId       = "blazorweb"
    }
    @{
        appId       = "serviceapi1"
    }
)

# --------------------------------------------------------------------------------
# INIT

$ErrorActionPreference = "Stop"

# stop and remove previous jobs
$jobNamePattern = $configProjects | Join-String -Property appId -Separator "|" -OutputPrefix "(placement|" -OutputSuffix ")"
Get-Job | ? { $_.Name -match $jobNamePattern } | Stop-Job -PassThru | Remove-Job

# --------------------------------------------------------------------------------
# MAIN

$jobs = @()

# start placement service/job
$DAPR_PLACEMENT_PORT = 6050
$jobName = "placement"
Start-Job -Name $jobName -ScriptBlock {
    param( $port )
    
    placement --port $port

} -Argument $DAPR_PLACEMENT_PORT

Write-Host "started" $jobName "in background, listening port:"$DAPR_PLACEMENT_PORT
"-" * 80
$jobs += $jobName

# start jobs for app and dapr sidecar
$DAPR_HTTP_PORT = 3500
$DAPR_GRPC_PORT = 50001
$METRICS_PORT = 9091
$APP_PORT = 5000

foreach ($configProject in $configProjects) {

    $jobName = $configProject.appId + "-daprd"
    $componentsPath = "components/"
    $configFile = "config.yaml"

    Start-Job -Name $jobName -ScriptBlock {
        param( $appId, $appPort, $DAPR_HTTP_PORT, $DAPR_GRPC_PORT, $DAPR_PLACEMENT_PORT, $METRICS_PORT, $componentsPath, $configFile)

        daprd --app-id $appId  `
            --app-port $appPort `
            --placement-host-address $("localhost:" + $DAPR_PLACEMENT_PORT) `
            --log-level debug `
            --components-path $componentsPath `
            --config $configFile `
            --dapr-http-port $DAPR_HTTP_PORT `
            --dapr-grpc-port $DAPR_GRPC_PORT `
            --metrics-port $METRICS_PORT

    } -Argument $configProject.appId, $APP_PORT, $DAPR_HTTP_PORT, $DAPR_GRPC_PORT, $DAPR_PLACEMENT_PORT, $METRICS_PORT, $componentsPath, $configFile
    Write-Host "started "$jobName" in background, DAPR_HTTP_PORT: "$DAPR_HTTP_PORT "DAPR_GRPC_PORT:"$DAPR_GRPC_PORT "METRICS_PORT:"$METRICS_PORT
    Write-Host "expecting "$configProject.appId" to be started on listening port:"$APP_PORT 
    "-" * 80
    $jobs += $jobName

    $DAPR_HTTP_PORT += 10
    $DAPR_GRPC_PORT += 10
    $APP_PORT += 10
    $METRICS_PORT += 1
}


# handle menu

$running = $true

while ($running) {
    Write-Host "s: job status"
    Write-Host "e: check all logs for errors"
    Write-Host "q: stop jobs and quit"
    $jobId = 0
    foreach ($job in $jobs) {
        Write-Host $($jobId.ToString() + ": show log of " + $job)
        $jobId += 1
    }

    $option = Read-Host "Enter option"

    switch ($option.ToUpper()) {
        "S" {
            Get-Job | ? { $_.Name -match $jobNamePattern } | Format-Table Name, State
        }
        "E" {
            foreach ($job in $jobs) {
                $errors = $null
                if ($job -match "-app$") {
                    $errors = (Receive-Job -Name $job -Keep) -match "(error|fail)\:"
                }
                else {
                    $errors = (Receive-Job -Name $job -Keep) -match "level\=error"
                }
                if ($errors) {
                    "-" * 80
                    Write-Host "ERROR IN JOB:" $job -ForegroundColor Red
                    $errors
                }
            }
        }
        "Q" {
            Get-Job | ? { $_.Name -match $jobNamePattern } | Stop-Job -PassThru | Remove-Job
            $running = $false            
        }
        default {
            if ([int32]::TryParse($option , [ref]$jobId )) {
                if ($jobId -ge 0 -and $jobId -lt $jobs.Count) {
                    Receive-Job -Name $jobs[$jobId] -Keep | code -
                }
            }
        }
    }
}