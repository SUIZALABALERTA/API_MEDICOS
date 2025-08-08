using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetDiagnosticoOrdenMedica
    {
        public int DdoId { get; set; }
        public string DdoDigId { get; set; }
        public int? DdoOmdId { get; set; }
        public string DdoOmdPeriodo { get; set; }
        public string DdoOmdAnio { get; set; }
        public string DdoOmdSucId { get; set; }
        public bool? DdoEstado { get; set; }
        public DateTime? DdoFechaCreacion { get; set; }
        public DateTime? DdoFechaModificacion { get; set; }
    }
}
