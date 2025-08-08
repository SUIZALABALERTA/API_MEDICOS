using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetLabMuestraRechazadaImagen
    {
        public int MuiIdMueRechazada { get; set; }
        public int MuiIdItem { get; set; }
        public string MuiImagen { get; set; }
        public string MuiUsuarioRegistro { get; set; }
        public DateTime? MuiFechaRegistro { get; set; }
        public bool? MuiEstado { get; set; }

        public virtual MstLabMuestraRechazadaCabecera MuiIdMueRechazadaNavigation { get; set; }
    }
}
