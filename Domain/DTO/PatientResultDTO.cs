namespace Domain.DTO;

public class PatientResultDTO
{
    public int Id { get; set; }

    public int IdTipoDocumento { get; set; }

    public string TipoDocumento { get; set; }

    public string NumeroDocumento { get; set; }

    public string Nombre { get; set; }

    public string ApellidoPaterno { get; set; }

    public string ApellidoMaterno { get; set; }

    public string ApellidoCasado { get; set; }

    public string FechaNacimiento { get; set; }

    public string Sexo { get; set; }

    public int IdSexo { get; set; }

    public string EstadoCivil { get; set; }

    public int IdEstadoCivil { get; set; }

    public string TelefonoMovil { get; set; }

    public string Email { get; set; }

    private int _edad;

    public string Edad
    {
        get
        {
            if (FechaNacimiento is null)
            {
                return string.Empty;
            }
            if (_edad <= 0)
            {
                var culture = System.Globalization.CultureInfo.InvariantCulture;
                var fecha = DateTime.Parse(DateTime.ParseExact(FechaNacimiento, "dd/MM/yyyy", culture).ToString("yyyy-MM-dd", culture));
                _edad = new DateTime(DateTime.Now.Subtract(Convert.ToDateTime(fecha)).Ticks).Year - 1;
            }
            return _edad.ToString();
        }
    }

    //AQUI HAY UN TEMA CON C#, PARECE QUE PARA OBTENER LA EDAD, EL FORMATO DEBE ESTAR EN AÑO,MES,DIA

    public bool? ResultadoWhatsapp { get; set; }
    public string Direccion1 { get; set; }
    public bool? Estado { get; set; }
    public bool? CorreoValidado { get; set; }
}
