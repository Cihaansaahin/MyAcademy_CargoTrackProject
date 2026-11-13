using CargoTrack.DTO.Auth;

namespace CargoTrack.Business.Services.Abstract;

public interface IAuthService
{
    Task<AuthResult> LoginAsync(LoginDto dto);
    Task LogoutAsync();
}
