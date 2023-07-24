﻿using SweetHome.DataAccess.Common.Interfaces;
using SweetHome.DataAccess.ViewModels;
using SweetHome.Domain.Entities.Homes;

namespace SweetHome.DataAccess.Interfaces.Homes;

public interface IHomeRepository : IRepository<Home, HomeViewModel>,
    IGetAll<HomeViewModel>, ISearchable<HomeViewModel>
{
}
