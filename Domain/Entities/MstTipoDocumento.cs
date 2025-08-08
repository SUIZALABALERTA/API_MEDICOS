namespace Domain.Entities;

public partial class MstTipoDocumento
{
    public MstTipoDocumento()
    {
        XMedicos = new HashSet<MstMedico>();
        MstPromotors = new HashSet<MstPromotor>();

    }

    public int Id { get; set; }
    public string NombreDocumento { get; set; }
    public char Estado { get; set; }
    public string Usumod { get; set; }
    public string NombreCorto { get; set; }
    public short? FeCodDoc { get; set; }

    public virtual ICollection<MstMedico> XMedicos { get; set; }
    public virtual ICollection<MstPromotor> MstPromotors { get; set; }

}
