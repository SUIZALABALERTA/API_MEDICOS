using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetTicketEstado
    {
        public int DteId { get; set; }
        public string DteTicket { get; set; }
        public int? DteIdEstado { get; set; }
        public string DteUsuarioCreacion { get; set; }
        public DateTime? DteFechaCreacion { get; set; }

        public virtual EstTicket DteIdEstadoNavigation { get; set; }
    }
}
