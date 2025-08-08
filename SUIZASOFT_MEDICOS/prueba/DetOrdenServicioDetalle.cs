using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetOrdenServicioDetalle
    {
        public DetOrdenServicioDetalle()
        {
            MstBitacoraAtencionAuditoria = new HashSet<MstBitacoraAtencionAuditorium>();
        }

        public int OrdIdNumeroCab { get; set; }
        public string OrdPeriodo { get; set; }
        public string OrdAnio { get; set; }
        public string OrdIdSucursal { get; set; }
        public int OrdItem { get; set; }
        public int OrdIdServicioPerfil { get; set; }
        public decimal? OrdPrecioSol { get; set; }
        public decimal? OrdPrecioDolar { get; set; }
        public string OrdUsuarioRegistro { get; set; }
        public DateTime? OrdFechaRegistro { get; set; }
        public string OrdUsuarioModificacion { get; set; }
        public DateTime? OrdFechaModificacion { get; set; }
        public decimal? OrdSubTotal { get; set; }
        public bool? OrdPaqueteFlag { get; set; }
        public int? OrdIdPaquete { get; set; }
        public bool? OrdAsignacionMedico { get; set; }
        public DateTime? OrdLabFechaEnvio { get; set; }
        public bool? OrdLabEnvioFlag { get; set; }
        public bool? OrdLabValFlag { get; set; }
        public bool? OrdLabMueFlag { get; set; }
        public bool? OrdLabImpresionFlag { get; set; }
        public decimal? OrdValorPrecioCantidad { get; set; }
        public decimal? OrdValorPrecioUnitario { get; set; }
        public decimal? OrdValorDescuento { get; set; }
        public decimal? OrdValorUnitarioSinIgv { get; set; }
        public bool? OrdEnvioEnterpriseFlag { get; set; }
        public int? OrdCantidadServicio { get; set; }
        public decimal? OrdValorUnitarioConIgv { get; set; }
        public bool? OrdLabFlag { get; set; }
        public bool? OrdLabReprocesoFlag { get; set; }
        public int? OrdIdEstadoAtencion { get; set; }
        public bool? OrdLabEnvioFlagInfinity { get; set; }
        public bool? OrdPerfil { get; set; }
        public bool? OrdBiopsia { get; set; }
        public bool? OrdFlagSolicitudModificacionPendiente { get; set; }
        public bool? OrdLabEnvioFlagIntelicheck { get; set; }
        public bool? OrdFlagRegistroLab { get; set; }

        public virtual ICollection<MstBitacoraAtencionAuditorium> MstBitacoraAtencionAuditoria { get; set; }
    }
}
