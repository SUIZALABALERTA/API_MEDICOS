namespace Domain.Entities;

public partial class DetMedicoAreaNegocio
{
    public int IdMedico { get; set; }

    public int IdAreaNegocio { get; set; }

    public bool Estado { get; set; }

    public string UsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string UsuarioModificacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual MstMedico XMedico { get; set; }

    public virtual MstServicioAreaNegocio DmanIdAreaNegocioNavigation { get; set; }
}
