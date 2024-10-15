using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Solvex.Dynamic365.ServiceClient;
using System.Text.Json;
using UContactStats.Configs;
using UContactStats.Configs.Models;
using UContactStats.Context;
using UContactStats.Interfaces;
using UContactStats.Repositories;

namespace UContactStats.Extensions;

public static class Infrastructure
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var secretClient = KeyVault.KeyVaultConfiguration(configuration);

        var dynamicsApiConfig = JsonSerializer.Deserialize<DynamicsConfig>(secretClient.GetSecret("DynamicsConfig").Value.Value);
        if (dynamicsApiConfig == null) throw new ArgumentNullException(nameof(dynamicsApiConfig), "dynamicsApiConfig is not configured.");

        var connectionString = JsonSerializer.Deserialize<ConnectionStringsConfig>(secretClient.GetSecret("ConnectionStrings").Value.Value);
        if (connectionString == null) throw new ArgumentNullException(nameof(connectionString), "connectionString is not configured.");

        services.AddDbContext<DBContext>(option => option.UseSqlServer(connectionString!.OHInterface_ConnectionString));

        services.AddScoped<IOHRepository, OHRepository>();

        services.AddSingleton(dynamicsApiConfig);
        return services;
    }
}
