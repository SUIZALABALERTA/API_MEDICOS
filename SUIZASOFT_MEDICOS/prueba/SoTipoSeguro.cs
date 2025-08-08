using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class SoTipoSeguro
    {
        public SoTipoSeguro()
        {
            MstCitaParticulars = new HashSet<MstCitaParticular>();
        }

        public int TseId { get; set; }
        public string TseNombre { get; set; }
        public bool? TseEstado { get; set; }

        public virtual ICollection<MstCitaParticular> MstCitaParticulars { get; set; }
    }
}
