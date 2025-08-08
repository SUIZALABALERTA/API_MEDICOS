using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstCie10
    {
        public MstCie10()
        {
            MstDiagnosticos = new HashSet<MstDiagnostico>();
        }

        public string CieId { get; set; }
        public string CieDescripcion { get; set; }

        public virtual ICollection<MstDiagnostico> MstDiagnosticos { get; set; }
    }
}
