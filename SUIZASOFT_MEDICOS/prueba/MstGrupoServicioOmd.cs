using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstGrupoServicioOmd
    {
        public int GsoId { get; set; }
        public string GsoCodigoFox { get; set; }
        public int? GsoGruId { get; set; }
        public int? GsoIndex { get; set; }
        public int? GsoVistaServicio { get; set; }
        public bool? GsoEstado { get; set; }
        public DateTime? GsoFechaCreacion { get; set; }
        public DateTime? GsoFechaModificacion { get; set; }
    }
}
