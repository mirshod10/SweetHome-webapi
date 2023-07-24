using SweetHome.Service.Dtos.Users;

namespace SweetHome.Service.Interfaces.Users;

public interface IUserService
{
    public Task<bool> CreateAsync(UserCreateDto dto);
}
