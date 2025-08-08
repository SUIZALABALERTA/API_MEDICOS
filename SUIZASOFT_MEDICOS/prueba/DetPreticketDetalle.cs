using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetPreticketDetalle
    {
        public int PrdIdNumeroCab { get; set; }
        public string PrdPeriodo { get; set; }
        public string PrdAnio { get; set; }
        public string PrdIdSucursal { get; set; }
        public int PrdIdServicio { get; set; }
        public decimal? PrdPrecioSol { get; set; }
        public decimal? PrdPrecioDolar { get; set; }
        public string PrdUsuarioRegistro { get; set; }
        public DateTime? PrdFechaRegistro { get; set; }
        public string PrdUsuarioModificacion { get; set; }
        public DateTime? PrdFechaModificacion { get; set; }
        public decimal? PrdSubTotal { get; set; }
        public bool? PrdPaqueteFlag { get; set; }
        public int? PrdIdPaquete { get; set; }
        public bool? PrdAsignacionMedico { get; set; }
        public decimal? PrdValorPrecioCantidad { get; set; }
        public decimal? PrdValorPrecioUnitario { get; set; }
        public decimal? PrdValorDescuento { get; set; }
        public decimal? PrdValorUnitarioSinIgv { get; set; }
        public bool? PrdEnvioEnterpriseFlag { get; set; }
        public int? PrdCantidadServicio { get; set; }
        public decimal? PrdValorUnitarioConIgv { get; set; }

        public virtual MstServicio PrdIdServicioNavigation { get; set; }
    }
}
