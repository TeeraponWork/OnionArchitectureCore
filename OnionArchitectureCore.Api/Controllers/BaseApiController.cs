using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureCore.Domain.Result;

namespace OnionArchitectureCore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected ActionResult HandleResult<T>(ResultModel<T> result)
        {
            if (result == null) return NotFound();

            if (result.IsSuccess && result.Value != null)
                return Ok(result);

            if (result.IsSuccess && result.Value == null)
                return NotFound();

            return BadRequest(result);
        }
    }
}
