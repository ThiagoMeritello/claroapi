using Claro.Business.Interfaces;
using Claro.Business.Services;
using Claro.Data.Context;
using Claro.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Claro.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();

            services.AddScoped<IMobileRepository, MobileRepository>();

            services.AddScoped<IMobileService, MobileService>();

            return services;
        }
    }
}
