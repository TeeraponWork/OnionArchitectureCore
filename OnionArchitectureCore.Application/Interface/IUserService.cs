using OnionArchitectureCore.Application.DTO;

namespace OnionArchitectureCore.Domain.Interfaces.User
{
    public interface IUserService
    {
        UserDtoModel CheckUser(string email);
    }
}
