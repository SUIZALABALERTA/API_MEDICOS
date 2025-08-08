using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipTopicoIngreso
    {
        public TipTopicoIngreso()
        {
            MstTopicoEscaneos = new HashSet<MstTopicoEscaneo>();
        }

        public int TtiId { get; set; }
        public string TtiNombre { get; set; }
        public string TtiDescripcion { get; set; }
        public bool? TtiEstado { get; set; }

        public virtual ICollection<MstTopicoEscaneo> MstTopicoEscaneos { get; set; }
    }
}
