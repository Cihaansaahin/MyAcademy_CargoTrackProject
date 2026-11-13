using CargoTrack.Business.Services.Abstract;
using CargoTrack.DTO.Auth;
using CargoTrack.Entity.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CargoTrack.WebUI.Controllers;

public class AccountController : Controller
{
    private readonly IAuthService _authService;

    public AccountController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Login(string? returnUrl = null)
    {
        // Zaten içerideyse login formunu gösterme
        if (User.Identity?.IsAuthenticated == true)
            return RedirectToAction("Index", "Home");

        return View(new LoginDto { ReturnUrl = returnUrl });
    }

    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken] // CSRF: form gerçekten bizim sayfamızdan mı geldi?
    public async Task<IActionResult> Login(LoginDto dto)
    {
        if (!ModelState.IsValid)
            return View(dto);

        var result = await _authService.LoginAsync(dto);
        if (!result.Succeeded)
        {
            AddErrors(result);
            return View(dto);
        }

        return RedirectAfterLogin(dto.ReturnUrl, result.Roles);
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Register()
    {
        if (User.Identity?.IsAuthenticated == true)
            return RedirectToAction("Index", "Home");

        return View(new RegisterDto());
    }

    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterDto dto)
    {
        if (!ModelState.IsValid)
            return View(dto);

        var result = await _authService.RegisterAsync(dto);
        if (!result.Succeeded)
        {
            AddErrors(result);
            return View(dto);
        }

        return RedirectToPanel(result.Roles);
    }

    [HttpPost]
    [Authorize]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await _authService.LogoutAsync();
        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult AccessDenied() => View();

    // Servisten gelen hataları formun üstündeki özet alanına taşı
    private void AddErrors(AuthResult result)
    {
        foreach (var error in result.Errors)
            ModelState.AddModelError(string.Empty, error);
    }

    // Önce ReturnUrl (kullanıcı belirli bir sayfaya gitmek istiyordu), yoksa kendi paneli.
    // Open redirect koruması: sadece kendi sitemizin adreslerine dön.
    private IActionResult RedirectAfterLogin(string? returnUrl, IReadOnlyList<string> roles)
    {
        if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
            return LocalRedirect(returnUrl);

        return RedirectToPanel(roles);
    }

    // Birden fazla rolü olan kullanıcıda en yetkili rol kazanır
    private IActionResult RedirectToPanel(IReadOnlyList<string> roles)
    {
        if (roles.Contains(RoleNames.Admin))
            return RedirectToAction("Index", "Dashboard", new { area = "Admin" });

        if (roles.Contains(RoleNames.Manager))
            return RedirectToAction("Index", "Dashboard", new { area = "Manager" });

        if (roles.Contains(RoleNames.User))
            return RedirectToAction("Index", "Dashboard", new { area = "User" });

        return RedirectToAction("Index", "Home");
    }
}
