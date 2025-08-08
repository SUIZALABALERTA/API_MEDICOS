namespace Domain.Entities;

public partial class MstPromotor
{
    public MstPromotor()
    {
        MstMedicos = new HashSet<MstMedico>();
    }

    public int ProId { get; set; }
    public int? ProIdTipoDocumento { get; set; }
    public string ProNumeroDocumento { get; set; }
    public string ProApellidoPaterno { get; set; }
    public string ProApellidoMaterno { get; set; }
    public string ProNombre { get; set; }
    public DateTime? ProFechaNacimiento { get; set; }
    public string ProDireccion { get; set; }
    public int? ProIdUbigeo { get; set; }
    public string ProTelefonoCasa { get; set; }
    public string ProTelefonoMovil { get; set; }
    public string ProEmail { get; set; }
    public string ProUsuarioWeb { get; set; }
    public string ProClaveWeb { get; set; }
    public int? ProIdTipoPromotor { get; set; }
    public bool? ProComision { get; set; }
    public string ProUsuarioCreacion { get; set; }
    public DateTime? ProFechaCreacion { get; set; }
    public string ProUsuarioModificacion { get; set; }
    public DateTime? ProFechaModificacion { get; set; }
    public string ProCodigoAnterior { get; set; }
    public bool? ProEstado { get; set; }
    public int? ProIdSupervisor { get; set; }
    public int? ProIdModalidad { get; set; }

    public virtual MstJefePromotor ProIdSupervisorNavigation { get; set; }
    
    public virtual MstModalidad ProIdModalidadNavigation { get; set; }
    public virtual MstTipoDocumento ProIdTipoDocumentoNavigation { get; set; }
    public virtual TipPromotor ProIdTipoPromotorNavigation { get; set; }
    public virtual MstUbigeo ProIdUbigeoNavigation { get; set; }
    public virtual ICollection<MstMedico> MstMedicos { get; set; }
}
