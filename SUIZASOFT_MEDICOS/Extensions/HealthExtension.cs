using Domain.Models;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Newtonsoft.Json;

namespace SUIZASOFT_MEDICOS.Extensions;

public static class HealthExtension
{
    public static IApplicationBuilder UseHealthCheck(this IEndpointRouteBuilder app, string serviceName, string environment)
    {

        app.MapHealthChecks("/health", new HealthCheckOptions()
        {
            ResponseWriter = async (context, report) =>
            {
                context.Response.ContentType = "application/json";
                var result = new HealthCheckResponse
                {
                    InstanceId = SD.Api.InstanceId,
                    ServiceName = serviceName,
                    Environment = environment,
                    Status = report.Status.ToString(),
                    Checks = report.Entries.Select(e => new HealthCheck
                    {
                        Component = e.Key,
                        Status = e.Value.Status.ToString(),
                        Description = e.Value.Description,
                    }),
                    Duration = report.TotalDuration
                };
                await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
            }
        });

        return (IApplicationBuilder)app;
    }
}

public class HealthCheck
{
    public string Status { get; set; }
    public string Component { get; set; }
    public string Description { get; set; }

}

public class HealthCheckResponse
{
    public string Status { get; set; }
    public IEnumerable<HealthCheck> Checks { get; set; }
    public TimeSpan Duration { get; set; }
    public string InstanceId { get; set; }
    public string ServiceName { get; set; }
    public string Environment { get; set; }

}