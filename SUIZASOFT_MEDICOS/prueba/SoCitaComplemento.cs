using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class SoCitaComplemento
    {
        public int CcoId { get; set; }
        public int CcoIdCita { get; set; }
        public int CcoIdComplemento { get; set; }

        public virtual MstCitaParticular CcoIdCitaNavigation { get; set; }
        public virtual SoComplemento CcoIdComplementoNavigation { get; set; }
    }
}
