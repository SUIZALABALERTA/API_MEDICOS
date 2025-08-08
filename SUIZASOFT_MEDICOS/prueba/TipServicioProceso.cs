using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipServicioProceso
    {
        public TipServicioProceso()
        {
            MstLabPerfils = new HashSet<MstLabPerfil>();
            MstServicios = new HashSet<MstServicio>();
        }

        public int LprId { get; set; }
        public string LprDescripcion { get; set; }

        public virtual ICollection<MstLabPerfil> MstLabPerfils { get; set; }
        public virtual ICollection<MstServicio> MstServicios { get; set; }
    }
}
