using FastEndpoints;
using Microsoft.Extensions.Logging;
using riotdotnet60.Contracts.Requests;
using riotdotnet60.Contracts.Responses;
using riotdotnet60.Mappers;
using riotdotnet60.Model;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace riotdotnet60.Endpoints
{
    public class WeatherForecastEndpoint : Endpoint<WeatherForecastRequest,WeatherForecastsResponse, WeatherForecastMapper>
    {
        private static readonly string[] Summaries = new[]
{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastEndpoint> _logger;


        public WeatherForecastEndpoint(ILogger<WeatherForecastEndpoint> logger)
        {
            _logger = logger;
        }

        public override void Configure()
        {
            Get("/api/weatherforecast/{days}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(WeatherForecastRequest req,CancellationToken ct)
        {
            _logger.LogDebug("Getting Weather Forecasts");

            var rng = new Random();
            var forecasts =  Enumerable.Range(1, req.Days).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

            var response = new WeatherForecastsResponse()
            {
                Forecasts = forecasts.Select(Map.FromEntity)
            };

            await SendAsync(response, cancellation:ct);
        }
    }
}
