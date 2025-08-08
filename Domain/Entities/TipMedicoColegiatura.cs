namespace Domain.Entities;

public partial class TipMedicoColegiatura
{
    public TipMedicoColegiatura()
    {
        MstMedicos = new HashSet<MstMedico>();
    }

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }

    public virtual ICollection<MstMedico> MstMedicos { get; set; }
}