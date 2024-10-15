using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.Extensions.Configuration;

namespace UContactStats.Configs;

public class KeyVault
{
    public static SecretClient KeyVaultConfiguration(IConfiguration config)
    {
        var vault = config["KeyVault:Vault"];
        var tenantId = config["keyVault:TenantId"];
        var appId = config["keyVault:AppId"];
        var clientSecret = config["keyVault:ClientSecret"];

        if (string.IsNullOrEmpty(vault)) throw new ArgumentNullException(nameof(vault), "KeyVault URI is not configured.");
        if (string.IsNullOrEmpty(tenantId)) throw new ArgumentNullException(nameof(tenantId), "TenantId is not configured.");
        if (string.IsNullOrEmpty(appId)) throw new ArgumentNullException(nameof(appId), "AppId is not configured.");
        if (string.IsNullOrEmpty(clientSecret)) throw new ArgumentNullException(nameof(clientSecret), "ClientSecret is not configured.");

        var credential = new ClientSecretCredential(tenantId, appId, clientSecret);
        var secretClient = new SecretClient(new Uri(vault), credential);
        return secretClient;
    }
}
