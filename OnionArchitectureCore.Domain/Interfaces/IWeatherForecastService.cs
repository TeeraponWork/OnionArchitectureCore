using OnionArchitectureCore.Domain.Result;

namespace OnionArchitectureCore.Domain.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<List<WeatherForecastModels>> ProcessFTemperature();
    }
}
