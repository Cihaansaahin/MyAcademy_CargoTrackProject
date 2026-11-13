using CargoTrack.Entity.Common;
using CargoTrack.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace CargoTrack.DataAccess.Seed
{
    public static class IdentitySeeder
    {
        public static async Task SeedAsync(
            RoleManager<AppRole> roleManager,
            UserManager<AppUser> userManager,
            IConfiguration configuration)
        {
            // 1) Roller: yoksa oluştur (idempotent)
            foreach (var roleName in RoleNames.All)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    var roleResult = await roleManager.CreateAsync(new AppRole { Name = roleName });
                    EnsureSucceeded(roleResult, $"'{roleName}' rolü oluşturulamadı");
                }
            }

            // 2) Admin kullanıcısı
            var section = configuration.GetSection("AdminUser");
            var email = section["Email"]
                ?? throw new InvalidOperationException(
                    "AdminUser:Email ayarı bulunamadı (WebUI/appsettings.json).");

            var admin = await userManager.FindByEmailAsync(email);

            if (admin is null)
            {
                // Şifre sadece ilk oluşturmada gerekir
                var password = section["Password"]
                    ?? throw new InvalidOperationException(
                        "AdminUser:Password bulunamadı. WebUI'a sağ tık → Manage User Secrets ile ekleyin.");

                admin = new AppUser
                {
                    UserName = email,
                    Email = email,
                    EmailConfirmed = true,
                    FirstName = section["FirstName"] ?? "Sistem",
                    LastName = section["LastName"] ?? "Yöneticisi",
                    IsActive = true,
                    CreatedDate = DateTime.Now // AppUser BaseEntity değil, otomatik dolmaz
                };

                var createResult = await userManager.CreateAsync(admin, password);
                EnsureSucceeded(createResult, "Admin kullanıcısı oluşturulamadı");
            }

            // 3) Admin rolünde değilse ekle
            if (!await userManager.IsInRoleAsync(admin, RoleNames.Admin))
            {
                var roleAddResult = await userManager.AddToRoleAsync(admin, RoleNames.Admin);
                EnsureSucceeded(roleAddResult, "Admin rolü atanamadı");
            }
        }

        // Identity hata fırlatmaz, IdentityResult döner: kontrol etmezsek sessiz felaket
        private static void EnsureSucceeded(IdentityResult result, string message)
        {
            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new InvalidOperationException($"{message}: {errors}");
            }
        }
    }
}
