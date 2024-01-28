using OnionArchitectureCore.Domain;
using OnionArchitectureCore.Domain.Interfaces;
using OnionArchitectureCore.Domain.Result;

namespace OnionArchitectureCore.Application
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }
        public async Task<List<WeatherForecastModels>> ProcessFTemperature()
        {
            var forecasts = await _weatherForecastRepository.GetForecasts();
            var processed = new List<WeatherForecastModels>();
            foreach (var f in forecasts)
            {
                f.TemperatureF = 32 + (int)(f.TemperatureC / 0.5556);
                processed.Add(f);
            }

            return processed;
            //return ResultMessage<object>.Success(processed);
        }
    }
}
