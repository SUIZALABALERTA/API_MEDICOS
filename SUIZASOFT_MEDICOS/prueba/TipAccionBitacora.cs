using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipAccionBitacora
    {
        public TipAccionBitacora()
        {
            MstBitacoraAtencionAuditoria = new HashSet<MstBitacoraAtencionAuditorium>();
        }

        public short TpaId { get; set; }
        public string TpaDescripcion { get; set; }
        public bool TpaEstado { get; set; }

        public virtual ICollection<MstBitacoraAtencionAuditorium> MstBitacoraAtencionAuditoria { get; set; }
    }
}
