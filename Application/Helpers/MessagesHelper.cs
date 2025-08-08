namespace Application.Helpers;
public static class MessagesHelper
{
    public static string GreaterThan(string property, int value) => $"El valor de la propiedad '{ property }' debe ser mayor a { value }";

    public static string NotNull(string property) => $"El valor de la propiedad '{ property }' no es puede ser null";

    public static string NotEmpty() => "{PropertyName} no puede estar vacio";

    public static string MaximumLength(string property, int size) => $"La propiedad '{ property }' tiene como maximo { size } caracter(es)";

    public static string MinimumLength(string property, int size) => $"La propiedad '{ property }' tiene como minimo { size } caracter(es)";

    public static string Length(int size) => "La propiedad {PropertyName} debe tener " + $"'{ size }' caracter(es)";

    public static string IsInEnum(string property) => $"El valor de la propiedad '{ property }' no es válido";
}
