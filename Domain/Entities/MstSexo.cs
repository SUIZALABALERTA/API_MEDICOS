
namespace Domain.Entities;
public partial class MstSexo
{
    public MstSexo()
    {
        XMedicos = new HashSet<MstMedico>();
    }

    public int Id { get; set; }
    public string Descripcion { get; set; }

    public virtual ICollection<MstMedico> XMedicos { get; set; }
}
