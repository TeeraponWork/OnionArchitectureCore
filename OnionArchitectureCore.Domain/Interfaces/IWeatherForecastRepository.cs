namespace OnionArchitectureCore.Domain.Interfaces
{
    public interface IWeatherForecastRepository
    {
        WeatherForecastModels[] GetForecasts();
    }
}
