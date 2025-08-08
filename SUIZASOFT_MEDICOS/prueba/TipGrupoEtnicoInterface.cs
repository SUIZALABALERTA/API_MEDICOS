using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipGrupoEtnicoInterface
    {
        public TipGrupoEtnicoInterface()
        {
            MstLabServicioValoresRefs = new HashSet<MstLabServicioValoresRef>();
        }

        public short GeId { get; set; }
        public string GeDescripcion { get; set; }
        public bool GeEstado { get; set; }
        public string GeUsuarioCreacion { get; set; }
        public DateTime GeFechaRegistro { get; set; }

        public virtual ICollection<MstLabServicioValoresRef> MstLabServicioValoresRefs { get; set; }
    }
}
