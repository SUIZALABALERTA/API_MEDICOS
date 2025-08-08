using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipCentroCostoNegocio
    {
        public TipCentroCostoNegocio()
        {
            MstLabPerfils = new HashSet<MstLabPerfil>();
            MstServicioAreaNegocios = new HashSet<MstServicioAreaNegocio>();
            MstServicios = new HashSet<MstServicio>();
        }

        public int CecId { get; set; }
        public string CecDescripcion { get; set; }
        public bool? CecEstado { get; set; }

        public virtual ICollection<MstLabPerfil> MstLabPerfils { get; set; }
        public virtual ICollection<MstServicioAreaNegocio> MstServicioAreaNegocios { get; set; }
        public virtual ICollection<MstServicio> MstServicios { get; set; }
    }
}
