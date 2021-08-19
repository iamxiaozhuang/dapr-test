using DaprTest1.Shared;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaprTest1.Server.RefitCallApi
{
    public interface ICallServiceApi1
    {

        [Get("/WeatherForecast")]
        Task<IEnumerable<WeatherForecast>> GetWeatherForecast();


    }
}
