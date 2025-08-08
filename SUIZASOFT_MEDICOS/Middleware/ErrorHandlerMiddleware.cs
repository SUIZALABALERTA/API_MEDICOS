using Domain.Models;
using Domain.Results;
using Newtonsoft.Json;
using System.Net;
using System.Security.Claims;

namespace SUIZASOFT_MEDICOS.Middleware;

public sealed class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IConfiguration _configuration;

    public ErrorHandlerMiddleware(RequestDelegate next, IConfiguration configuration)
    {
        _next = next;
        _configuration = configuration;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            var requestApiKey = context.Request.Headers["X-API-Key"].FirstOrDefault();

            if (!string.IsNullOrEmpty(requestApiKey))
            {
                string agent = context.Request.Headers["Agente"].FirstOrDefault();

                if (string.IsNullOrEmpty(agent))
                    throw new ErrorHandler(HttpStatusCode.NotAcceptable, "Agente no especificado", status: (int)HttpStatusCode.NotAcceptable, internalResponse: 0);

                if (requestApiKey == _configuration.GetSection("TokenManagement:ApiKey").Value)
                {
                    var claims = new[] { new Claim("username", agent) };
                    var identity = new ClaimsIdentity(claims, "ApiKey");
                    context.User = new ClaimsPrincipal(identity);
                }
            }
            await _next(context);
        }
        catch (Exception ex)
        {
            await ErrorHandlerAsync(context, ex);
        }
    }

    private async Task ErrorHandlerAsync(HttpContext context, Exception ex)
    {
        string message = string.Empty;

        context.Response.ContentType = "application/json";

        switch (ex)
        {
            case ErrorHandler eh:

                context.Response.StatusCode = (int)eh.Code;

                message = eh.Message;

                await context.Response.WriteAsync(JsonConvert.SerializeObject(MessageResult<object>.Of(message, eh.ExceptionData, eh.Status, eh.InternalResponse)));

                break;

            case Exception e:

                message = string.IsNullOrWhiteSpace(e.Message) ? "Error desconocido" : e.Message;

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                await context.Response.WriteAsync(JsonConvert.SerializeObject(MessageResult<object>.Of(message, ex.Data, context.Response.StatusCode, 0)));

                break;
        }
    }
}
