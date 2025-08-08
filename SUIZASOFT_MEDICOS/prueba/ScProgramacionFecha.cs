using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class ScProgramacionFecha
    {
        public ScProgramacionFecha()
        {
            ScProgramacionFechaServicios = new HashSet<ScProgramacionFechaServicio>();
        }

        public int CpfId { get; set; }
        public int? CpfCpsId { get; set; }
        public DateOnly? CpfFecha { get; set; }
        public int? CpfMdsId { get; set; }
        public DateTime? CpfFechaCreacion { get; set; }

        public virtual ScProgramacionSucursal CpfCps { get; set; }
        public virtual MstDiaSemana CpfMds { get; set; }
        public virtual ICollection<ScProgramacionFechaServicio> ScProgramacionFechaServicios { get; set; }
    }
}
