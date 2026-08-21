using Microsoft.AspNetCore.Mvc;
using FutureBankingDashboard.Library.Interfaces;

namespace FutureBankingDashboard.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EconomyController : ControllerBase
{
    private readonly IEconomyService _service;

    public EconomyController(IEconomyService service)
    {
        _service = service;
    }

    [HttpGet("{companyId}")]
    public IActionResult GetEconomy(int companyId)
    {
        var result = _service.GetEconomyData(companyId);
        return result == null ? NotFound() : Ok(result);
    }
}

