using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipServicioTemperatura
    {
        public TipServicioTemperatura()
        {
            MstLabPerfils = new HashSet<MstLabPerfil>();
            MstServicios = new HashSet<MstServicio>();
        }

        public int LteId { get; set; }
        public string LteDescripcion { get; set; }

        public virtual ICollection<MstLabPerfil> MstLabPerfils { get; set; }
        public virtual ICollection<MstServicio> MstServicios { get; set; }
    }
}
