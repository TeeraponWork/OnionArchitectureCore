using OnionArchitectureCore.Domain;
using OnionArchitectureCore.Domain.Interfaces;

namespace OnionArchitectureCore.Application
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }
        public List<WeatherForecastModels> ProcessFTemperature()
        {
            var forecasts = _weatherForecastRepository.GetForecasts();
            var processed = new List<WeatherForecastModels>();
            foreach (var f in forecasts)
            {
                f.TemperatureF = 32 + (int)(f.TemperatureC / 0.5556);
                processed.Add(f);
            }

            return processed;
        }
    }
}
