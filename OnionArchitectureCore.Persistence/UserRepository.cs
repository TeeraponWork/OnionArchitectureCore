using OnionArchitectureCore.Domain.Interfaces.User;
using OnionArchitectureCore.Domain.User;

namespace OnionArchitectureCore.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly List<UserModel> users;
        public UserRepository()
        {
            users = new List<UserModel>()
            {
                new UserModel{ Id = "erere", Email = "testA@gmail.com", Name = "testA", Password = "1234" },
                new UserModel{ Id = "drdrd", Email = "testB@gmail.com", Name = "testB", Password = "4321" },
            };
        }
        public UserModel RetrieveLoggedInUserByUsername(string email)
        {
            return users.FirstOrDefault(user => user.Email == email);
        }
    }
}
