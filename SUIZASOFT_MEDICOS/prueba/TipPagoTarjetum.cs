using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipPagoTarjetum
    {
        public TipPagoTarjetum()
        {
            DetFacturaMedioPagos = new HashSet<DetFacturaMedioPago>();
        }

        public int PtaId { get; set; }
        public string PtaNombre { get; set; }
        public string PtaNombreCorto { get; set; }
        public string PtaDescripcion { get; set; }
        public bool? PtaEstado { get; set; }

        public virtual ICollection<DetFacturaMedioPago> DetFacturaMedioPagos { get; set; }
    }
}
