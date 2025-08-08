using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetNotaCreditoDetalle
    {
        public int NcdId { get; set; }
        public int? NcdIndex { get; set; }
        public string NcdSucursal { get; set; }
        public int? NcdIdCabecera { get; set; }
        public int? NcdIdTipoDocVenta { get; set; }
        public string NcdSerie { get; set; }
        public int? NcdCorrelativo { get; set; }
        public int? NcdIdServicio { get; set; }
        public decimal? NcdValorUnitarioSol { get; set; }
        public decimal? NcdValorUnitarioIgvSol { get; set; }
        public decimal? NcdValorUnitarioTotalSol { get; set; }
        public decimal? NcdValorUnitarioDol { get; set; }
        public decimal? NcdValorUnitarioIgvDol { get; set; }
        public decimal? NcdValorUnitarioTotalDol { get; set; }
        public string NcdUsuarioCreacion { get; set; }
        public DateTime? NcdFechaCreacion { get; set; }
        public string NcdUsuarioModificacion { get; set; }
        public DateTime? NcdFechaModificacion { get; set; }
        public bool? NcdDescuentoManual { get; set; }
        public string NcdTicket { get; set; }

        public virtual MstNotaCreditoCabecera NcdIdCabeceraNavigation { get; set; }
        public virtual MstServicio NcdIdServicioNavigation { get; set; }
        public virtual MstTipoDocumentoVentum NcdIdTipoDocVentaNavigation { get; set; }
        public virtual MstSucursal NcdSucursalNavigation { get; set; }
    }
}
