using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipLineaNegocio
    {
        public TipLineaNegocio()
        {
            DetLineaNegocioServicioAreas = new HashSet<DetLineaNegocioServicioArea>();
            MstLabPerfils = new HashSet<MstLabPerfil>();
            MstServicios = new HashSet<MstServicio>();
        }

        public int LinId { get; set; }
        public int? LinUnidadNegocioId { get; set; }
        public string LinDescripcion { get; set; }
        public bool? LinEstado { get; set; }

        public virtual MstUnidadNegocio LinUnidadNegocio { get; set; }
        public virtual ICollection<DetLineaNegocioServicioArea> DetLineaNegocioServicioAreas { get; set; }
        public virtual ICollection<MstLabPerfil> MstLabPerfils { get; set; }
        public virtual ICollection<MstServicio> MstServicios { get; set; }
    }
}
