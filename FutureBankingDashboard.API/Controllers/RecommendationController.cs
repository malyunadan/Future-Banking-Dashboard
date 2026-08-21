using Microsoft.AspNetCore.Mvc;
using FutureBankingDashboard.Library.Interfaces;

namespace FutureBankingDashboard.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecommendationController : ControllerBase
{
    private readonly IRecommendationService _service;

    public RecommendationController(IRecommendationService service)
    {
        _service = service;
    }

    [HttpGet("{companyId}")]
    public IActionResult GetRecommendations(int companyId)
    {
        var result = _service.GenerateRecommendations(companyId);
        return Ok(result);
    }
}


