namespace Domain.Entities;

public partial class TipPromotor
{
    public TipPromotor()
    {
        XPromotors = new HashSet<MstPromotor>();
    }

    public int TprId { get; set; }
    public string TprNombre { get; set; }

    public virtual ICollection<MstPromotor> XPromotors { get; set; }
}
