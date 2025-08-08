using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class EstNotaCredito
    {
        public EstNotaCredito()
        {
            MstNotaCreditoCabeceras = new HashSet<MstNotaCreditoCabecera>();
        }

        public int EncId { get; set; }
        public string EncNombre { get; set; }
        public string EncDescripcion { get; set; }

        public virtual ICollection<MstNotaCreditoCabecera> MstNotaCreditoCabeceras { get; set; }
    }
}
