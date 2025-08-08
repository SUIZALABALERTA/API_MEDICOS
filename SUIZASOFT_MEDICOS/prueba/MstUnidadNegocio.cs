using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstUnidadNegocio
    {
        public MstUnidadNegocio()
        {
            MstLabPerfils = new HashSet<MstLabPerfil>();
            MstServicios = new HashSet<MstServicio>();
            TipLineaNegocios = new HashSet<TipLineaNegocio>();
        }

        public int UniId { get; set; }
        public string UniDescripcion { get; set; }
        public bool? UniEstado { get; set; }

        public virtual ICollection<MstLabPerfil> MstLabPerfils { get; set; }
        public virtual ICollection<MstServicio> MstServicios { get; set; }
        public virtual ICollection<TipLineaNegocio> TipLineaNegocios { get; set; }
    }
}
