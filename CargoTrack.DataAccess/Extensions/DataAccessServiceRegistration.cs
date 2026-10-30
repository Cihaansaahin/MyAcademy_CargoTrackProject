using CargoTrack.DataAccess.Context;
using CargoTrack.DataAccess.Seed;
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