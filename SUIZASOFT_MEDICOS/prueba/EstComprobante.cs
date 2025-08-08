using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class EstComprobante
    {
        public EstComprobante()
        {
            MstFacturaCabeceras = new HashSet<MstFacturaCabecera>();
        }

        public int EcoId { get; set; }
        public string EcoNombre { get; set; }
        public string EcoDescripcion { get; set; }
        public bool? EcoEstado { get; set; }

        public virtual ICollection<MstFacturaCabecera> MstFacturaCabeceras { get; set; }
    }
}
