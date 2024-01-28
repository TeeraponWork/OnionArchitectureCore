using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureCore.Application.DTO;
using OnionArchitectureCore.Domain;
using OnionArchitectureCore.Domain.Interfaces.User;
using OnionArchitectureCore.Domain.Result;
using OnionArchitectureCore.Domain.User;

namespace OnionArchitectureCore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseApiController
    {
         private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDtoModel loginDto) 
        {
            try
            {
                var result = _userService.CheckUser(loginDto.Email);

                if(result == null) return Unauthorized();

                var handledResult = new ResultModel<UserDtoModel>
                {
                    IsSuccess = true,
                    Error = null,
                    Value = result
                };
                return HandleResult(handledResult);
            }
            catch (Exception ex)
            {
                var handledResult = new ResultModel<List<UserDtoModel>>
                {
                    IsSuccess = false,
                    Error = ex.Message,
                };
                return HandleResult(handledResult);
            }
        }
    }
}
