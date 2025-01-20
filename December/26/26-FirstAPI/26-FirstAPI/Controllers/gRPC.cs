using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _26_FirstAPI.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class gRPC : ControllerBase
{
    [AllowAnonymous]
    [HttpPost("gRPC")]
    public async Task<IActionResult> gRPC_Test()
    {
        return Ok("API First working");
    }
}