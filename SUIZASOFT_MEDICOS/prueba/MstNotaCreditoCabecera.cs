using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstNotaCreditoCabecera
    {
        public MstNotaCreditoCabecera()
        {
            DetFacturaMedioPagos = new HashSet<DetFacturaMedioPago>();
            DetNotaCreditoDetalles = new HashSet<DetNotaCreditoDetalle>();
        }

        public int NccId { get; set; }
        public string NccSucursalNc { get; set; }
        public int? NccIdTipoDocVentaNc { get; set; }
        public string NccSerieNc { get; set; }
        public int? NccCorrelativoNc { get; set; }
        public string NccPeriodoNc { get; set; }
        public string NccAnioNc { get; set; }
        public DateTime? NccFechaCreacion { get; set; }
        public string NccUsuarioCreacion { get; set; }
        public int? NccIdMoneda { get; set; }
        public string NccRazonSocial { get; set; }
        public int? NccIdTipoDocumentoFac { get; set; }
        public string NccNumeroDocumentoFac { get; set; }
        public int? NccIdEstado { get; set; }
        public int? NccIdTipoOperacion { get; set; }
        public bool? NccEstadoAnulacionNc { get; set; }
        public string NccMotivoAnulacionNc { get; set; }
        public DateTime? NccFechaAnulacion { get; set; }
        public string NccUsuarioAnulacion { get; set; }
        public decimal? NccSubtotalSol { get; set; }
        public decimal? NccIgvSol { get; set; }
        public decimal? NccTotalSol { get; set; }
        public decimal? NccSubtotalDol { get; set; }
        public decimal? NccIgvDol { get; set; }
        public decimal? NccTotalDol { get; set; }
        public int? NccIdTipDocVentaFac { get; set; }
        public string NccSucursalFac { get; set; }
        public string NccSerieFac { get; set; }
        public int? NccCorrelativoFac { get; set; }
        public DateTime? NccFechaFacturacionFac { get; set; }
        public string NccObservacionNc { get; set; }
        public string NccTotalLetras { get; set; }
        public int? NccIdModalidadFac { get; set; }
        public int? NccTasaIgv { get; set; }
        public int? NccFeTipoNota { get; set; }
        public bool? NccFeFlagEnvio { get; set; }
        public DateTime? NccFeFechaEnvio { get; set; }
        public decimal? NccTipoCambio { get; set; }
        public decimal? NccMontoFac { get; set; }
        public bool? NccSapEnvio { get; set; }
        public DateTime? NccSapEnvioFecha { get; set; }
        public int? NccIdComprobante { get; set; }
        public bool? NccFlagUsado { get; set; }
        public decimal? NccSaldoSobrante { get; set; }

        public virtual MstFacturaCabecera NccIdComprobanteNavigation { get; set; }
        public virtual EstNotaCredito NccIdEstadoNavigation { get; set; }
        public virtual TipModuloFacturacion NccIdModalidadFacNavigation { get; set; }
        public virtual MstMonedum NccIdMonedaNavigation { get; set; }
        public virtual MstTipoDocumentoVentum NccIdTipDocVentaFacNavigation { get; set; }
        public virtual MstTipoDocumentoVentum NccIdTipoDocVentaNcNavigation { get; set; }
        public virtual MstTipoDocumento NccIdTipoDocumentoFacNavigation { get; set; }
        public virtual TipNotaCreditoOperacion NccIdTipoOperacionNavigation { get; set; }
        public virtual ICollection<DetFacturaMedioPago> DetFacturaMedioPagos { get; set; }
        public virtual ICollection<DetNotaCreditoDetalle> DetNotaCreditoDetalles { get; set; }
    }
}
