using CargoTrack.Business.Services.Abstract;
using CargoTrack.DataAccess.Repositories.Abstract;
using CargoTrack.DTO.Auth;
using CargoTrack.Entity.Common;
using CargoTrack.Entity.Entities;
using Microsoft.AspNetCore.Identity;

namespace CargoTrack.Business.Services.Concrete;

public class AuthService : IAuthService
{
    // Bilerek belirsiz: "bu e-posta kayıtlı değil" demek, saldırgana hangi hesapların var olduğunu söyler
    private const string InvalidLoginMessage = "E-posta veya şifre hatalı.";

    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly IRepository<Customer> _customerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AuthService(
        UserManager<AppUser> userManager,
        SignInManager<AppUser> signInManager,
        IRepository<Customer> customerRepository,
        IUnitOfWork unitOfWork)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _customerRepository = customerRepository;
        _unitOfWork = unitOfWork;
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

    public async Task<AuthResult> RegisterAsync(RegisterDto dto)
    {
        var user = new AppUser
        {
            UserName = dto.Email,
            Email = dto.Email,
            FirstName = dto.FirstName.Trim(),
            LastName = dto.LastName.Trim(),
            PhoneNumber = dto.Phone,
            IsActive = true,
            CreatedDate = DateTime.Now
        };

        // 3 ayrı SaveChanges (kullanıcı, rol, müşteri) → tek paket: ya hep ya hiç
        await _unitOfWork.BeginTransactionAsync();
        try
        {
            var createResult = await _userManager.CreateAsync(user, dto.Password);
            if (!createResult.Succeeded)
            {
                await _unitOfWork.RollbackTransactionAsync();
                return AuthResult.Failure(createResult.Errors.Select(e => e.Description).ToArray());
            }

            // Rolü kullanıcı seçmez, sunucu verir (4.4a)
            var roleResult = await _userManager.AddToRoleAsync(user, RoleNames.User);
            if (!roleResult.Succeeded)
            {
                await _unitOfWork.RollbackTransactionAsync();
                return AuthResult.Failure(roleResult.Errors.Select(e => e.Description).ToArray());
            }

            var customer = new Customer
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = dto.Phone,
                Email = dto.Email,
                AppUserId = user.Id // CreateAsync sonrası Id dolu
            };

            await _customerRepository.AddAsync(customer);
            await _unitOfWork.SaveChangesAsync();

            await _unitOfWork.CommitTransactionAsync();
        }
        catch
        {
            await _unitOfWork.RollbackTransactionAsync();
            throw; // beklenmeyen hata: yutma, yukarı fırlat
        }

        // Kayıt olan kullanıcı tekrar login ekranıyla uğraşmasın
        await _signInManager.SignInAsync(user, isPersistent: false);
        return AuthResult.Success();
    }

    public Task LogoutAsync() => _signInManager.SignOutAsync();
}
