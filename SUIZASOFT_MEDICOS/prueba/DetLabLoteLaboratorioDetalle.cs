using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetLabLoteLaboratorioDetalle
    {
        public int LldId { get; set; }
        public int LldIdCabecera { get; set; }
        public int LldIdTicket { get; set; }
        public string LldPeriodoTicket { get; set; }
        public string LldAnioTicket { get; set; }
        public string LldSucursalTicket { get; set; }
        public bool? LldEstado { get; set; }
    }
}
