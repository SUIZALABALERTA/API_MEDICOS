using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipEstadoCitasSeguro
    {
        public int EscId { get; set; }
        public string EscDescripcion { get; set; }
        public string EscDescripcionCorta { get; set; }
        public bool? EscEstado { get; set; }
        public string EscUsuarioRegistro { get; set; }
        public DateTime? EscFechaRegistro { get; set; }
        public string EscUsuarioModificacion { get; set; }
        public DateTime? EscFechaModificacion { get; set; }
    }
}
