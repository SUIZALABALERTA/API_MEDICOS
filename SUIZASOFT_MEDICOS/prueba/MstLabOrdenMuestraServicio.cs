using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabOrdenMuestraServicio
    {
        public string OmsYearorden { get; set; }
        public int OmsMueCodigo { get; set; }
        public int OmsIdServicio { get; set; }
        public bool OmsFlagPerfil { get; set; }
        public string OmsOrdenNumero { get; set; }
        public string OmsUsuarioRegistro { get; set; }
        public DateTime? OmsFechaRegistro { get; set; }
        public bool? OmsEstado { get; set; }
        public bool? OmsFlagEscaneo { get; set; }
        public string OmsEscaneoDetalle { get; set; }
    }
}
