using Microsoft.AspNetCore.Mvc;

namespace PhamDinhGiaBao_2380600166.ChamCong.Api.Controllers;

[ApiController]
[Route("api/health")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new { status = "ok" });
}
