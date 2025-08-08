using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipPromotor
    {
        public TipPromotor()
        {
            MstPromotors = new HashSet<MstPromotor>();
        }

        public int TprId { get; set; }
        public string TprNombre { get; set; }

        public virtual ICollection<MstPromotor> MstPromotors { get; set; }
    }
}
