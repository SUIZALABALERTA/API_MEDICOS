using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTipoVentum
    {
        public MstTipoVentum()
        {
            MstCompania = new HashSet<MstCompanium>();
        }

        public int TveId { get; set; }
        public string TveDescripcion { get; set; }
        public string TveCodigoAnterior { get; set; }
        public bool? TveEstado { get; set; }

        public virtual ICollection<MstCompanium> MstCompania { get; set; }
    }
}
