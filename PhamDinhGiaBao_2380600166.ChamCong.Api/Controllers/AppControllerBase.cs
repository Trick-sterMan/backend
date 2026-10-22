using Microsoft.AspNetCore.Mvc;
using PhamDinhGiaBao_2380600166.ChamCong.Api.Services;

namespace PhamDinhGiaBao_2380600166.ChamCong.Api.Controllers;

[ApiController]
public abstract class AppControllerBase : ControllerBase
{
    protected int UserId => int.TryParse(User.FindFirst("sub")?.Value, out var id)
        ? id
        : throw AppException.Unauthorized("Token khong hop le");
}
