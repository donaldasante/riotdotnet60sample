using FastEndpoints;
using Templating.RiotSPA.Contracts.Requests;
using Templating.RiotSPA.Contracts.Responses;
using Templating.RiotSPA.Model;

namespace Templating.RiotSPA.Mappers
{
    public class WeatherForecastMapper : Mapper<WeatherForecastRequest, WeatherForecastResponse, WeatherForecast>
    {
        public override WeatherForecastResponse FromEntity(WeatherForecast e)
        {
            return new WeatherForecastResponse()
            {
                Date = e.Date,
                Summary = e.Summary,
                TemperatureC = e.TemperatureC,
                TemperatureF = e.TemperatureF
            };
        }
    }
}
