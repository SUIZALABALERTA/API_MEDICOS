using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstRuteoSeguro
    {
        public int RusId { get; set; }
        public DateTime? RusFecha { get; set; }
        public int? RusNumeroCitas { get; set; }
        public int? RusNumeroMedicos { get; set; }
        public bool? RusEstado { get; set; }
        public string RusObseracion { get; set; }
        public bool? RusFlagEnvio { get; set; }
        public string RusUsuarioRegistro { get; set; }
        public DateTime? RusFechaRegistro { get; set; }
        public string RusUsuarioModificacion { get; set; }
        public DateTime? RusFechaModificacion { get; set; }
    }
}
