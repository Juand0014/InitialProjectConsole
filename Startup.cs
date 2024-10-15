﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Solvex.Dynamic365.ServiceClient;
using UContactStats.Extensions;

namespace UContactStats;

public class Startup
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddApplication();
        services.AddInfrastructure(configuration);

        services.AddTransient<IDynamicsConsumptionApi, DynamicsConsumptionApi>();
    }
}
