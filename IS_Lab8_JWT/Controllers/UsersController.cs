using IS_Lab8_JWT.Model;
using IS_Lab8_JWT.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IS_Lab8_JWT.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController: ControllerBase
{
    private IUserService userService;

    public UsersController(IUserService userService)
    {
        this.userService = userService;
    }
    
    [HttpPost("authenticate")]
    public IActionResult Authenticate(AuthenticationRequest request)
    {
        var response = userService.Authenticate(request);

        if (response == null)
        {
            return BadRequest(new { message = "Username or password is incorrect" });
        }

        return Ok(response);
    }

    [HttpGet("all")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Authorize(Roles = "admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public IActionResult GetAllUsers()
    {
        var response = userService.GetUsers();

        if (response == null)
        {
            return BadRequest(new { message = "Username or password is incorrect" });
        }

        return Ok(response);
    }
    
    [HttpGet("count")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Authorize(Roles = "user", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public IActionResult GetUsersCount()
    {
        var response = userService.GetUsers().Count();

        if (response == null)
        {
            return BadRequest(new { message = "Username or password is incorrect" });
        }

        return Ok(response);
    }
    
}