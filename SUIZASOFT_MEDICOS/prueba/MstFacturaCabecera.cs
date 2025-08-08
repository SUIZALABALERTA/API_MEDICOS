using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstFacturaCabecera
    {
        public MstFacturaCabecera()
        {
            DetFacturaDetalles = new HashSet<DetFacturaDetalle>();
            DetFacturaMedioPagos = new HashSet<DetFacturaMedioPago>();
            DetFacturaTickets = new HashSet<DetFacturaTicket>();
            MstNotaCreditoCabeceras = new HashSet<MstNotaCreditoCabecera>();
        }

        public int FacId { get; set; }
        public string FacSucursal { get; set; }
        public int? FacIdTipoDocVenta { get; set; }
        public string FacSerie { get; set; }
        public int? FacCorrelativo { get; set; }
        public string FacSerieCorrelativo { get; set; }
        public DateTime? FacFechaCreacion { get; set; }
        public string FacUsuarioCreacion { get; set; }
        public int? FacIdMoneda { get; set; }
        public string FacRazonSocial { get; set; }
        public int? FacIdDocumento { get; set; }
        public string FacNumeroDocumento { get; set; }
        public string FacDomicilioFiscal { get; set; }
        public int? FacIdEstado { get; set; }
        public decimal? FacValorSubtotalSol { get; set; }
        public decimal? FacValorIgvSol { get; set; }
        public decimal? FacValorTotalSol { get; set; }
        public decimal? FacValorSubtotalDol { get; set; }
        public decimal? FacValorIgvDol { get; set; }
        public decimal? FacValorTotalDol { get; set; }
        public string FacTotalLetras { get; set; }
        public decimal? FacTipoCambio { get; set; }
        public string FacObservacion { get; set; }
        public string FacPeriodo { get; set; }
        public string FacAnio { get; set; }
        public string FacUsuarioModificacion { get; set; }
        public DateTime? FacFechaModificacion { get; set; }
        public string FacNombrePaciente { get; set; }
        public string FacCorreo { get; set; }
        public string FacUsuarioWeb { get; set; }
        public string FacClaveWeb { get; set; }
        public int? FacIdModulo { get; set; }
        public int? FacIdCompania { get; set; }
        public int? FacIdTipoOperacionNcc { get; set; }
        public int? FacFeFlagEnvio { get; set; }
        public DateTime? FacFeFechaEnvio { get; set; }
        public int? FacSapFlagEnvio { get; set; }
        public DateTime? FacSapFechaEnvio { get; set; }
        public string FacTipoFact { get; set; }
        public int? FacIdModalidad { get; set; }
        public int? FacIdPeriodoCredDias { get; set; }
        public int? FacIdFormaPago { get; set; }
        public DateTime? FacFechaVencimiento { get; set; }
        public string FacSapError { get; set; }
        public DateTime? FacFechaCancelacion { get; set; }
        public bool? FacSapPagoEnvio { get; set; }
        public DateTime? FacFechaAnulacion { get; set; }
        public bool? FacSapFlagAnulacion { get; set; }
        public string FacMotivoAnulacion { get; set; }
        public string FacUsuarioAnulacion { get; set; }
        public int? FacSapIdError { get; set; }
        public int? FacFeIdError { get; set; }
        public bool? FacFlagEnvioCorreoCliente { get; set; }

        public virtual MstCompanium FacIdCompaniaNavigation { get; set; }
        public virtual MstTipoDocumento FacIdDocumentoNavigation { get; set; }
        public virtual EstComprobante FacIdEstadoNavigation { get; set; }
        public virtual MstFormaPago FacIdFormaPagoNavigation { get; set; }
        public virtual MstModalidad FacIdModalidadNavigation { get; set; }
        public virtual TipModuloFacturacion FacIdModuloNavigation { get; set; }
        public virtual MstMonedum FacIdMonedaNavigation { get; set; }
        public virtual MstPeriodoCredito FacIdPeriodoCredDiasNavigation { get; set; }
        public virtual MstTipoDocumentoVentum FacIdTipoDocVentaNavigation { get; set; }
        public virtual TipNotaCreditoOperacion FacIdTipoOperacionNccNavigation { get; set; }
        public virtual MstSucursal FacSucursalNavigation { get; set; }
        public virtual ICollection<DetFacturaDetalle> DetFacturaDetalles { get; set; }
        public virtual ICollection<DetFacturaMedioPago> DetFacturaMedioPagos { get; set; }
        public virtual ICollection<DetFacturaTicket> DetFacturaTickets { get; set; }
        public virtual ICollection<MstNotaCreditoCabecera> MstNotaCreditoCabeceras { get; set; }
    }
}
