using Domain.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace SUIZASOFT_MEDICOS.Configurations;

public static class SecurityConfiguration
{
    public static IServiceCollection AddSecurityConfiguration(this IServiceCollection services, IConfiguration configuration, string env)
    {

        services.Configure<DatabaseSettings>(configuration.GetSection(DatabaseSettings.SectionName));

        var secretKey = Encoding.ASCII.GetBytes(configuration.GetSection("TokenManagement:SecretKey").Value);
        var decriptKey = Encoding.UTF8.GetBytes(configuration.GetSection("TokenManagement:EncryptionSecret").Value);


        services.AddControllers(config =>
        {
            var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
            config.Filters.Add(new AuthorizeFilter(policy));
        }).AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);


        services.Configure<RequestLocalizationOptions>(options =>
        {
            options.DefaultRequestCulture = new RequestCulture("es-PE");
        });

        services.AddLocalization(options => options.ResourcesPath = "Resources");



        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(secretKey),
            TokenDecryptionKey = new SymmetricSecurityKey(decriptKey),
            ValidateIssuer = false,
            ValidateAudience = false,
            RequireExpirationTime = false,
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero,
        };

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(x =>
        {
            x.RequireHttpsMetadata = false;
            x.SaveToken = true;
            x.TokenValidationParameters = tokenValidationParameters;
            x.Events = new JwtBearerEvents()
            {
                OnChallenge = context =>
                {
                    context.HandleResponse();

                    var payload = new JObject
                    {
                        ["Code"] = "401",
                        ["Message"] = $"¡Acceso no Autorizado!",
                        ["Data"] = null,
                        ["Enviroment"] = env,
                        ["InstanceId"] = SD.Api.InstanceId
                    };

                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = 401;

                    return context.Response.WriteAsync(payload.ToString());
                },
                OnForbidden = context =>
                {
                    var payload = new JObject
                    {
                        ["Code"] = "403",
                        ["Message"] = "!Acceso sin permisos requeridos!",
                        ["Data"] = null,
                        ["Enviroment"] = env,
                        ["InstanceId"] = SD.Api.InstanceId
                    };

                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = 403;

                    return context.Response.WriteAsync(payload.ToString());
                },
            };
        });

        return services;

    }
}


