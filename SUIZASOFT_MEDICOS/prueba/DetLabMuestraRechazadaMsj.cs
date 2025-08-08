using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetLabMuestraRechazadaMsj
    {
        public int MumIdMueRechazada { get; set; }
        public int MumIdItem { get; set; }
        public string MumMensaje { get; set; }
        public string MumUsuarioMensaje { get; set; }
        public DateTime? MumFechaMensaje { get; set; }
        public bool? MumEstado { get; set; }

        public virtual MstLabMuestraRechazadaCabecera MumIdMueRechazadaNavigation { get; set; }
    }
}
