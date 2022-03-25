using FastEndpoints;
using riotdotnet60.Contracts.Requests;
using riotdotnet60.Contracts.Responses;
using riotdotnet60.Model;

namespace riotdotnet60.Mappers
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
