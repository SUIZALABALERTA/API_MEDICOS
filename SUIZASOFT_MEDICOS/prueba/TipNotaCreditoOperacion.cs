using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipNotaCreditoOperacion
    {
        public TipNotaCreditoOperacion()
        {
            MstFacturaCabeceras = new HashSet<MstFacturaCabecera>();
            MstNotaCreditoCabeceras = new HashSet<MstNotaCreditoCabecera>();
        }

        public int NcoId { get; set; }
        public string NcoNombre { get; set; }
        public string NcoDescripcion { get; set; }

        public virtual ICollection<MstFacturaCabecera> MstFacturaCabeceras { get; set; }
        public virtual ICollection<MstNotaCreditoCabecera> MstNotaCreditoCabeceras { get; set; }
    }
}
