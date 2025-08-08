using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstEstadoCivil
    {
        public MstEstadoCivil()
        {
            MstPacientes = new HashSet<MstPaciente>();
        }

        public int EciId { get; set; }
        public string EciDescripcion { get; set; }

        public virtual ICollection<MstPaciente> MstPacientes { get; set; }
    }
}
