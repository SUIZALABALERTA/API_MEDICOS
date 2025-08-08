using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstGrupoSeguro
    {
        public int GruId { get; set; }
        public string GruNombre { get; set; }
        public string GruRuc { get; set; }
        public bool? GruEstado { get; set; }
        public string GruObservacion { get; set; }
        public string GruUsuarioRegistro { get; set; }
        public DateTime? GruFechaRegistro { get; set; }
        public string GruUsuarioModificacion { get; set; }
        public DateTime? GruFechaModificacion { get; set; }
    }
}
