using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipPagoCuentum
    {
        public TipPagoCuentum()
        {
            DetFacturaMedioPagos = new HashSet<DetFacturaMedioPago>();
        }

        public int PcuId { get; set; }
        public string PcuNombre { get; set; }
        public string PcuNombreCorto { get; set; }
        public string PcuDescripcion { get; set; }
        public bool? PcuEstado { get; set; }

        public virtual ICollection<DetFacturaMedioPago> DetFacturaMedioPagos { get; set; }
    }
}
