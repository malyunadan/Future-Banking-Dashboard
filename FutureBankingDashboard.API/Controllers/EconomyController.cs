using FutureBankingDashboard.Library.Interfaces;
using FutureBankingDashboard.Library.Models;
using Microsoft.AspNetCore.Mvc;


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

    // GET api/economy/5
    [HttpGet("{companyId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult GetByCompanyId(int companyId)
    {
        var economy = _service.GetEconomyData(companyId);

        if (economy == null)
        {
            return NotFound("Ingen Economy-data med companyId " + companyId);
        }

        return Ok(economy);
    }
}
