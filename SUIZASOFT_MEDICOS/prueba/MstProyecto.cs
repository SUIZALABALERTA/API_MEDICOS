using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstProyecto
    {
        public MstProyecto()
        {
            MstServicios = new HashSet<MstServicio>();
        }

        public int PryId { get; set; }
        public string PryDescripcion { get; set; }
        public bool? PryEstado { get; set; }
        public DateTime? PryFechaCreacion { get; set; }
        public string PryCodigoAnterior { get; set; }
        public string PryCodigoSap { get; set; }

        public virtual ICollection<MstServicio> MstServicios { get; set; }
    }
}
