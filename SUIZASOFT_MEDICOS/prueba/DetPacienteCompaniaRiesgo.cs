using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetPacienteCompaniaRiesgo
    {
        public int DpcrIdPacienteCompania { get; set; }
        public int DpcrIdTipoRiesgo { get; set; }
        public bool DpcrEstado { get; set; }
        public string DpcrUsuarioCreacion { get; set; }
        public DateTime DpcrFechaCreacion { get; set; }
        public string DpcrUsuarioModificacion { get; set; }
        public DateTime? DpcrFechaModificacion { get; set; }

        public virtual DetPacienteCompanium DpcrIdPacienteCompaniaNavigation { get; set; }
        public virtual TipRiesgo DpcrIdTipoRiesgoNavigation { get; set; }
    }
}
