using OnionArchitectureCore.Application.DTO;
using OnionArchitectureCore.Application.Service;
using OnionArchitectureCore.Domain.Interfaces.User;
using OnionArchitectureCore.Domain.User;

namespace OnionArchitectureCore.Application.User
{
    public class UserService : IUserService
    {
        private readonly TokenService _tokenService;
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository, TokenService tokenService)
        {
            _tokenService = tokenService;
            _userRepository = userRepository;
        }

        public UserDtoModel CheckUser(string email)
        {
            var user = _userRepository.RetrieveLoggedInUserByUsername(email);
            if(user == null) { return null; }

            if (user != null) 
            {
                var resultToken = _tokenService.CreateToken(user);
                return CreateUserObject(user, resultToken);
            }

            return null;
        }
        //private UserModel CreateUserObject(UserModel user, string token)
        //{
        //    return new UserModel
        //    {
        //        Email = user.Email,
        //        Name = user.Name,
        //        Token = token
        //    };
        //}
        private UserDtoModel CreateUserObject(UserModel user, string token)
        {
            return new UserDtoModel
            {
                Email = user.Email,
                Name = user.Name,
                Token = token
            };
        }
    }
}
