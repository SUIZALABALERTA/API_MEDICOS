using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetLabOrdenImpresion
    {
        public int DloiId { get; set; }
        public int DloiIdOrdenImpresion { get; set; }
        public int LoiTicketItem { get; set; }
        public int LoiIdServicio { get; set; }
        public bool LoiFlagPerfil { get; set; }
        public bool LoiEstado { get; set; }
        public string LoiUsuarioCreacion { get; set; }
        public DateTime LoiFechaCreacion { get; set; }

        public virtual MstLabOrdenImpresion DloiIdOrdenImpresionNavigation { get; set; }
    }
}
