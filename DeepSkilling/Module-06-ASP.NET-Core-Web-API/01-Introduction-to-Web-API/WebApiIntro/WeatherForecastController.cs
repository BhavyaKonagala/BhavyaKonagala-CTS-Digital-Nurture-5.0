using Microsoft.AspNetCore.Mvc;

namespace WebApiIntro.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries =
    {
        "Freezing",
        "Cold",
        "Cool",
        "Warm",
        "Hot",
        "Very Hot"
    };

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-10, 40),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        });
    }
}