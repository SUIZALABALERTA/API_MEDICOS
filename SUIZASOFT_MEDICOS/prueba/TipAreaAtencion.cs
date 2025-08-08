using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipAreaAtencion
    {
        public int AatId { get; set; }
        public string AatNombre { get; set; }
        public string AatNombreCorto { get; set; }
        public int? AatVistaServicio { get; set; }
        public bool? AatEstado { get; set; }
        public DateTime? AatFechaCreacion { get; set; }
        public DateTime? AatFechaModificacion { get; set; }
    }
}
