using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetFacturaTicket
    {
        public int DftIdFactura { get; set; }
        public string DftNumeroTicket { get; set; }
        public int? DftCantidadServicios { get; set; }
        public bool? DftEstado { get; set; }
        public string DftUsuarioCreacion { get; set; }
        public DateTime? DftFechaCreacion { get; set; }
        public string DftUsuarioModificacion { get; set; }
        public DateTime? DftFechaModificacion { get; set; }
        public string DftPaciente { get; set; }
        public string DftNumeroDocumento { get; set; }

        public virtual MstFacturaCabecera DftIdFacturaNavigation { get; set; }
    }
}
