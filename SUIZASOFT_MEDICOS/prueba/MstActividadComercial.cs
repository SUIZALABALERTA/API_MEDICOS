using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstActividadComercial
    {
        public MstActividadComercial()
        {
            MstCompania = new HashSet<MstCompanium>();
        }

        public int AcoId { get; set; }
        public string AcoDescripccion { get; set; }
        public string AcoActividadHist { get; set; }

        public virtual ICollection<MstCompanium> MstCompania { get; set; }
    }
}
