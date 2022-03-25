using System.Collections.Generic;

namespace riotdotnet60.Contracts.Responses
{
    public class WeatherForecastsResponse
    {
        public IEnumerable<WeatherForecastResponse> Forecasts { get; set; }
    }
}
