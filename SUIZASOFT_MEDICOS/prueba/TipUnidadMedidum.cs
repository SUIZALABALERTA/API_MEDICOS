using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipUnidadMedidum
    {
        public TipUnidadMedidum()
        {
            MstServicios = new HashSet<MstServicio>();
        }

        public int UmId { get; set; }
        public string UmDescripcion { get; set; }
        public bool UmEstado { get; set; }
        public string UmUsuarioCreacion { get; set; }
        public DateTime UmFechaRegistro { get; set; }

        public virtual ICollection<MstServicio> MstServicios { get; set; }
    }
}
