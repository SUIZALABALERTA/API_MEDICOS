using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetTopicoObservacion
    {
        public int DtoId { get; set; }
        public string DtoYearOrden { get; set; }
        public string DtoObservacion { get; set; }
        public string DtoUsuarioCreacion { get; set; }
        public DateTime? DtoFechaCreacion { get; set; }
        public bool? DtoEstado { get; set; }
    }
}
