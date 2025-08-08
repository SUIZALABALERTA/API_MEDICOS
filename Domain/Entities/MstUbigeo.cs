namespace Domain.Entities;

public partial class MstUbigeo
{
    public MstUbigeo()
    {
        XMedicoUbigeoConsultorio = new HashSet<MstMedico>();
        XMedicoUbigeo = new HashSet<MstMedico>();
        MstPromotors = new HashSet<MstPromotor>();

    }

    public int Id { get; set; }
    public string CodigoDepartamento { get; set; }
    public string NombreDepartamento { get; set; }
    public string CodigoProvincia { get; set; }
    public string NombreProvincia { get; set; }
    public string CodigoDistrito { get; set; }
    public string NombreDistrito { get; set; }
    public bool? Estado { get; set; }

    public virtual ICollection<MstMedico> XMedicoUbigeoConsultorio { get; set; }
    public virtual ICollection<MstMedico> XMedicoUbigeo { get; set; }
    public virtual ICollection<MstPromotor> MstPromotors { get; set; }
}


