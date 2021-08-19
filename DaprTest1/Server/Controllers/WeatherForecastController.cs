using Dapr.Client;
using DaprTest1.Server.RefitCallApi;
using DaprTest1.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DaprTest1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICallServiceApi1 _callServiceApi1;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICallServiceApi1 callServiceApi1)
        {
            _logger = logger;
            _callServiceApi1 = callServiceApi1;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await _callServiceApi1.GetWeatherForecast();
            //var client = DaprClient.CreateInvokeHttpClient(appId: "serviceapi1");
            //var response = await client.GetFromJsonAsync<IEnumerable<WeatherForecast>>("WeatherForecast");
            //return response;
        }
    }
}
