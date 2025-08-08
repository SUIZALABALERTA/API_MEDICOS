using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipRiesgo
    {
        public TipRiesgo()
        {
            DetPacienteCompaniaRiesgos = new HashSet<DetPacienteCompaniaRiesgo>();
        }

        public int TrsgId { get; set; }
        public string TrsgNombre { get; set; }
        public bool TrsgEstado { get; set; }

        public virtual ICollection<DetPacienteCompaniaRiesgo> DetPacienteCompaniaRiesgos { get; set; }
    }
}
