using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabOrdenImpresion
    {
        public MstLabOrdenImpresion()
        {
            DetLabOrdenImpresions = new HashSet<DetLabOrdenImpresion>();
        }

        public int LoiId { get; set; }
        public int LoiTicketIdCabecera { get; set; }
        public string LoiTicketPeriodo { get; set; }
        public string LoiTicketAnio { get; set; }
        public string LoiTicketIdSucursal { get; set; }
        public bool LoiEstado { get; set; }
        public string LoiUsuarioCreacion { get; set; }
        public DateTime LoiFechaCreacion { get; set; }
        public string LoiUsuarioModificacion { get; set; }
        public DateTime? LoiFechaModificacion { get; set; }

        public virtual MstOrdenServicioCabecera LoiTicket { get; set; }
        public virtual ICollection<DetLabOrdenImpresion> DetLabOrdenImpresions { get; set; }
    }
}
