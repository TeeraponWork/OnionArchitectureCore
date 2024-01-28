using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureCore.Application;
using OnionArchitectureCore.Domain.Interfaces;
using OnionArchitectureCore.Persistence;

namespace OnionArchitectureCore.Infrastructure.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
            IConfiguration config)
        {

            services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();
            services.AddScoped<IWeatherForecastService, WeatherForecastService>();

            return services;
        }
    }
}
