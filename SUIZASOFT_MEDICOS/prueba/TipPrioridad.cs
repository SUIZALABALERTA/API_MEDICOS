using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipPrioridad
    {
        public TipPrioridad()
        {
            MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
        }

        public int TpId { get; set; }
        public string TpDescripcion { get; set; }
        public bool TpEstado { get; set; }

        public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
    }
}
