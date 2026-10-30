using CargoTrack.DataAccess.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace CargoTrack.Business.Extensions;

public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessLayer(
        this IServiceCollection services, string connectionString)
    {
        services.AddDataAccessLayer(connectionString);

        return services;
    }

    public static Task InitializeBusinessLayerAsync(
    this IServiceProvider serviceProvider, bool includeDemoData)
    {
        return serviceProvider.SeedDataAccessAsync(includeDemoData);
    }
}