using FastEndpoints.Validation;
using riotdotnet60.Contracts.Requests;

namespace riotdotnet60.Validators
{
    public class WeatherForecastRetrievalValidator :
        Validator<WeatherForecastRequest>
    {
        public WeatherForecastRetrievalValidator()
        {
            RuleFor(x => x.Days)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Weather forecast days must be at least 1")
                .LessThanOrEqualTo(14)
                .WithMessage("Weather forecast cannot be retrieved past 14 days");
        }
    }
}
