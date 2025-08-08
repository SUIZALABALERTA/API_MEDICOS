namespace SUIZASOFT_MEDICOS.Middleware;

public static class InstallHandlerMiddleware
{
    public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ErrorHandlerMiddleware>();
    }
}
