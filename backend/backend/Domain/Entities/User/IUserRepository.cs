using Backend.Domain.Interfaces;

namespace Backend.Domain.Entities.User
{
    public interface IUserRepository : IRepository<User>
    {
        User FindByEmail(string email);
    }
}
