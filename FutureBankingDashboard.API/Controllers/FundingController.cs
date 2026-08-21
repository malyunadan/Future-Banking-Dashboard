using Microsoft.AspNetCore.Mvc;
using FutureBankingDashboard.Library.Interfaces;

namespace FutureBankingDashboard.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FundingController : ControllerBase
{
    private readonly IFundingService _service;

    public FundingController(IFundingService service)
    {
        _service = service;
    }

    [HttpGet("{co2Score}")]
    public IActionResult GetFunding(string co2Score)
    {
        var result = _service.GetRelevantFunding(co2Score);
        return Ok(result);
    }
}

