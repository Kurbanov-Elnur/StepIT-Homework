using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _7.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class HomeWork : ControllerBase
{
    [AllowAnonymous]
    [HttpPost("Test")]
    public async Task<IActionResult> Test([FromBody] string name)
    {
        return Ok(name);
    }   
}