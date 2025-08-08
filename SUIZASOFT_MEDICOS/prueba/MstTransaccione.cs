using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTransaccione
    {
        public int TraId { get; set; }
        public string TraNumeroTransaccion { get; set; }
        public DateTime TraFechaCreacion { get; set; }
        public string TraTicket { get; set; }
        public char TraEstado { get; set; }
        public decimal TraMonto { get; set; }
    }
}
