using Microsoft.AspNetCore.Mvc;

namespace NHLAPI.API.Controllers;

[ApiController]
[Route("[controller]")]
public class NHLAPIController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<NHLAPIController> _logger;

    public NHLAPIController(ILogger<NHLAPIController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<NHLAPIController> Get()
    {
        _logger.LogDebug("Get Was Called, yo!");
        return null;
    }
}
