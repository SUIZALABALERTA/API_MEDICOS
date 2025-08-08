using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabPerfil
    {
        public MstLabPerfil()
        {
            DetPerfilResultados = new HashSet<DetPerfilResultado>();
            MstTarifarioPerfils = new HashSet<MstTarifarioPerfil>();
        }

        public int PerId { get; set; }
        public string PerDescripcion { get; set; }
        public string PerObsevacion { get; set; }
        public int? PerAreaNegocio { get; set; }
        public string PerUsuarioRegistro { get; set; }
        public DateTime? PerFechaRegistro { get; set; }
        public string PerUsuarioModificacion { get; set; }
        public DateTime? PerFechaModificacion { get; set; }
        public bool? PerEstado { get; set; }
        public string PerNumSerAnterior { get; set; }
        public string PerDescripcionEspanol { get; set; }
        public string PerFox { get; set; }
        public string PerCodigoAlfanumerico { get; set; }
        public int? PerUnidadNegocio { get; set; }
        public int? PerLineaNegocio { get; set; }
        public int? PerCentroCostoNegocio { get; set; }
        public string PerCondicionesPreanaliticas { get; set; }
        public string PerCondicionesPreanaliticasRef { get; set; }
        public int? PerTempOptimaEnvio { get; set; }
        public int? PerProcesamiento { get; set; }
        public int? PerEquipo { get; set; }
        public bool PerBiopsia { get; set; }
        public bool PerSuizaParnert { get; set; }
        public int? PerMetodo { get; set; }
        public int? PerTipoTubo { get; set; }
        public int? PerIdTiempoProceso { get; set; }
        public bool PerConfidencial { get; set; }
        public char? PerFlagTiempo { get; set; }

        public virtual MstServicioAreaNegocio PerAreaNegocioNavigation { get; set; }
        public virtual TipCentroCostoNegocio PerCentroCostoNegocioNavigation { get; set; }
        public virtual TipEquipoLaboratorio PerEquipoNavigation { get; set; }
        public virtual TipLineaNegocio PerLineaNegocioNavigation { get; set; }
        public virtual TipServicioMetodoLaboratorio PerMetodoNavigation { get; set; }
        public virtual TipServicioProceso PerProcesamientoNavigation { get; set; }
        public virtual TipServicioTemperatura PerTempOptimaEnvioNavigation { get; set; }
        public virtual TipTubo PerTipoTuboNavigation { get; set; }
        public virtual MstUnidadNegocio PerUnidadNegocioNavigation { get; set; }
        public virtual ICollection<DetPerfilResultado> DetPerfilResultados { get; set; }
        public virtual ICollection<MstTarifarioPerfil> MstTarifarioPerfils { get; set; }
    }
}
