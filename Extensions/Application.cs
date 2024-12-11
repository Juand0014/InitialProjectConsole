using Microsoft.Extensions.DependencyInjection;
using RCIInterface.Feature.Handlers;
using RCIInterface.Feature.StoreProcedureModule.Handlers;
using RCIInterface.Feature.StoreProcedureModule.Interface;
using RCIInterface.Interfaces.Handler;

namespace RCIInterface.Extensions;

public static class Application
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Handler
        services.AddScoped<IStoreProcedureHandlers, StoreProcedureHandlers>();
        services.AddScoped<IGetAccessTokenHandler, GetAccessTokenHandler>();

        return services;
    }
}
