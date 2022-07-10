using Newtonsoft.Json;

namespace WebApiExample.Domain.Entities.Population
{
    public class StatePopulation
    {
        [JsonProperty("ID State")]
        public string StateId { get; set; }

        public string State { get; set; }

        [JsonProperty("ID Year")]
        public int YearId { get; set; }

        public string Year { get; set; }
        public long Population { get; set; }
        
        [JsonProperty("Slug State")]
        public string StateSlug { get; set; }
    }
}
