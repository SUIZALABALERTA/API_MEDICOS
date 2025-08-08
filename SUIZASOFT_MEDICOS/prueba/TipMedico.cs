using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipMedico
    {
        public TipMedico()
        {
            MstMedicos = new HashSet<MstMedico>();
        }

        public int TmeId { get; set; }
        public string TmeNombre { get; set; }
        public string TmeDescripccion { get; set; }
        public bool? TmeEstado { get; set; }

        public virtual ICollection<MstMedico> MstMedicos { get; set; }
    }
}
