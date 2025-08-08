using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstFormaterium
    {
        public int MfoId { get; set; }
        public string MfoCodigo { get; set; }
        public string MfoNombre { get; set; }
        public string MfoUrl { get; set; }
        public bool? MfoActivo { get; set; }
        public DateTime? MfoFechaCreacion { get; set; }
    }
}
