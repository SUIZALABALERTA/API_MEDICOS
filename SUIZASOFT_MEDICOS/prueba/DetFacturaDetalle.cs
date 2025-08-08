using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetFacturaDetalle
    {
        public int FadId { get; set; }
        public int? FadIndex { get; set; }
        public string FadSucursal { get; set; }
        public int? FadIdCabecera { get; set; }
        public int? FadIdTipoDocVenta { get; set; }
        public string FadSerie { get; set; }
        public int? FadCorrelativo { get; set; }
        public string FadSerieCorrelativo { get; set; }
        public string FadObservacion { get; set; }
        public int? FadIdServicioPerfil { get; set; }
        public int? FadCantidad { get; set; }
        public string FadIdUnidadMedida { get; set; }
        public int? FadIdAfectoIgv { get; set; }
        public string FadCodigoAfectoIgv { get; set; }
        public decimal? FadValorUnitarioSol { get; set; }
        public decimal? FadValorUnitarioIgvSol { get; set; }
        public decimal? FadValorUnitarioTotalSol { get; set; }
        public decimal? FadValorUnitarioDol { get; set; }
        public decimal? FadValorUnitarioIgvDol { get; set; }
        public decimal? FadValorUnitarioTotalDol { get; set; }
        public decimal? FadCobertura { get; set; }
        public decimal? FadMontoACuenta { get; set; }
        public decimal? FadMontoDeducible { get; set; }
        public string FadUsuarioCreacion { get; set; }
        public DateTime? FadFechaCreacion { get; set; }
        public string FadUsuarioModificacion { get; set; }
        public DateTime? FadFechaModificacion { get; set; }
        public string FadTicket { get; set; }
        public bool? FadPerfil { get; set; }
        public string FadServicioPerfil { get; set; }

        public virtual MstFacturaCabecera FadIdCabeceraNavigation { get; set; }
    }
}
