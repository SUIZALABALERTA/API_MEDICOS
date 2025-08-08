using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstUsuariosGrupo
    {
        public int UsgIdGrupo { get; set; }
        public int? UsgIdUsuario { get; set; }
        public bool? UsgEstado { get; set; }
        public string UsgUsuarioRegistro { get; set; }
        public DateTime? UsgFechaRegistro { get; set; }
        public string UsgUsuarioModificacion { get; set; }
        public DateTime? UsgFechaModificacion { get; set; }
    }
}
