using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipServicioMetodoLaboratorio
    {
        public TipServicioMetodoLaboratorio()
        {
            MstLabPerfils = new HashSet<MstLabPerfil>();
            MstServicios = new HashSet<MstServicio>();
        }

        public int MetId { get; set; }
        public string MetDescripcion { get; set; }
        public string MetCodigoAnterior { get; set; }
        public bool? MetEstado { get; set; }

        public virtual ICollection<MstLabPerfil> MstLabPerfils { get; set; }
        public virtual ICollection<MstServicio> MstServicios { get; set; }
    }
}
