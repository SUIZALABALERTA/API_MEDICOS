using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipSeguro
    {
        public TipSeguro()
        {
            MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
        }

        public int TsegId { get; set; }
        public string TsegNombre { get; set; }
        public bool TsegEstado { get; set; }

        public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
    }
}
