using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTipoPago
    {
        public MstTipoPago()
        {
            DetFacturaMedioPagos = new HashSet<DetFacturaMedioPago>();
            MstCompania = new HashSet<MstCompanium>();
        }

        public int TpaId { get; set; }
        public string TpaDescripcion { get; set; }

        public virtual ICollection<DetFacturaMedioPago> DetFacturaMedioPagos { get; set; }
        public virtual ICollection<MstCompanium> MstCompania { get; set; }
    }
}
