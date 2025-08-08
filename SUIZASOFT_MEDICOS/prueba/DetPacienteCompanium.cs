using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetPacienteCompanium
    {
        public DetPacienteCompanium()
        {
            DetPacienteCompaniaRiesgos = new HashSet<DetPacienteCompaniaRiesgo>();
        }

        public int DpcId { get; set; }
        public int DpcIdPaciente { get; set; }
        public int DpcIdCompania { get; set; }
        public string DpcCargo { get; set; }
        public string DpcArea { get; set; }
        public bool DpcFlagActual { get; set; }
        public DateOnly? DpcFechaInicioLaboral { get; set; }
        public DateOnly? DpcFechaFinLaboral { get; set; }
        public short? DpcNroDiasLaboral { get; set; }
        public TimeOnly? DpcHorasLaboral { get; set; }
        public bool DpcEstado { get; set; }
        public string DpcUsuarioCreacion { get; set; }
        public DateTime DpcFechaCreacion { get; set; }
        public string DpcUsuarioModificacion { get; set; }
        public DateTime? DpcFechaModificacion { get; set; }

        public virtual MstCompanium DpcIdCompaniaNavigation { get; set; }
        public virtual MstPaciente DpcIdPacienteNavigation { get; set; }
        public virtual ICollection<DetPacienteCompaniaRiesgo> DetPacienteCompaniaRiesgos { get; set; }
    }
}
