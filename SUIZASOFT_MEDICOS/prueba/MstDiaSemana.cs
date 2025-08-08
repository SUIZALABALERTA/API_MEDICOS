using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstDiaSemana
    {
        public MstDiaSemana()
        {
            ScProgramacionFechas = new HashSet<ScProgramacionFecha>();
        }

        public int MdsId { get; set; }
        public string MdsNombre { get; set; }
        public string MdsAbreviatura { get; set; }
        public char? MdsSimbolo { get; set; }
        public DateTime? MdsFechaCreacion { get; set; }

        public virtual ICollection<ScProgramacionFecha> ScProgramacionFechas { get; set; }
    }
}
