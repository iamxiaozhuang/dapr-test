using Dapr;
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
        private readonly DaprClient _daprClient;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICallServiceApi1 callServiceApi1, DaprClient daprClient)
        {
            _logger = logger;
            _callServiceApi1 = callServiceApi1;
            _daprClient = daprClient;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await _callServiceApi1.GetWeatherForecast();
            //var client = DaprClient.CreateInvokeHttpClient(appId: "serviceapi1");
            //var response = await client.GetFromJsonAsync<IEnumerable<WeatherForecast>>("WeatherForecast");
            //return response;
        }

        [HttpPost(nameof(SaveStateValue))]
        public async Task SaveStateValue(StateModel stateModel)
        {
            await _daprClient.SaveStateAsync("statestore", stateModel.Key, stateModel.Value);
        }
        [HttpDelete(nameof(DeleteStateValue) + "/{stateKey}")]
        public async Task DeleteStateValue(string stateKey)
        {
            await _daprClient.DeleteStateAsync("statestore", stateKey);
        }
        [HttpGet("GetStateValue/{stateKey}")]
        public async Task<string> GetStateValue(string stateKey)
        {
            return await _daprClient.GetStateAsync<string>("statestore", stateKey);
        }

        [HttpGet(nameof(GetStateValueFromState) + "/{stateKey}")]
        public async Task<string> GetStateValueFromState([FromState("statestore", "stateKey")] StateEntry<string> stateEntry)
        {
            return await Task.FromResult(stateEntry.Value);
        }
    }
}
