using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstRol
    {
        public int RolId { get; set; }
        public string RolDescripcion { get; set; }
        public bool? RolEstado { get; set; }
        public DateOnly? RolFechacreacion { get; set; }
    }
}
