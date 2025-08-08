using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstServicio
    {
        public MstServicio()
        {
            DetNotaCreditoDetalles = new HashSet<DetNotaCreditoDetalle>();
            DetPaqueteDetalles = new HashSet<DetPaqueteDetalle>();
            DetPreticketDetalles = new HashSet<DetPreticketDetalle>();
            DetServicioResultados = new HashSet<DetServicioResultado>();
            DetServicioSedeFechas = new HashSet<DetServicioSedeFecha>();
            DetServicioSedes = new HashSet<DetServicioSede>();
            MstBitacoraAtencionAuditoria = new HashSet<MstBitacoraAtencionAuditorium>();
            MstCitaParticulars = new HashSet<MstCitaParticular>();
            MstLabServicioValoresRefs = new HashSet<MstLabServicioValoresRef>();
            MstTarifarioCategoria = new HashSet<MstTarifarioCategorium>();
            ScProgramacionFechaServicios = new HashSet<ScProgramacionFechaServicio>();
        }

        public int SerCodigo { get; set; }
        public string SerDescripcionEspanol { get; set; }
        public string SerFox { get; set; }
        public bool? SerLaboratorio { get; set; }
        public bool? SerComisionMed { get; set; }
        public bool? SerConfidencial { get; set; }
        public int? SerNivel { get; set; }
        public int? SerTipoServicio { get; set; }
        public int? SerPaternidad { get; set; }
        public bool? SerVerWeb { get; set; }
        public bool? SerSuizaParnert { get; set; }
        public string SerTiempoProceso { get; set; }
        public int? SerProyecto { get; set; }
        public int? SerProcesamiento { get; set; }
        public int? SerTempOptimaEnvio { get; set; }
        public int? SerMetodo { get; set; }
        public int? SerTipoTubo { get; set; }
        public int? SerEquipo { get; set; }
        public string SerCondicionesPreanaliticas { get; set; }
        public string SerCondicionesPreanaliticasRef { get; set; }
        public string SerObservaciones { get; set; }
        public string SerGrupoServicio { get; set; }
        public string SerIdCie { get; set; }
        public string SerIdDiagnostico { get; set; }
        public string SerUsuarioRegistro { get; set; }
        public DateTime? SerFechaRegistro { get; set; }
        public string SerUsuarioModif { get; set; }
        public DateTime? SerFechaModif { get; set; }
        public bool? SerEstado { get; set; }
        public double? SerCosto { get; set; }
        public double? SerMargen { get; set; }
        public double? SerMontoPrecioUnico { get; set; }
        public double? SerComisionLima { get; set; }
        public double? SerComisionProvincia { get; set; }
        public int? SerIdTiempoProceso { get; set; }
        public int? SerAreaNegocio { get; set; }
        public int? SerUnidadNegocio { get; set; }
        public int? SerLineaNegocio { get; set; }
        public string SerComentarioEspanol { get; set; }
        public string SerComentarioIngles { get; set; }
        public char? SerFlagTiempo { get; set; }
        public string SerDescripcionIngles { get; set; }
        public double? SerPrecioUnico { get; set; }
        public string SerCodigoSap { get; set; }
        public string SerErrorSap { get; set; }
        public string SerEstadoSap { get; set; }
        public string SerNumSerAnterior { get; set; }
        public int? SerCentroCostoNegocio { get; set; }
        public string SerCodigoAlfanumerico { get; set; }
        public bool? SerFlagPerfil { get; set; }
        public int? SerIdEspecialidad { get; set; }
        public string SerCodigoSegus { get; set; }
        public double? SerUnidadSegus { get; set; }
        public bool? SerBiopsia { get; set; }
        public bool? SerSuizaOnline { get; set; }
        public int? SerIdUnidadMedida { get; set; }
        public bool? SerParametroLab { get; set; }
        public string SerSubTituloLaboratorio { get; set; }

        public virtual MstServicioAreaNegocio SerAreaNegocioNavigation { get; set; }
        public virtual TipCentroCostoNegocio SerCentroCostoNegocioNavigation { get; set; }
        public virtual TipEquipoLaboratorio SerEquipoNavigation { get; set; }
        public virtual TipMedicoEspecialidad SerIdEspecialidadNavigation { get; set; }
        public virtual TipUnidadMedidum SerIdUnidadMedidaNavigation { get; set; }
        public virtual TipLineaNegocio SerLineaNegocioNavigation { get; set; }
        public virtual TipServicioMetodoLaboratorio SerMetodoNavigation { get; set; }
        public virtual TipServicioProceso SerProcesamientoNavigation { get; set; }
        public virtual MstProyecto SerProyectoNavigation { get; set; }
        public virtual TipServicioTemperatura SerTempOptimaEnvioNavigation { get; set; }
        public virtual MstTipoServicioLaboratorio SerTipoServicioNavigation { get; set; }
        public virtual TipTubo SerTipoTuboNavigation { get; set; }
        public virtual MstUnidadNegocio SerUnidadNegocioNavigation { get; set; }
        public virtual ICollection<DetNotaCreditoDetalle> DetNotaCreditoDetalles { get; set; }
        public virtual ICollection<DetPaqueteDetalle> DetPaqueteDetalles { get; set; }
        public virtual ICollection<DetPreticketDetalle> DetPreticketDetalles { get; set; }
        public virtual ICollection<DetServicioResultado> DetServicioResultados { get; set; }
        public virtual ICollection<DetServicioSedeFecha> DetServicioSedeFechas { get; set; }
        public virtual ICollection<DetServicioSede> DetServicioSedes { get; set; }
        public virtual ICollection<MstBitacoraAtencionAuditorium> MstBitacoraAtencionAuditoria { get; set; }
        public virtual ICollection<MstCitaParticular> MstCitaParticulars { get; set; }
        public virtual ICollection<MstLabServicioValoresRef> MstLabServicioValoresRefs { get; set; }
        public virtual ICollection<MstTarifarioCategorium> MstTarifarioCategoria { get; set; }
        public virtual ICollection<ScProgramacionFechaServicio> ScProgramacionFechaServicios { get; set; }
    }
}
