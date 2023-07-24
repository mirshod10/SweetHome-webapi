using SweetHome.DataAccess.Repositories;
using SweetHome.Domain.Entities.Users;

namespace SweetHome.DataAccess.Interfaces.Users;

public interface IUserRepository : IRepository<User, User>
{
}
