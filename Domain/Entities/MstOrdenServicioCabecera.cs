namespace Domain.Entities;

public partial class MstOrdenServicioCabecera
{
    public MstOrdenServicioCabecera()
    {
        //DetOrdenServicioOrdenMedicas = new HashSet<DetOrdenServicioOrdenMedica>();
        //LabOrdenMuestras = new HashSet<LabOrdenMuestra>();
        //MstLabMuestraRechazadaCabeceras = new HashSet<MstLabMuestraRechazadaCabecera>();
        //MstLabOrdenEscaneos = new HashSet<MstLabOrdenEscaneo>();
        //MstLabOrdenImpresions = new HashSet<MstLabOrdenImpresion>();
    }

    public int OrsId { get; set; }
    public string OrsPeriodo { get; set; }
    public string OrsAnio { get; set; }
    public string OrsIdSucursal { get; set; }
    public int? OrsIdEstado { get; set; }
    public decimal? OrsTipoCambio { get; set; }
    public int? OrsIdCompania { get; set; }
    public int? OrsIdPaciente { get; set; }
    public int? OrsIdTarifa { get; set; }
    public int? OrsIdEmpresaCompania { get; set; }
    public string OrsMotivoAnulacion { get; set; }
    public DateOnly? OrsFechaAnulacion { get; set; }
    public int? OrsIdMedico { get; set; }
    public decimal? OrsTotalGravado { get; set; }
    public decimal? OrsTotalDebe { get; set; }
    public decimal? OrsTotalHaber { get; set; }
    public decimal? OrsTotalAcuenta { get; set; }
    public string OrsObservacion { get; set; }
    public decimal? OrsTotalSolesLetra { get; set; }
    public bool? OrsFlagPaquete { get; set; }
    public string OrsOrdenNumero { get; set; }
    public int? OrsIdPaquete { get; set; }
    public decimal? OrsDescuentoTotal { get; set; }
    public decimal? OrsSubTotal { get; set; }
    public string OrsYearorden { get; set; }
    public string OrsNumeroOrden { get; set; }
    public string OrsNumeroFactura { get; set; }
    public string OrsSerieFactura { get; set; }
    public char? OrsEstadoFactura { get; set; }
    public string OrsIpIngreso { get; set; }
    public string OrsIpModificacion { get; set; }
    public string OrsIpAnulacion { get; set; }
    public bool? OrsEnvioMedicoReferencia { get; set; }
    public bool? OrsEnvioAccesoPaciente { get; set; }
    public DateOnly? OrsFechaEnvioPaciente { get; set; }
    public bool? OrsConfirmacionEnvio { get; set; }
    public DateOnly? OrsFechaConfirmacionEnvio { get; set; }
    public string OrsUsuarioRegistro { get; set; }
    public DateTime? OrsFechaRegistro { get; set; }
    public string OrsUsuarioModificacion { get; set; }
    public DateTime? OrsFechaModificacion { get; set; }
    public string OrsRutaOrdenMedica { get; set; }
    public int? OrsIdModalidad { get; set; }
    public decimal? OrsFranquicia { get; set; }
    public decimal? OrsSaldo { get; set; }
    public decimal? OrsTotalVenta { get; set; }
    public decimal? OrsImporteTotal { get; set; }
    public decimal? OrsTotalIgv { get; set; }
    public decimal? OrsTotal { get; set; }
    public int? OrsIdMoneda { get; set; }
    public int? OrsIdCompaniaAsociada { get; set; }
    public string OrsNombresPaciente { get; set; }
    public string OrsHistorialClinico { get; set; }
    public int? OrsIdEstadoAtencion { get; set; }
    public bool? OrsFlagAcompaniante { get; set; }
    public int? OrsIdParentescoAcompaniante { get; set; }
    public int? OrsIdParentescoTitularSeguro { get; set; }
    public string OrsNombreCompletoAcompaniante { get; set; }
    public int? OrsIdTipoDocumentoAcompaniante { get; set; }
    public bool? OrsFlagSctr { get; set; }
    public int? OrsIdTipoSeguro { get; set; }
    public string OrsNumeroDocumentoAcompaniante { get; set; }
    public DateTime? OrsFechaAtencion { get; set; }
    public bool? OrsFlagTriaje { get; set; }
    public int? OrsIdEstadoAuditoria { get; set; }
    public string OrsUrlFotoPaciente { get; set; }
    public int? OrsIdServicioAreaComp { get; set; }
    public int? OrsIdProcedencia { get; set; }
    public string OrsCodigoHistoriaIncor { get; set; }
    public string OrsNumeroGuiaIncor { get; set; }
    public int? OrsIdTipPrioridad { get; set; }

    //public virtual MstCompanium OrsIdCompaniaNavigation { get; set; }
    //public virtual EstTicket OrsIdEstadoNavigation { get; set; }
    public virtual MstMedico OrsIdMedicoNavigation { get; set; }
    public virtual MstModalidad OrsIdModalidadNavigation { get; set; }
    //public virtual MstMonedum OrsIdMonedaNavigation { get; set; }
    public virtual MstPaciente OrsIdPacienteNavigation { get; set; }
    //public virtual TipProcedencium OrsIdProcedenciaNavigation { get; set; }
    //public virtual DetCompaniasAreasComp OrsIdServicioAreaCompNavigation { get; set; }
    public virtual MstSucursal OrsIdSucursalNavigation { get; set; }
    //public virtual TipPrioridad OrsIdTipPrioridadNavigation { get; set; }
    //public virtual MstTipoDocumento OrsIdTipoDocumentoAcompanianteNavigation { get; set; }
    //public virtual TipSeguro OrsIdTipoSeguroNavigation { get; set; }
    //public virtual ICollection<DetOrdenServicioOrdenMedica> DetOrdenServicioOrdenMedicas { get; set; }
    //public virtual ICollection<LabOrdenMuestra> LabOrdenMuestras { get; set; }
    //public virtual ICollection<MstLabMuestraRechazadaCabecera> MstLabMuestraRechazadaCabeceras { get; set; }
    //public virtual ICollection<MstLabOrdenEscaneo> MstLabOrdenEscaneos { get; set; }
    //public virtual ICollection<MstLabOrdenImpresion> MstLabOrdenImpresions { get; set; }
}
