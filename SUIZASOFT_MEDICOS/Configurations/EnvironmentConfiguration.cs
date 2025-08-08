namespace SUIZASOFT_MEDICOS.Configurations;

public static class EnvironmentConfiguration
{
    public static IHostBuilder AddEnvironmentConfiguration(this IHostBuilder host, string env)
    {
        host.ConfigureAppConfiguration((ctx, builder) =>
        {
            builder.AddJsonFile("appsettings.json", false, true);
            builder.AddJsonFile($"appsettings.{env}.json", true, true);
            builder.AddEnvironmentVariables();
        });

        return host;
    }
}
