using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class EstTicket
    {
        public EstTicket()
        {
            DetTicketEstados = new HashSet<DetTicketEstado>();
            MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
            MstPreticketCabeceras = new HashSet<MstPreticketCabecera>();
        }

        public int EtiId { get; set; }
        public string EtiNombre { get; set; }
        public string EtiDescripcion { get; set; }

        public virtual ICollection<DetTicketEstado> DetTicketEstados { get; set; }
        public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
        public virtual ICollection<MstPreticketCabecera> MstPreticketCabeceras { get; set; }
    }
}
