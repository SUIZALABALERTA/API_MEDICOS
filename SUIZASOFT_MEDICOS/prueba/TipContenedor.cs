using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipContenedor
    {
        public TipContenedor()
        {
            TipMuestraLaboratorios = new HashSet<TipMuestraLaboratorio>();
        }

        public int TcoId { get; set; }
        public string TcoDescripcion { get; set; }
        public bool? TcoEstado { get; set; }

        public virtual ICollection<TipMuestraLaboratorio> TipMuestraLaboratorios { get; set; }
    }
}
