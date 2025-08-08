using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstSexo
    {
        public MstSexo()
        {
            MstMedicos = new HashSet<MstMedico>();
            MstPacientes = new HashSet<MstPaciente>();
        }

        public int SexId { get; set; }
        public string SexDescripcion { get; set; }
        public char? SexAbreviatura { get; set; }

        public virtual ICollection<MstMedico> MstMedicos { get; set; }
        public virtual ICollection<MstPaciente> MstPacientes { get; set; }
    }
}
