using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class ScProgramacionFechaServicio
    {
        public ScProgramacionFechaServicio()
        {
            ScCupoHorarios = new HashSet<ScCupoHorario>();
        }

        public int PfsId { get; set; }
        public int? PfsCpfId { get; set; }
        public int? PfsSerCodigo { get; set; }
        public int? PfsMedId { get; set; }
        public int? PfsCupoCantidad { get; set; }
        public DateTime? PfsFechaCreacion { get; set; }

        public virtual ScProgramacionFecha PfsCpf { get; set; }
        public virtual MstMedico PfsMed { get; set; }
        public virtual MstServicio PfsSerCodigoNavigation { get; set; }
        public virtual ICollection<ScCupoHorario> ScCupoHorarios { get; set; }
    }
}
