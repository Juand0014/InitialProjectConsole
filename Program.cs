using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using UContactStats;

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
    Console.WriteLine(host.ToString());
    Console.WriteLine("I'm ready");
    Console.ReadLine();
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}