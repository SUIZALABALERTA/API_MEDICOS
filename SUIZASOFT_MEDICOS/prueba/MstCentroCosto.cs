using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstCentroCosto
    {
        public int CecId { get; set; }
        public string CecNombre { get; set; }
        public bool? CecEstado { get; set; }
        public string CecUsuarioCreacion { get; set; }
        public DateTime? CecFechaCreacion { get; set; }
        public string CecUsuarioModificacion { get; set; }
        public DateTime? CecFechaModificacion { get; set; }
    }
}
