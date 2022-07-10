using WebApiExample.Application.Contract.Interfaces;
using WebApiExample.Domain.Entities.Population;

namespace WebApiExample.Controller.V1;

[ApiVersion("1.0")]
public class PopulationController : BaseController
{
    private readonly IPopulationService _populationService;

    public PopulationController(IPopulationService populationService)
        => _populationService = populationService;

    [HttpGet("state")]
    public IActionResult GetStatePopulation([FromQuery] string state)
    {
        var population = _populationService.GetStatePopulation(state);

        return StatusCode(StatusCodes.Status200OK, population);
    }
}

