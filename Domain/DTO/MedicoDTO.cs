using Domain.Entities;

namespace Domain.DTO;
public class MedicoDTO
{
    public int Index { get; set; } = 0;

    public int Id { get; set; }


    public int? IdTipoDocumento { get; set; }
    public string TipoDocumento { get; set; }


    public string NumeroDocumento { get; set; }
    public string Nombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public string FechaNacimiento { get; set; }

    private int _edad;

    public string Edad
    {
        get
        {
            if (this.FechaNacimiento is null)
            {
                return string.Empty;
            }
            if (this._edad <= 0)
            {
                var culture = System.Globalization.CultureInfo.InvariantCulture;
                var fecha = DateTime.Parse(DateTime.ParseExact(this.FechaNacimiento, "dd/MM/yyyy", culture).ToString("yyyy-MM-dd", culture));
                if (fecha.Date.Year == DateTime.Now.Year)
                {
                    return "Edad menor a un 1 año";
                }
                var temp = DateTime.Now.Subtract(Convert.ToDateTime(fecha)).Ticks;
                this._edad = new DateTime(temp).Year - 1;
            }
            return this._edad.ToString();
        }
    }


    public int? IdSexo { get; set; }
    public string Sexo { get; set; }


    public string Direccion { get; set; }
    public string DireccionReferencia { get; set; }


    public int? IdUbigeo { get; set; }
    public string UbigeoDireccion { get; set; }


    public string Correo { get; set; }
    public string TelefonoMovil { get; set; }
    public string TelefonoCasa { get; set; }
    public string FechaInscripcion { get; set; }
    public string ConsultorioDireccion { get; set; }
    public string ConsultorioReferencia { get; set; }


    public int? IdUbigeoConsultorio { get; set; }
    public string UbigeoDireccionConsultorio { get; set; }


    public string ColegioCodigo { get; set; }


    public int? IdTipoColegio { get; set; }
    public string TipoColegio { get; set; }



    public int? IdTipo { get; set; }
    public string TipoMedico { get; set; }

    public int? IdPromotor { get; set; }
    public string Promotor { get; set; }
    public string MovilPromotor { get; set; }
    public string DireccionPromotor { get; set; }
    public string TelefonoCasaPromotor { get; set; }

    public bool? AccesoWeb { get; set; }
    public string UsuarioWeb { get; set; }
    public string PasswordWeb { get; set; }
    public string ImageRuta { get; set; }
    public bool? Estado { get; set; }
    public string Linkedin { get; set; }
    public string Twitter { get; set; }
    public string Doctoralia { get; set; }
    public string Rne { get; set; }
    public string Rna { get; set; }

    public List<EspecialodadesDTO> XMedicoAreaNegocios { get; set; }
    public List<RolesDTO> XMedicoRol { get; set; }

}

public class EspecialodadesDTO
{
    public int Id { get; set; } = 0;
    public string Nombre { get; set; }
}
public class RolesDTO
{
    public int Id { get; set; } = 0;
    public string Nombre { get; set; }
}
