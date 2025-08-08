using Domain.Common.Mappings;
using Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain;

public static class DependencyInjection
{
    public static IServiceCollection AddDomain(this IServiceCollection services, IConfiguration Configuration)
    {

        services.AddAutoMapper(typeof(DependencyInjection).Assembly, typeof(MyAutomapper).Assembly);

        services.Configure<Apis>(opt => Configuration.GetSection("Apis").Bind(opt));

        return services;
    }
}
