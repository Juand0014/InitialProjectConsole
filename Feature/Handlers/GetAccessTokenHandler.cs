using Microsoft.Extensions.Configuration;
using RCIInterface.Interfaces.Handler;
using RCISERVICES;

namespace RCIInterface.Feature.Handlers;

public class GetAccessTokenHandler : IGetAccessTokenHandler
{
    private readonly WSOrquestadorSoap _services;
    private readonly IConfiguration _configuration;

    public GetAccessTokenHandler(WSOrquestadorSoap services, IConfiguration configuration)
    {
        _services = services;
        _configuration = configuration;
    }

    public void GetAccessToken()
    {
        Header_Orchestrator header_Orchestrator = new Header_Orchestrator
        {
            UserName = _configuration["RCIConfig:UserNameRCI"],
            Password = _configuration["RCIConfig:PasswordRCI"],
            ResortID = _configuration["RCIConfig:ResortIDRCI"],
            Source = _configuration["RCIConfig:SourceRCI"]
        };

        GetAccessTokenRequest request = new GetAccessTokenRequest
        {
            Header_Orchestrator = header_Orchestrator
        };

        var result = _services.GetAccessToken(request);
        Console.WriteLine(result);
    }
}
