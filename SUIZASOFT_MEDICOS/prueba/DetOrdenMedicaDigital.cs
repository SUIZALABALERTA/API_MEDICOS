using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetOrdenMedicaDigital
    {
        public int DomId { get; set; }
        public int DomOmdId { get; set; }
        public string DomOmdPeriodo { get; set; }
        public string DomOmdAnio { get; set; }
        public string DomOmdSucId { get; set; }
        public int DomItem { get; set; }
        public int? DomSerCodigo { get; set; }
        public string DomSerFox { get; set; }
        public DateTime? DomFechaCreacion { get; set; }
        public DateTime? DomFechaModificacion { get; set; }
    }
}
