using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstAuditorium
    {
        public int AudId { get; set; }
        public string AudTable { get; set; }
        public string AudAccion { get; set; }
        public string AudValor { get; set; }
        public string AudValorNuevo { get; set; }
        public string AudUsuarioCreacion { get; set; }
        public DateTime AudFechaCreacion { get; set; }
        public string AudIpUsuarioCreacion { get; set; }
    }
}
