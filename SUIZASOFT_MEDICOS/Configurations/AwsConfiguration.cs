using Amazon;
using Domain.Models;

namespace SUIZASOFT_MEDICOS.Configurations;

public static class SecretsConfiguration
{
    public static IConfigurationBuilder AddSecretsConfiguration(this IConfigurationBuilder builder, string env)
    {
        var regionAws = env == SD.Environments.Production ? RegionEndpoint.USEast1 : RegionEndpoint.USEast2;

        if (env == SD.Environments.Production || env == SD.Environments.Qa)
        {
            builder.AddSecretsManager(region: regionAws, configurator: options =>
            {
                options.SecretFilter = entry =>
                {
                    if (entry.Name.StartsWith($"{env}_Database_") ||
                        entry.Name.StartsWith($"{env}_ServiceDiscovery_") ||
                        entry.Name.StartsWith($"{env}_Secrets_"))
                        return true;
                    else
                        return false;
                };

                options.KeyGenerator = (_, s) => s
                    .Replace($"{env}_Database_", string.Empty)
                    .Replace($"{env}_ServiceDiscovery_", string.Empty)
                    .Replace($"{env}_Secrets_", string.Empty)
                    .Replace("__", ":");
            });
        }
        return builder;
    }
}
