using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipGrupoOmd
    {
        public int GruId { get; set; }
        public string GruNombre { get; set; }
        public int? GruIndex { get; set; }
        public bool? GruEstado { get; set; }
        public DateTime? GsoFechaCreacion { get; set; }
        public DateTime? GsoFechaModificacion { get; set; }
    }
}
