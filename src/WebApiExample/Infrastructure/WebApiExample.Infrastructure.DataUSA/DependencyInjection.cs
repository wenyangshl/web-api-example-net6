using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using WebApiExample.Application.Contract.Interfaces;

namespace WebApiExample.Infrastructure.DataUSA
{
    [ExcludeFromCodeCoverage]
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataUSARepositories(this IServiceCollection services)
        {
            services.AddScoped<IPopulationRepository, PopulationRepository>();

            return services;
        }
    }
}
