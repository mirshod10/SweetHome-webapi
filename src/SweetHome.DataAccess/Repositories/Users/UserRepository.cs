using Dapper;
using SweetHome.DataAccess.Interfaces.Users;
using SweetHome.Domain.Entities.Users;

namespace SweetHome.DataAccess.Repositories.Users;

public class UserRepository : BaseRepository, IUserRepository
{
    public Task<long> CountAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<int> CreateAsync(User entity)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "INSERT INTO public.users(ism, familiya, tel_nomer, parol, updatedat, createdat) " +
                "VALUES (@ism, @familiya, @tel_nomer, @parol, @updatedat, @createdat);";
            return await _connection.ExecuteAsync(query, entity);
        }
        catch
        {
            return 0;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public Task<int> DeliteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, User entity)
    {
        throw new NotImplementedException();
    }
}
