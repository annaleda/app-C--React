using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var weatherData = new[]
        {
            new { City = "Rome", Temperature = 25 },
            new { City = "Milan", Temperature = 22 },
        };
        return Ok(weatherData);
    }
}
