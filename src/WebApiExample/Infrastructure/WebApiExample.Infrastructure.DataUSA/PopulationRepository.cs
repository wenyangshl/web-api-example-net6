using Newtonsoft.Json.Linq;
using WebApiExample.Application.Contract.Interfaces;

namespace WebApiExample.Infrastructure.DataUSA
{
    public class PopulationRepository : IPopulationRepository
    {
        private readonly HttpClient _httpClient;
        public PopulationRepository(IHttpClientFactory httpClientFactory)
        {
            IHttpClientFactory factory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
            _httpClient = factory.CreateClient("DataUSA");
        }
            
        
        public async Task<string> GetStatePopulation()
        {
            var rawData = await GetDataFromDataUSA();

            JObject jobj = JObject.Parse(rawData);

            if (jobj == null || !jobj.ContainsKey("data") || !jobj["data"].HasValues)
                throw new Exception("Error Getting data from Data USA");

            return jobj["data"].ToString();
        }

        private async Task<string> GetDataFromDataUSA()
        {
            var httpResponseMessage = await _httpClient.GetAsync("/api/data?drilldowns=State&measures=Population&year=latest", HttpCompletionOption.ResponseContentRead);

            if (httpResponseMessage is not null && httpResponseMessage.IsSuccessStatusCode)
            {
                var contentString =
                    await httpResponseMessage.Content.ReadAsStringAsync();

                return contentString;
            }
            else
            {
                throw new Exception("Error Getting data from Data USA");
            }
        }
    }
}
