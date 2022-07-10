using Microsoft.Extensions.DependencyInjection;
using WebApiExample.Application.Contract.Interfaces;

namespace WebApiExample.Application
{
    public static class DependencyInjection
    {
        public static  IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IPopulationService, PopulationService>();

            return services;
        }

    }
}
