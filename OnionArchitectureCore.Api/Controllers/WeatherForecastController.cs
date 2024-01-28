using Microsoft.AspNetCore.Mvc;
using OnionArchitectureCore.Domain;
using OnionArchitectureCore.Domain.Interfaces;

namespace OnionArchitectureCore.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherForecastService;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecastModels> Get()
        {
            return _weatherForecastService.ProcessFTemperature();
        }
    }
}