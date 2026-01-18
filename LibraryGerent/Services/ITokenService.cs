namespace LibraryGerent.Api.Services;

public interface ITokenService
{
    string GenerateToken(Guid userId, string email, string userName);
}
