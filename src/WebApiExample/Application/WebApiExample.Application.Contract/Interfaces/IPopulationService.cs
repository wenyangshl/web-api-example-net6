using WebApiExample.Domain.Entities.Population;

namespace WebApiExample.Application.Contract.Interfaces
{
    public interface IPopulationService
    {
        StatePopulation? GetStatePopulation(string state);
    }
}
