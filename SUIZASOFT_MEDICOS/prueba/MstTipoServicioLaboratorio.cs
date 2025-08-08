using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTipoServicioLaboratorio
    {
        public MstTipoServicioLaboratorio()
        {
            MstServicios = new HashSet<MstServicio>();
        }

        public int TisId { get; set; }
        public string TisDescripcion { get; set; }
        public bool? TipEstado { get; set; }

        public virtual ICollection<MstServicio> MstServicios { get; set; }
    }
}
