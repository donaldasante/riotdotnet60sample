using System.Collections.Generic;

namespace Templating.RiotSPA.Contracts.Responses
{
    public class WeatherForecastsResponse
    {
        public IEnumerable<WeatherForecastResponse> Forecasts { get; set; }
    }
}
