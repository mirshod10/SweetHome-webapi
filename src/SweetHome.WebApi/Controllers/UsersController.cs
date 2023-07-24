using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SweetHome.DataAccess.Interfaces.Users;
using SweetHome.DataAccess.Repositories.Users;
using SweetHome.Domain.Entities.Users;
using SweetHome.Service.Common.Helpers;
using SweetHome.Service.Dtos.Users;
using SweetHome.Service.Interfaces.Users;

namespace SweetHome.WebApi.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _service;

    public UsersController(IUserService service)
    {
        this._service = service;
    }
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] UserCreateDto dto)
    => Ok(await _service.CreateAsync(dto));
}
