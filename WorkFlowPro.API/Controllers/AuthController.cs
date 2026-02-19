using Microsoft.AspNetCore.Mvc;
using WorkFlowPro.Application.Interface;
using WorkFlowPro.Application.ModelsDTO;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var result = await _authService.RegisterAsync(request);
        return Ok(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var result = await _authService.LoginAsync(request);
        return Ok(result);
    }

    [HttpGet("protected")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public IActionResult Protected()
    {
        return Ok("You are authenticated");
    }
}
