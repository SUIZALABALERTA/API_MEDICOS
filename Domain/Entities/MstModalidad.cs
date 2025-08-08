namespace Domain.Entities;

public partial class MstModalidad
{
    public MstModalidad()
    {
        MstPromotors = new HashSet<MstPromotor>();
        MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
    }

    public int ModId { get; set; }
    public string ModDescripcion { get; set; }
    public bool? ModEstado { get; set; }
    public bool? ModComision { get; set; }
    public bool? ModComisionPreventiva { get; set; }

    public virtual ICollection<MstPromotor> MstPromotors { get; set; }
    public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }


}
