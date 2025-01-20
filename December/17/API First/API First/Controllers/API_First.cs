using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_First.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class API_First : ControllerBase
{
    [AllowAnonymous]
    [HttpPost("API_First_Test")]
    public async Task<IActionResult> API_First_Test()
    {
        return Ok("API First working");
    }
}