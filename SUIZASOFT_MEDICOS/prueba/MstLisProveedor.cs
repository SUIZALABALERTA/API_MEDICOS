using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLisProveedor
    {
        public int LisId { get; set; }
        public string LisNombre { get; set; }
        public string LisUsuarioRegistro { get; set; }
        public DateTime? LisFechaRegistro { get; set; }
        public string LisUsuarioModificacion { get; set; }
        public DateTime? LisFechaModificacion { get; set; }
        public bool? LisEstado { get; set; }
    }
}
