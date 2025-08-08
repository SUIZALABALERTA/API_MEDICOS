using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipPrioridadAtencion
    {
        public int PatId { get; set; }
        public string PatNombre { get; set; }
        public bool? PatEstado { get; set; }
        public DateTime? PatFechaCreacion { get; set; }
        public DateTime? PatFechaModificacion { get; set; }
    }
}
