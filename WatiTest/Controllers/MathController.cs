using Microsoft.AspNetCore.Mvc;

namespace WatiTest.Controllers;

[ApiController]
[Route("[controller]")]
public class MathController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public MathController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "SumTwoNums")]
    public Task<int> Post(int n1 = 0, int n2 = 0)
    {
        var sum = n1 + n2;
        return Created(sum);
    }
}