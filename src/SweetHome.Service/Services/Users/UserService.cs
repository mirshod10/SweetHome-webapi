using SweetHome.DataAccess.Interfaces.Users;
using SweetHome.DataAccess.Repositories.Users;
using SweetHome.Domain.Entities.Users;
using SweetHome.Service.Common.Helpers;
using SweetHome.Service.Dtos.Users;
using SweetHome.Service.Interfaces.Users;

namespace SweetHome.Service.Services.Users;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;
    public UserService(IUserRepository userRepository)
    {
        this._repository = userRepository;
    }
    public async Task<bool> CreateAsync(UserCreateDto dto)
    {
        User user = new User()
        {
            Ism = dto.Ism,
            Familiya = dto.Familiya,
            Tel_nomer = dto.Tel_nomer,
            Parol = dto.Parol,
            UpdatedAt = TimeHelper.GetDateTime(),
            CreatedAt = TimeHelper.GetDateTime()
        };

        var result = await _repository.CreateAsync(user);
        return result > 0;
    }
}
