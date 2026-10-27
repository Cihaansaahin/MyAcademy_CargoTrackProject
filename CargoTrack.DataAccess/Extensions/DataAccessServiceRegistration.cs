using CargoTrack.DataAccess.Context;
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
}