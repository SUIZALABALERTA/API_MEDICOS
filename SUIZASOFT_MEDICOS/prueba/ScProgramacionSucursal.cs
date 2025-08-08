using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class ScProgramacionSucursal
    {
        public ScProgramacionSucursal()
        {
            ScProgramacionFechas = new HashSet<ScProgramacionFecha>();
        }

        public int CpsId { get; set; }
        public string CpsSucursalId { get; set; }
        public DateOnly? CpsFechaInicio { get; set; }
        public DateOnly? CpsFechaFin { get; set; }
        public bool? CpsEstado { get; set; }
        public DateTime? CpsFechaCreacion { get; set; }

        public virtual ICollection<ScProgramacionFecha> ScProgramacionFechas { get; set; }
    }
}
