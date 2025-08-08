using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstJefePromotor
    {
        public MstJefePromotor()
        {
            MstPromotors = new HashSet<MstPromotor>();
        }

        public int JprId { get; set; }
        public string JprNombre { get; set; }
        public string JprCorreo { get; set; }
        public bool? JprEstado { get; set; }
        public string JprUsuarioCreacion { get; set; }
        public DateTime? JprFechaCreacion { get; set; }
        public string JprUsuarioModificacion { get; set; }
        public DateTime? JprFechaModificacion { get; set; }

        public virtual ICollection<MstPromotor> MstPromotors { get; set; }
    }
}
