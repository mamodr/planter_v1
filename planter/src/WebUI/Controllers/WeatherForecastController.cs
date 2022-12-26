using Microsoft.AspNetCore.Mvc;
using planter.Application.WeatherForecasts.Queries.GetWeatherForecasts;

namespace planter.WebUI.Controllers;
public class WeatherForecastController : ApiControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await Mediator.Send(new GetWeatherForecastsQuery());
    }
}
