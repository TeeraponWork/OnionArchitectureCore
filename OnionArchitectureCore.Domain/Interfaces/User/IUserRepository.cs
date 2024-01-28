using OnionArchitectureCore.Domain.User;

namespace OnionArchitectureCore.Domain.Interfaces.User
{
    public interface IUserRepository
    {
        UserModel RetrieveLoggedInUserByUsername(string email);
    }
}
