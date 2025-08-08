using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetOrdenServicioOrdenMedica
    {
        public int DosomId { get; set; }
        public int DosomTicketId { get; set; }
        public string DosomTicketPeriodo { get; set; }
        public string DosomTicketAnio { get; set; }
        public string DosomTicketIdSucursal { get; set; }
        public string DosomRutaOrdenMedica { get; set; }
        public string DosomNombreArchivo { get; set; }
        public bool DosomEstado { get; set; }
        public string DosomUsuarioCreacion { get; set; }
        public DateTime DosomFechaCreacion { get; set; }
        public string DosomUsuarioModificacion { get; set; }
        public DateTime? DosomFechaModificacion { get; set; }

        public virtual MstOrdenServicioCabecera DosomTicket { get; set; }
    }
}
