using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabOrdenMuestraPerfil
    {
        public string OmpYearorden { get; set; }
        public int OmpMueCodigo { get; set; }
        public int OmpIdPerfil { get; set; }
        public string OmpOrdenNumero { get; set; }
        public string OmpUsuarioRegistro { get; set; }
        public DateTime? OmpFechaRegistro { get; set; }
        public bool? OmpEstado { get; set; }
        public bool? OmpFlagEscaneo { get; set; }
        public bool? OmpFlagPerfil { get; set; }
    }
}
