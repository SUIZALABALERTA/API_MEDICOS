using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetDiagnosticoRecomendacione
    {
        public int DdrId { get; set; }
        public string DdrIdDiagnostico { get; set; }
        public string DdrRecomendacion { get; set; }
        public bool DdrEstado { get; set; }
        public string DdrUsuarioCreacion { get; set; }
        public DateTime DdrFechaCreacion { get; set; }
        public string DdrUsuarioModificacion { get; set; }
        public DateTime? DdrFechaModificacion { get; set; }

        public virtual MstDiagnostico DdrIdDiagnosticoNavigation { get; set; }
    }
}
