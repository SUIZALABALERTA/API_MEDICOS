using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetOrdenTrazabilidad
    {
        public int DotOrdenId { get; set; }
        public string DotOrden { get; set; }
        public int? DotMuestra { get; set; }
        public int? DotEstado { get; set; }
        public string DotUsuarioCreacion { get; set; }
        public DateTime? DotFechaCreacion { get; set; }
    }
}
