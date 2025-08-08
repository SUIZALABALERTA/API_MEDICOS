using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipEquipoLaboratorio
    {
        public TipEquipoLaboratorio()
        {
            MstLabPerfils = new HashSet<MstLabPerfil>();
            MstServicios = new HashSet<MstServicio>();
        }

        public int EquId { get; set; }
        public string EquDescripcion { get; set; }
        public string EquCodigoAnterior { get; set; }
        public bool? EquEstado { get; set; }

        public virtual ICollection<MstLabPerfil> MstLabPerfils { get; set; }
        public virtual ICollection<MstServicio> MstServicios { get; set; }
    }
}
