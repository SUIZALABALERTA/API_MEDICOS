using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstPaqueteCabecera
    {
        public MstPaqueteCabecera()
        {
            DetComModTarPaqs = new HashSet<DetComModTarPaq>();
            DetPaqueteDetalles = new HashSet<DetPaqueteDetalle>();
            MstTarifarioPaquetes = new HashSet<MstTarifarioPaquete>();
        }

        public int PaqId { get; set; }
        public string PaqNumpqc { get; set; }
        public string PacNumpano { get; set; }
        public string PaqDescripcion { get; set; }
        public DateTime? PaqFechainicio { get; set; }
        public string PaqObservacion { get; set; }
        public string PaqUsuarioModificacion { get; set; }
        public DateTime? PaqFechaModificacion { get; set; }
        public bool? PaqEstado { get; set; }
        public string PaqNumeroEspecialidad { get; set; }
        public decimal? PaqPrecioTotalSinIgv { get; set; }
        public decimal? PaqPrecioTotalConIgv { get; set; }
        public string PaqNumpaqfox { get; set; }
        public int? PaqTipoeval { get; set; }
        public string PaqNuminfp { get; set; }
        public string PaqUsuarioRegistro { get; set; }
        public DateTime? PaqFechaRegistro { get; set; }
        public DateTime? PaqFechafin { get; set; }
        public int? PaqMoneda { get; set; }
        public int? PaqIdModaidad { get; set; }
        public int? PaqTipoPaquete { get; set; }

        public virtual MstModalidad PaqIdModaidadNavigation { get; set; }
        public virtual MstMonedum PaqMonedaNavigation { get; set; }
        public virtual MstTipoEvaluacion PaqTipoevalNavigation { get; set; }
        public virtual ICollection<DetComModTarPaq> DetComModTarPaqs { get; set; }
        public virtual ICollection<DetPaqueteDetalle> DetPaqueteDetalles { get; set; }
        public virtual ICollection<MstTarifarioPaquete> MstTarifarioPaquetes { get; set; }
    }
}
