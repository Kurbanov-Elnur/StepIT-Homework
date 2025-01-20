using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_Second.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class API_First : ControllerBase
{
    [AllowAnonymous]
    [HttpPost("API_Second_Test")]
    public async Task<IActionResult> API_Second_Test()
    {
        return Ok("API Second working");
    }
}