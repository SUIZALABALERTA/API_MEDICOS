using Application.Interfaces.IProxies;
using Application.Interfaces.IRepository;
using Application.Interfaces.IServices;
using Application.Proxies;
using Application.Services.Atenciones;
using Application.Services.Medicos;
using Infrastructure.ExternalServices.SaveFileAwsApi;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<SuizasoftContext>(options =>
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        });

        services.AddHttpClient<SaveFileClient>("SaveFileClient", config =>
        {
            config.BaseAddress = new Uri(configuration["Apis:ApiSaveFilesAwsEndPoint"]);
            config.Timeout = TimeSpan.FromSeconds(60);
        });

        services.AddScoped<IMedicoRepository, MedicoRepository>();
        services.AddScoped<IAtencionesRepository, AtencionesRepository>();

        services.AddHttpClient<IPacienteProxy, PacienteProxy>();
        services.AddScoped<IPacienteProxy, PacienteProxy>();


        services.AddScoped<IMedicoService, MedicoService>()
            .AddScoped<IAtencionesService, AtencionesService>()
                .AddScoped<ISaveFilesAwsService, SaveFileService>();

        return services;

    }
}
