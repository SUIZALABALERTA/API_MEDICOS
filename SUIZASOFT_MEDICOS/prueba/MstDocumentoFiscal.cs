using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstDocumentoFiscal
    {
        public MstDocumentoFiscal()
        {
            MstCompania = new HashSet<MstCompanium>();
        }

        public int DfiId { get; set; }
        public string DfiDescripcion { get; set; }

        public virtual ICollection<MstCompanium> MstCompania { get; set; }
    }
}
