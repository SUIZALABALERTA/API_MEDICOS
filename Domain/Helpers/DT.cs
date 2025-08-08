using System.Globalization;

namespace Domain.Helpers;

public static class DT
{
    private static DateTime PeruvianDateTime() => DateTime.UtcNow.AddHours(-5);

    private static CultureInfo culture = CultureInfo.InvariantCulture;


    //PARA GUARDAR EN LA BD CON UNA FECHA Y HORA  EN ESPECIFICO
    public static DateTime ConvertDateTime(string date) //01/01/2022 15:00:00
    {
        return Convert.ToDateTime(DateTime.ParseExact(date, "dd/MM/yyyy HH:mm:ss", culture).ToString("yyyy/MM/dd HH:mm:ss", culture), culture);
    }

    //PARA GUARDAR EN LA BD CON UNA FECHA EN ESPECIFICO
    public static DateTime ConvertDate(string date)
    {
        return Convert.ToDateTime(DateTime.ParseExact(date, "dd/MM/yyyy", culture).ToString("yyyy/MM/dd", culture), culture);
    }


    //PARA CONVERTIR DE STRING A DATETIME EN LOS PAYLOADS
    public static DateTime ToDateTime(string date) => DateTime.ParseExact(date, "dd/MM/yyyy", null, DateTimeStyles.None);


    //PARA GUARDADOS RECURRENTES DE LA FECHA ACTUAL EN LA BD
    public static DateTime CurrentDateTime() => DateTime.Parse(PeruvianDateTime().ToString("yyyy/MM/dd HH:mm:ss"));


    //PARA MOSTRAR EN LA VISTA
    public static string ToPeruvianDate(this DateTime date) => date.ToString("dd/MM/yyyy HH:mm:ss");

    public static string ToPeruvianDateWithoutTime(this DateTime date) => date.ToString("dd/MM/yyyy");
}