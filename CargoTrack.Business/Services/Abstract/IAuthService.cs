using CargoTrack.DTO.Auth;

namespace CargoTrack.Business.Services.Abstract;

public interface IAuthService
{
    Task<AuthResult> LoginAsync(LoginDto dto);
    Task<AuthResult> RegisterAsync(RegisterDto dto);
    Task LogoutAsync();
}
