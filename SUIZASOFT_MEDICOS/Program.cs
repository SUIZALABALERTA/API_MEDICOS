using Application;
using Domain;
using Domain.Models;
using Infrastructure;
using SUIZASOFT_MEDICOS.Configurations;
using SUIZASOFT_MEDICOS.Extensions;
using SUIZASOFT_MEDICOS.Middleware;

var builder = WebApplication.CreateBuilder(args);

var Configuration = builder.Configuration;

var serviceName = Configuration.GetValue<string>("AppSettings:ServiceName");
var discoveryName = Configuration.GetValue<string>("AppSettings:DiscoveryName");
var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");


builder.Host.AddEnvironmentConfiguration(environmentName);
builder.Services.AddSecurityConfiguration(Configuration, environmentName);

builder.Services.AddDomain(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();


builder.Services.AddSwaggerConfiguration(serviceName);


builder.Services.AddCors(o =>
{
    o.AddPolicy(SD.Cors.DefaultPolicy,
          builder => builder
              .WithOrigins(SD.Cors.Origins)
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials());
});



var app = builder.Build();

app.UseLocalGeography();

if (environmentName == SD.Environments.Development || environmentName == SD.Environments.Qa)
{
    app.UseSwagger();

    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{serviceName} - {environmentName}");
        c.InjectStylesheet("/swagger-ui/SwaggerDark.css");
        c.RoutePrefix = string.Empty;
    });
}

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseCors(SD.Cors.DefaultPolicy);

app.UseCustomMiddleware();

app.UseAuthorization();

app.UseAuthentication();

app.MapControllers();

app.Run();
