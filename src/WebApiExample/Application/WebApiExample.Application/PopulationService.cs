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

        public StatePopulation GetStatePopulation(string state)
        {
            string response = _populationRepository.GetStatePopulation();
            JObject jobj = JObject.Parse(response);

            StatePopulation[] statePopulations = JsonConvert.DeserializeObject<StatePopulation[]>(jobj["data"].ToString());

            return statePopulations.Where(p => p.StateSlug == state.ToLower()).FirstOrDefault();
        }
    }
}
