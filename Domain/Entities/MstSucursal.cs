namespace Domain.Entities;

public partial class MstSucursal
{
    public MstSucursal()
    {
        MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
    }

    public string SucId { get; set; }
    public string SucNombreLargo { get; set; }
    public string SucNombreCorto { get; set; }
    public string SucDireccion { get; set; }
    public string SucTelefono { get; set; }
    public bool? SucEnvioSap { get; set; }
    public string SucCodigoSucursal { get; set; }
    public bool? SucEstado { get; set; }
    public int? SucUsuarioRegistro { get; set; }
    public DateTime? SucFechaRegistro { get; set; }
    public int? SucUsuarioModificacion { get; set; }
    public DateTime? SucFechaModificacion { get; set; }
    public string SucUbigeo { get; set; }
    public string SucCodigoSap { get; set; }
   
    public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
}
