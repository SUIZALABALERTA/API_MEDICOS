using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstGrupoSanguineo
    {
        public MstGrupoSanguineo()
        {
            MstPacientes = new HashSet<MstPaciente>();
        }

        public int GrsngId { get; set; }
        public string GrsngNombre { get; set; }
        public bool GrsngEstado { get; set; }

        public virtual ICollection<MstPaciente> MstPacientes { get; set; }
    }
}
