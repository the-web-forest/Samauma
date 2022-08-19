using Azure.Core;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace Samauma.Configuration
{
    public static class Secrets
    {
       public static void Configure(WebApplicationBuilder builder) {

            var VaultUri = Environment.GetEnvironmentVariable("VAULT_URL");

            if (VaultUri is not null)
            {
                SecretClientOptions options = new SecretClientOptions()
                {
                    Retry = {
                    Delay = TimeSpan.FromSeconds(2),
                    MaxDelay = TimeSpan.FromSeconds(16),
                    MaxRetries = 5,
                    Mode = RetryMode.Exponential
                 }
                };

                var client = new SecretClient(new Uri(VaultUri), new DefaultAzureCredential(), options);

                var DatabaseConnectionString = client.GetSecret("Trees-Databases-Cosmos-ConnectionString").Value.Value;
                var DatabaseName = client.GetSecret("Trees-Databases-Cosmos-Ipe-Name").Value.Value;

                var StorageConnectionString = client.GetSecret("Trees-Storage-ConnectionString").Value.Value;
                var StorageContainerName = client.GetSecret("Trees-Storage-Container-Name").Value.Value;
                var StorageCdnUrl = client.GetSecret("Trees-Storage-Cdn-Url").Value.Value;

                var JwtKey = client.GetSecret("Trees-Samauma-Jwt-Key").Value.Value;

                builder.Configuration["Database:ConnectionString"] = DatabaseConnectionString;
                builder.Configuration["Database:Name"] = DatabaseName;

                builder.Configuration["Storage:ConnectionString"] = StorageConnectionString;
                builder.Configuration["Storage:TreeContainerName"] = StorageContainerName;
                builder.Configuration["Storage:TreeCdnUrl"] = StorageCdnUrl;

                builder.Configuration["Jwt:Key"] = JwtKey;
            }
        }

    }
}

