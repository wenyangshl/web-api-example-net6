namespace WebApiExample.Application.Contract.Interfaces
{
    public interface IPopulationRepository
    {
        Task<string> GetStatePopulation();
    }
}
