using Microsoft.Extensions.DependencyInjection;
using UContactStats.Feature.StoreProcedureModule.Handlers;
using UContactStats.Feature.StoreProcedureModule.Interface;

namespace UContactStats.Extensions;

public static class Application
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Handler
        services.AddScoped<IStoreProcedureHandlers, StoreProcedureHandlers>();

        return services;
    }
}
