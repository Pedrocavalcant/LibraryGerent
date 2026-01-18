using LibraryGerent.Api.Auth;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LibraryGerent.Api.Services;

public class AuthService(TokenService tokenService)
{
    private readonly TokenService _tokenService = tokenService;
}
