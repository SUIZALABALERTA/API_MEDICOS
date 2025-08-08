using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstProductoSeguro
    {
        public int PrsId { get; set; }
        public int? PrsIdGrupo { get; set; }
        public string PrsIdCompania { get; set; }
        public string PrsRuc { get; set; }
        public string PrsNombre { get; set; }
        public bool? PrsEstado { get; set; }
        public string PrsUsuarioRegistro { get; set; }
        public DateTime? PrsfechaRegistro { get; set; }
        public string PrsUsuarioModificacion { get; set; }
        public DateTime? PrsFechaModificacion { get; set; }
    }
}
