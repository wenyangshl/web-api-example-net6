using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApiExample.Application.Contract.Interfaces;
using WebApiExample.Domain.Entities.Population;

namespace WebApiExample.Application
{
    public class PopulationService : IPopulationService
    {
        private readonly IPopulationRepository _populationRepository;
        public PopulationService(IPopulationRepository populationRepository)
            => _populationRepository = populationRepository;

        public async Task<StatePopulation[]> GetAllStatesPopulation()
        {
            string response = await _populationRepository.GetStatePopulation();

            StatePopulation[] statePopulations = JsonConvert.DeserializeObject<StatePopulation[]>(response) ?? new StatePopulation[] { };

            return statePopulations;
        }

        public async Task<StatePopulation?> GetStatePopulation(string state)
        {
            StatePopulation[] statePopulations = await GetAllStatesPopulation();

            return statePopulations is null ? null : statePopulations.Where(p => p.StateSlug == state.ToLower()).FirstOrDefault();
        }
    }
}
