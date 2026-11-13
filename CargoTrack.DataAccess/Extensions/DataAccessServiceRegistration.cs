using CargoTrack.DataAccess.Context;
using CargoTrack.DataAccess.Repositories.Abstract;
using CargoTrack.DataAccess.Repositories.Concrete;
using CargoTrack.DataAccess.Seed;
using CargoTrack.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CargoTrack.DataAccess.Extensions;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessLayer(
        this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<CargoTrackDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddIdentity<AppUser, AppRole>(options =>
            {
                // Şifre kuralları
                options.Password.RequiredLength = 8;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = false;

                // Kullanıcı kuralları
                options.User.RequireUniqueEmail = true;

                // Kilitleme: 5 yanlış denemede 5 dakika kilit
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;
            })
            .AddEntityFrameworkStores<CargoTrackDbContext>()
            .AddDefaultTokenProviders();

        return services;
    }
    public static async Task SeedDataAccessAsync(
    this IServiceProvider serviceProvider, bool includeDemoData)
    {
        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<CargoTrackDbContext>();

        await DbSeeder.SeedAsync(context, includeDemoData);
    }


}