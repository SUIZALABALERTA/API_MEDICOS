using Domain.Models;

namespace Domain.Entities;

public partial class MstMedico : AuditEntity
{
    public MstMedico()
    {
        XMedicoRol = new HashSet<DetMedicoRolCentroMedico>();
        XMedicoAreaNegocios = new HashSet<DetMedicoAreaNegocio>();
        MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
    }

    public int? IdTipoDocumento { get; set; }
    public string NumeroDocumento { get; set; }
    public string Nombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public int? IdSexo { get; set; }
    public string Direccion { get; set; }
    public string DireccionReferencia { get; set; }
    public int? IdUbigeo { get; set; }
    public string Correo { get; set; }
    public string TelefonoMovil { get; set; }
    public string TelefonoCasa { get; set; }
    public DateTime? FechaInscripcion { get; set; }
    public string ConsultorioDireccion { get; set; }
    public string ConsultorioReferencia { get; set; }
    public int? IdUbigeoConsultorio { get; set; }
    public string ColegioCodigo { get; set; }
    public int? IdColegioTipo { get; set; }
    public int? IdTipo { get; set; }
    public int? IdPromotor { get; set; }
    public bool? AccesoWeb { get; set; }
    public string UsuarioWeb { get; set; }
    public string PasswordWeb { get; set; }
    public string ImageRuta { get; set; }
    public string Linkedin { get; set; }
    public string Twitter { get; set; }
    public string Doctoralia { get; set; }

    public string NombreCompleto { get; set; }
    public string Rne { get; set; }
    public string Rna { get; set; }

    public virtual TipMedicoColegiatura XMedicoColegiatura { get; set; }
    public virtual MstPromotor XPromotor { get; set; }
    public virtual MstSexo XSexo { get; set; }
    public virtual MstTipoDocumento XTipoDocumento { get; set; }
    public virtual TipMedico XMedicoTipo { get; set; }
    public virtual MstUbigeo XUbigeo { get; set; }
    public virtual MstUbigeo XUbigeoConsultorio { get; set; }

    public virtual ICollection<DetMedicoRolCentroMedico> XMedicoRol { get; set; }
    public virtual ICollection<DetMedicoAreaNegocio> XMedicoAreaNegocios { get; set; }
    public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }

}
