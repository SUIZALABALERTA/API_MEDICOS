using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstUsuario
    {
        public int UsuId { get; set; }
        public string UsuUsuario { get; set; }
        public string UsuNombre { get; set; }
        public string UsuApellido { get; set; }
        public string UsuUsuarioCreacion { get; set; }
        public DateTime? UsuFechaCreacion { get; set; }
        public string UsuUsuarioModificacion { get; set; }
        public DateTime? UsuFechaModificacion { get; set; }
        public bool? UsuEstado { get; set; }
    }
}
