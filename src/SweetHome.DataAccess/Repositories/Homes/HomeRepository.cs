using SweetHome.DataAccess.Interfaces.Homes;
using SweetHome.DataAccess.Utils;
using SweetHome.DataAccess.ViewModels;
using SweetHome.Domain.Entities.Homes;

namespace SweetHome.DataAccess.Repositories.Homes;

public class HomeRepository : BaseRepository, IHomeRepository
{
    public Task<long> CountAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<int> CreateAsync(Home entity)
    {
        throw new NotImplementedException();
        try
        {
            await _connection.OpenAsync();


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

    public Task<IList<HomeViewModel>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<HomeViewModel> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<(int ItemsCount, IList<HomeViewModel>)> SearchAsync(string search, PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, Home entity)
    {
        throw new NotImplementedException();
    }
}
