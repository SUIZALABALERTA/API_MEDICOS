namespace Domain.Entities;
public partial class MstSistema
{
    public int SisId { get; set; }
    public string SisNombre { get; set; }
    public string SisNombreCorto { get; set; }
    public string SisDescripcion { get; set; }
    public int SisTsiId { get; set; }
    public string SisVersion { get; set; }
    public bool? SisActivo { get; set; }
    public string SisUrl { get; set; }
    public string SisUsuario { get; set; }
    public string SisContrasenia { get; set; }
    public int SisUsuIdCreacion { get; set; }
    public DateTime SisFechaCreacion { get; set; }
    public int SisUsuIdModificacion { get; set; }
    public DateTime SisFechaModificacion { get; set; }
}
