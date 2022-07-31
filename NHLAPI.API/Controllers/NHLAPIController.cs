using Microsoft.AspNetCore.Mvc;
using NHLAPI.Domain;

namespace NHLAPI.API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class NHLAPIController : ControllerBase
{

    private readonly ILogger<NHLAPIController> _logger;

    public NHLAPIController(ILogger<NHLAPIController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAllTeams")]
    [Route("/Teams")]
    public async Task<ActionResult<Teams>> GetAllTeams()
    {
        _logger.LogDebug("Get Was Called, yo!");
        return Ok(new Teams());
    }
}
