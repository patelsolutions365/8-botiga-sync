using BotigaSync.Contracts.Services;
using BotigaSync.RepositoryService.Handlers;
using BotigaSync.RepositoryService.Services;

namespace BotigaSync.API.Utilities;
public static class ServiceInjector
{
    public static IServiceCollection ConfigureAppServices(this IServiceCollection services)
    {
        services.AddScoped<ISyncEventService, SyncEventService>();
        services.AddSingleton<ISyncEventValidator, SaleSyncEventValidator>();
        return services;
    }
}
