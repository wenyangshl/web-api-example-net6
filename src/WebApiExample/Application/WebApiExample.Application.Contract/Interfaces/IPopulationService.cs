using WebApiExample.Domain.Entities.Population;

namespace WebApiExample.Application.Contract.Interfaces
{
    public interface IPopulationService
    {
        Task<StatePopulation?> GetStatePopulation(string state);

        Task<StatePopulation[]> GetAllStatesPopulation();
    }
}
