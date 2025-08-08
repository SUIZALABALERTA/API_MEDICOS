using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipUnidadEdadInterface
    {
        public TipUnidadEdadInterface()
        {
            MstLabServicioValoresRefSevUnidadEdadMaximaNavigations = new HashSet<MstLabServicioValoresRef>();
            MstLabServicioValoresRefSevUnidadEdadMinimaNavigations = new HashSet<MstLabServicioValoresRef>();
        }

        public short UeiId { get; set; }
        public string UeiDescripcion { get; set; }
        public bool UeiEstado { get; set; }
        public string UeiUsuarioCreacion { get; set; }
        public DateTime UeiFechaRegistro { get; set; }

        public virtual ICollection<MstLabServicioValoresRef> MstLabServicioValoresRefSevUnidadEdadMaximaNavigations { get; set; }
        public virtual ICollection<MstLabServicioValoresRef> MstLabServicioValoresRefSevUnidadEdadMinimaNavigations { get; set; }
    }
}
