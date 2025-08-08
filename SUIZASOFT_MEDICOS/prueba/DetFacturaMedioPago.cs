using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetFacturaMedioPago
    {
        public int FmpId { get; set; }
        public int? FmpIdFactura { get; set; }
        public int? FmpIndexFormaPago { get; set; }
        public int? FmpIdTipoPago { get; set; }
        public string FmpReferenciaOperacion { get; set; }
        public decimal? FmpMonto { get; set; }
        public int? FmpIdMoneda { get; set; }
        public string FmpLote { get; set; }
        public int? FmpIdNotaCredito { get; set; }
        public bool? FmpEstado { get; set; }
        public string FmpUsuarioCreacion { get; set; }
        public DateTime? FmpFechaCreacion { get; set; }
        public string FmpUsuarioModificacion { get; set; }
        public DateTime? FmpFechaModificacion { get; set; }
        public int? FmpIdPagoCuenta { get; set; }
        public decimal? FmpVueltoPago { get; set; }
        public decimal? FmpRedondeoCentimos { get; set; }
        public int? FmpIdTipoTarjeta { get; set; }
        public bool? FmpEnvioSap { get; set; }
        public bool? FmpEnvioSapRedondeo { get; set; }

        public virtual MstFacturaCabecera FmpIdFacturaNavigation { get; set; }
        public virtual MstMonedum FmpIdMonedaNavigation { get; set; }
        public virtual MstNotaCreditoCabecera FmpIdNotaCreditoNavigation { get; set; }
        public virtual TipPagoCuentum FmpIdPagoCuentaNavigation { get; set; }
        public virtual MstTipoPago FmpIdTipoPagoNavigation { get; set; }
        public virtual TipPagoTarjetum FmpIdTipoTarjetaNavigation { get; set; }
    }
}
