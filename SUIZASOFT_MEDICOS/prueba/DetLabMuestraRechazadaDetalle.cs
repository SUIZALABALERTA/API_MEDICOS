using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetLabMuestraRechazadaDetalle
    {
        public int MudIdMueRechazada { get; set; }
        public int MudIdMuestra { get; set; }
        public string MudUsuarioRegistro { get; set; }
        public DateTime? MudFechaRegistro { get; set; }
        public bool? MudEstado { get; set; }

        public virtual MstLabMuestraRechazadaCabecera MudIdMueRechazadaNavigation { get; set; }
        public virtual TipMuestraLaboratorio MudIdMuestraNavigation { get; set; }
    }
}
