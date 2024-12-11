using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RCIInterface;
using RCIInterface.Interfaces.Handler;

IHostBuilder CreateHostBuilder() => 
    Host.CreateDefaultBuilder()
        .ConfigureServices((hostContext, services) =>
        {
            IConfiguration configuration = hostContext.Configuration;

            Startup startup = new Startup();

            startup.ConfigureServices(services, configuration);
        });

try
{
    IHost host = CreateHostBuilder().Build();
    Console.WriteLine("Start Process..... ");
    host.Services.GetRequiredService<IGetAccessTokenHandler>().GetAccessToken();

    Console.WriteLine("Steps Begin...");
    Console.ReadLine();


}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}