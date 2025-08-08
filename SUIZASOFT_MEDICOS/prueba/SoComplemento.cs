using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class SoComplemento
    {
        public SoComplemento()
        {
            SoCitaComplementos = new HashSet<SoCitaComplemento>();
        }

        public int ComId { get; set; }
        public string ComNombre { get; set; }
        public decimal? ComPrecio { get; set; }
        public bool? ComEstado { get; set; }

        public virtual ICollection<SoCitaComplemento> SoCitaComplementos { get; set; }
    }
}
