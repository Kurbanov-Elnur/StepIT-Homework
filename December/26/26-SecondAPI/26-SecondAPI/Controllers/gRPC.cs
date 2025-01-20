using _26_SecondAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _26_SecondAPI.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class gRPC : ControllerBase
{
    private readonly ITest _test;

    public gRPC(ITest test)
    {
        _test = test;
    }

    [AllowAnonymous]
    [HttpPost("gRPC")]
    public async Task<IActionResult> gRPC_Test([FromBody] string name)
    {
        var response = await _test.TestAsync(name);
        return Ok(response);
    }
}