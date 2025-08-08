using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabGrupoEtnico
    {
        public MstLabGrupoEtnico()
        {
            MstPacientes = new HashSet<MstPaciente>();
        }

        public int GreId { get; set; }
        public string GreNombre { get; set; }
        public bool? GreEstado { get; set; }

        public virtual ICollection<MstPaciente> MstPacientes { get; set; }
    }
}
