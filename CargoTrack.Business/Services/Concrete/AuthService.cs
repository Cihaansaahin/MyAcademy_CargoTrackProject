using CargoTrack.Business.Services.Abstract;
using CargoTrack.DTO.Auth;
using CargoTrack.Entity.Entities;
using Microsoft.AspNetCore.Identity;

namespace CargoTrack.Business.Services.Concrete;

public class AuthService : IAuthService
{
    // Bilerek belirsiz: "bu e-posta kayıtlı değil" demek, saldırgana hangi hesapların var olduğunu söyler
    private const string InvalidLoginMessage = "E-posta veya şifre hatalı.";

    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<AuthResult> LoginAsync(LoginDto dto)
    {
        var user = await _userManager.FindByEmailAsync(dto.Email);
        if (user is null)
            return AuthResult.Failure(InvalidLoginMessage);

        // Önce şifre: yanlış denemeler sayılır, 5'te kilit (4.1b ayarı)
        var check = await _signInManager.CheckPasswordSignInAsync(
            user, dto.Password, lockoutOnFailure: true);

        if (check.IsLockedOut)
            return AuthResult.Failure("Çok fazla hatalı deneme. Hesabınız 5 dakika kilitlendi.");

        if (!check.Succeeded)
            return AuthResult.Failure(InvalidLoginMessage);

        // Şifre doğru ama hesap pasif: bu bilgiyi sadece şifreyi bilene veriyoruz
        if (!user.IsActive)
            return AuthResult.Failure("Hesabınız pasif durumda. Lütfen yöneticinizle iletişime geçin.");

        // Her şey tamam: cookie'yi (bilekliği) ver
        await _signInManager.SignInAsync(user, isPersistent: dto.RememberMe);
        return AuthResult.Success();
    }

    public Task LogoutAsync() => _signInManager.SignOutAsync();
}
