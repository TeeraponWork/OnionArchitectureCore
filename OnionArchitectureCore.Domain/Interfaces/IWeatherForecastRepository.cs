namespace OnionArchitectureCore.Domain.Interfaces
{
    public interface IWeatherForecastRepository
    {
        Task<WeatherForecastModels[]> GetForecasts();
    }
}
