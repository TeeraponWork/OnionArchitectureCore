using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureCore.Domain;
using OnionArchitectureCore.Domain.Interfaces;
using OnionArchitectureCore.Domain.Result;

namespace OnionArchitectureCore.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : BaseApiController
    {
        private readonly IWeatherForecastService _weatherForecastService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [Authorize]
        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _weatherForecastService.ProcessFTemperature();
                var handledResult = new ResultModel<List<WeatherForecastModels>>
                {
                    IsSuccess = true,
                    Error = string.Empty,
                    Value = result
                };
                return HandleResult(handledResult);
            }
            catch (Exception ex)
            {
                var handledResult = new ResultModel<List<WeatherForecastModels>>
                {
                    IsSuccess = false,
                    Error = ex.Message,
                };
                return HandleResult(handledResult);

            }
        }
    }
}