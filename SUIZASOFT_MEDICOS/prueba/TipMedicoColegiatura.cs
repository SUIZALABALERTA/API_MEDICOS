using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipMedicoColegiatura
    {
        public TipMedicoColegiatura()
        {
            MstMedicos = new HashSet<MstMedico>();
        }

        public int TmcId { get; set; }
        public string TmcNombre { get; set; }
        public string TmcDescripcion { get; set; }
        public bool? TmcEstado { get; set; }

        public virtual ICollection<MstMedico> MstMedicos { get; set; }
    }
}
