docker build -t dapr-test1/blazorweb:3.0 -f Server/Dockerfile .
docker build -t dapr-test1/serviceapi1:3.0 -f ServiceApi/DaprTest1.ServiceApi1/Dockerfile .