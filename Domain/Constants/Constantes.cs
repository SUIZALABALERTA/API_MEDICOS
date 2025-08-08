namespace Domain.Constants

{
    public class Constantes
    {
        public static class CredencialesReniec
        {
            public const string usuarioReniec = "47498836";
            public const string rucSuiza = "20330025213";
            public const string claveReniec = "47498836";
        }
        public static class CodigoReniec
        {
            public const string responseSuccess = "0000";
            public const string dnimenordeEdad = "0001";
            public const string dniCancelado = "0002";
            public const string dniRestringido = "0003";
            public const string dnisinInformacion = "0999";
            public const string datospeticionInvalido = "1000";
            public const string usuarionoregistradoenConvenio = "1001";
            public const string limiteconsultasporDia = "1002";
            public const string restriccionrandodediaConsulta = "1003";
            public const string RestriccionrangohorasConsulta = "1004";
            public const string errorDesconocido = "1999";
            public const string exception1 = "Error al obtener datos de reniec, Ingrese los datos manualmente.";
        }
        
        public static class ReniecError
        {
            public const string response = "Error al obtener datos de reniec, Ingrese los datos manualmente. Codigo: ";
        }
    }
}
