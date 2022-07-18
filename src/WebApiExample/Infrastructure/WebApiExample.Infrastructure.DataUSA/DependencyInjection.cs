using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using WebApiExample.Application.Contract.Interfaces;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebApiExample.Infrastructure.DataUSA
{
    [ExcludeFromCodeCoverage]
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataUSARepositories(this IServiceCollection services, string baseUrl)
        {
            services.AddScoped<IPopulationRepository, PopulationRepository>();

            services.AddHttpClient("DataUSA", httpClient =>
            {
                httpClient.BaseAddress = new Uri(baseUrl);
                httpClient.DefaultRequestHeaders
                    .Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            });

            return services;
        }
    }
}
