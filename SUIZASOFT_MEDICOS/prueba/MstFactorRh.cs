using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstFactorRh
    {
        public MstFactorRh()
        {
            MstPacientes = new HashSet<MstPaciente>();
        }

        public int FrhId { get; set; }
        public string FrhNombre { get; set; }
        public bool FrhEstado { get; set; }

        public virtual ICollection<MstPaciente> MstPacientes { get; set; }
    }
}
