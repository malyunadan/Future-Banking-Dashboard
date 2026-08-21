using Microsoft.AspNetCore.Mvc;
using FutureBankingDashboard.Library.Interfaces;

namespace FutureBankingDashboard.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SustainabilityController : ControllerBase
{
    private readonly ISustainabilityService _service;

    public SustainabilityController(ISustainabilityService service)
    {
        _service = service;
    }

    [HttpGet("{companyId}")]
    public IActionResult GetSustainability(int companyId)
    {
        var result = _service.GetSustainabilityData(companyId);
        return result == null ? NotFound() : Ok(result);
    }
}
