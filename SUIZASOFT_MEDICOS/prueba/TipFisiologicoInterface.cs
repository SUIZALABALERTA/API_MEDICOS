using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipFisiologicoInterface
    {
        public TipFisiologicoInterface()
        {
            MstLabServicioValoresRefs = new HashSet<MstLabServicioValoresRef>();
        }

        public short FiId { get; set; }
        public string FiDescripcion { get; set; }
        public bool FiEstado { get; set; }
        public string FiUsuarioCreacion { get; set; }
        public DateTime FiFechaRegistro { get; set; }

        public virtual ICollection<MstLabServicioValoresRef> MstLabServicioValoresRefs { get; set; }
    }
}
