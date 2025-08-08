using Domain.Results;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddControllers()
            .AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            });

        services.AddMvcCore().ConfigureApiBehaviorOptions(options =>
        {
            options.InvalidModelStateResponseFactory = context =>
            {
                var problemDetailsFactory = context.HttpContext.RequestServices.GetRequiredService<ProblemDetailsFactory>();
                var problemDetails = problemDetailsFactory.CreateValidationProblemDetails(
                    context.HttpContext,
                    context.ModelState,
                    statusCode: 422,
                    type: "Validaciones",
                    title: "Ha ocurrido uno o mas errores",
                    detail: "Error de Validaciones");
                var result = new UnprocessableEntityObjectResult(MessageResult<object>.Of(problemDetails.Detail, problemDetails.Errors.Select(p => p.Value.Select(s => s).ToList()).ToList(), status: 422, code: 22));
                result.ContentTypes.Add("application/problem+json");
                result.ContentTypes.Add("application/problem+xml");
                return result;
            };
        });

        return services;
    }
}
