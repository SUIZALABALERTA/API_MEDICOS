namespace Domain.Utils
{
    public static class Utils
    {
        public static DateTime ConvertDate(String date)
        {
            var culture = System.Globalization.CultureInfo.InvariantCulture;
            return DateTime.Parse(DateTime.ParseExact(date, "dd/MM/yyyy", culture).ToString("yyyy-MM-dd", culture));
        }

        public static DateTime CurrentDateTime()
        {
            return DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
        }

        public static IEnumerable<(T item, int index)> WithCustomIndex<T>(this IEnumerable<T> source) => source.Select((item, index) => (item, index + 1));

        public static string GeneratePassword(string numdoc)
        {
            List<int> numeros = new();

            var cadena = string.Empty;
            int sumatoria = 0;

            for (int i = 0; i < numdoc.Length; i++)
            {
                numeros.Add(int.Parse(numdoc.Substring(i, 1)));
                if (numdoc.Length / 2 > i)
                {
                    cadena += Math.Abs(numeros[i] - int.Parse(numdoc.Substring(numdoc.Length - i - 1, 1))).ToString();
                    sumatoria += int.Parse(cadena.Substring(i, 1));
                }
            }

            return cadena + sumatoria;
        }

        public static class TipoDocumento
        {
            public static int Dni = 1;
            public static int CarnetExtranjeria = 4;
        }

        public static class Genero
        {
            public static string M = "MASCULINO";
            public static string F = "FEMENINO";
        }

        public static class EstadoCivil
        {
            public static string C = "CASADO";
            public static string D = "DIVORCIADO";
            public static string S = "SOLTERO";
            public static string V = "VIUDO";
        }

    }
}
