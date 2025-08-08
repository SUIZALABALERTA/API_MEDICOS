using Microsoft.AspNetCore.Localization;
using System.Globalization;

namespace SUIZASOFT_MEDICOS.Extensions;

public static class GeographyExtension
{
    public static IApplicationBuilder UseLocalGeography(this IApplicationBuilder app)
    {
        var supportedCultures = new[] { new CultureInfo("es-PE") };
        app.UseRequestLocalization(new RequestLocalizationOptions
        {
            DefaultRequestCulture = new RequestCulture("es-PE"),
            SupportedCultures = supportedCultures,
            SupportedUICultures = supportedCultures
        });

        return app;
    }

}