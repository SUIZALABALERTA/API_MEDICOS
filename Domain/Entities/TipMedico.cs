namespace Domain.Entities;

public partial class TipMedico
{
    public TipMedico()
    {
        MstMedicos = new HashSet<MstMedico>();
    }

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripccion { get; set; }

    public virtual ICollection<MstMedico> MstMedicos { get; set; }
}
