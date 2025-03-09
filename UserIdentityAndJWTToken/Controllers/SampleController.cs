using Application;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace UserIdentityAndJWTToken.Controllers;

[ApiController]
[Route("API/Controller")]
public class SampleController:ControllerBase
{
    private readonly UserService userService;

    public SampleController(UserService userService)
    {
        this.userService = userService;
    }
    [HttpPost]
    public async Task<IActionResult> Create(Users user)
    {
        var result= await userService.AddService(user);

        return Ok(result);
    }
}
