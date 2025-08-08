using Consul;
using Domain.Models;
using Newtonsoft.Json.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace SUIZASOFT_MEDICOS.Extensions;

public static class ConsulExtension
{
    public static IServiceCollection AddConsulConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IConsulClient, ConsulClient>(p => new ConsulClient(consulConfig =>
        {
            var address = configuration.GetValue<string>("Consul:Host");
            consulConfig.Address = new Uri(address);
            consulConfig.Token = configuration.GetValue<string>("Consul:Apikey");
        }));

        return services;
    }

    public static IApplicationBuilder UseConsul(this IApplicationBuilder app, string serviceName, string discoveryName, string env)
    {
        var configuration = app.ApplicationServices.GetRequiredService<IConfiguration>();

        var consulClient = app.ApplicationServices.GetRequiredService<IConsulClient>();
        var logger = app.ApplicationServices.GetRequiredService<ILoggerFactory>().CreateLogger($"AppExtensions-{serviceName}");
        var lifetime = app.ApplicationServices.GetRequiredService<IHostApplicationLifetime>();

        string ipStr = string.Empty;

        NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

        NetworkInterface interfazPrivada = interfaces.FirstOrDefault(
            i => i.GetIPProperties().UnicastAddresses.Any(
                a => a.Address.AddressFamily == AddressFamily.InterNetwork &&
                     a.Address.ToString().StartsWith("10.") ||
                     a.Address.ToString().StartsWith("172.") ||
                     a.Address.ToString().StartsWith("192.168.")
            )
        );

        if (interfazPrivada != null)
        {
            string ipPrivada = interfazPrivada.GetIPProperties().UnicastAddresses
                                              .FirstOrDefault(a => a.Address.AddressFamily == AddressFamily.InterNetwork)?.Address
                                              .ToString();
            Console.WriteLine($"Dirección IP privada: {ipPrivada}");
            ipStr = $"http://{ipPrivada}:5000";
        }
        else
        {
            Console.WriteLine("No se encontró una dirección IP privada.");
        }

        var datenow = DateTime.UtcNow.AddHours(-5);
        var fecha = $"{datenow.ToShortDateString().Replace("/", "-")}";
        var splitFecha = fecha.Split("-");
        var nuevaFecha = $"{splitFecha[1]}-{splitFecha[0]}-{splitFecha[2]}";
        var hora = datenow.ToShortTimeString();
        var uri = new Uri(ipStr);

        var GeneratedId = $"{discoveryName}=>{env}=>{SD.Api.InstanceId}=>{fecha}=>{hora}";
        var registration = new AgentServiceRegistration()
        {
            Name = discoveryName,
            ID = GeneratedId,
            Address = uri.Host,
            Port = uri.Port,
            Check = new AgentServiceCheck()
            {
                HTTP = $"{uri.Scheme}://{uri.Host}:{uri.Port}/health",
                Method = "GET",
                Timeout = TimeSpan.FromSeconds(5),
                Interval = TimeSpan.FromSeconds(30),
                DeregisterCriticalServiceAfter = TimeSpan.FromSeconds(25)
            }
        };

        logger.LogInformation($"Registering {serviceName} with Consul");
        consulClient.Agent.ServiceDeregister(registration.ID).ConfigureAwait(true);
        consulClient.Agent.ServiceRegister(registration).ConfigureAwait(true);

        // Get the ApiSettings key from Consul

        var requestConsul = consulClient.KV.List(discoveryName).Result;

        if (requestConsul.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var result = new Dictionary<string, string>();

            requestConsul.Response.ToList().ForEach(entry => result.Add(entry.Key, Encoding.UTF8.GetString(entry.Value)));

            if (result.TryGetValue(discoveryName, out string appSettingsObj))
            {
                JObject appSettings = JObject.Parse(appSettingsObj);

                foreach (var setting in appSettings)
                {
                    if (setting.Value.Type == JTokenType.Object)
                    {
                        foreach (var prop in setting.Value.Children().Select(r => r.Path))
                        {
                            var name = prop.Split('.').Last();
                            configuration.GetSection($"{setting.Key}:{name}").Value = (string)appSettings[setting.Key][name];
                        }
                    }
                    else
                    {
                        configuration.GetSection(setting.Key).Value = (string)setting.Value;
                    }
                }
            }
        }

        lifetime.ApplicationStopping.Register(() =>
        {
            logger.LogInformation($"Unregistering {serviceName} from Consul");
            consulClient.Agent.ServiceDeregister(registration.ID).Wait();
        });

        return app;
    }

}