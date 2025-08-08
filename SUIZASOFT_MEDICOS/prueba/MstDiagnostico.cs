using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstDiagnostico
    {
        public MstDiagnostico()
        {
            DetDiagnosticoRecomendaciones = new HashSet<DetDiagnosticoRecomendacione>();
        }

        public string DigId { get; set; }
        public string DigDescripcion { get; set; }
        public string DigCie { get; set; }

        public virtual MstCie10 DigCieNavigation { get; set; }
        public virtual ICollection<DetDiagnosticoRecomendacione> DetDiagnosticoRecomendaciones { get; set; }
    }
}
