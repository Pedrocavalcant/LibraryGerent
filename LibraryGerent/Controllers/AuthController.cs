using LibraryGerent.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryGerent.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly ITokenService _tokenService;

    public AuthController(ITokenService tokenService)
    {
        _tokenService = tokenService;
    }

    [HttpPost]
    [Route("token")]
    [AllowAnonymous]
    public IActionResult GerarToken()
    {
        var token = _tokenService.GenerateToken(Guid.NewGuid(), "teste@teste.com", "UsuarioTeste");
        return Ok(new { access_token = token });
    }
}
