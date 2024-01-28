using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureCore.Application;
using OnionArchitectureCore.Application.Service;
using OnionArchitectureCore.Application.User;
using OnionArchitectureCore.Domain.Interfaces;
using OnionArchitectureCore.Domain.Interfaces.User;
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

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<TokenService, TokenService>();

            return services;
        }
    }
}
