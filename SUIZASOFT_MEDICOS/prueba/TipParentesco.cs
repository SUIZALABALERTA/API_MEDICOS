using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipParentesco
    {
        public int TpaId { get; set; }
        public string TpaNombre { get; set; }
        public string TpaNombreCorto { get; set; }
        public bool? TpaEstado { get; set; }
        public DateTime? TpaFechaCreacion { get; set; }
        public DateTime? TpaFechaModificacion { get; set; }
    }
}
