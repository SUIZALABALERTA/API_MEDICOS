using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabOrdenEscaneo
    {
        public int LoeId { get; set; }
        public int? LoeTicketIdCabecera { get; set; }
        public string LoeTicketPeriodo { get; set; }
        public string LoeTicketAnio { get; set; }
        public string LoeTicketIdSucursal { get; set; }
        public string LoeIdSucursalEscaneo { get; set; }
        public int? LoeIdServicio { get; set; }
        public int? LoeIdMuestra { get; set; }
        public string LoeUsuarioEscaneo { get; set; }
        public DateTime? LoeFechaEscaneo { get; set; }
        public string LoeUsuarioAnulacion { get; set; }
        public DateTime? LoeFechaAnulacion { get; set; }
        public bool? LoeEstado { get; set; }
        public bool? LoeFlagPerfil { get; set; }
        public string LoeUsuarioDesescaneo { get; set; }
        public DateTime? LoeFechaDesescaneo { get; set; }

        public virtual MstSucursal LoeIdSucursalEscaneoNavigation { get; set; }
        public virtual MstOrdenServicioCabecera LoeTicket { get; set; }
    }
}
