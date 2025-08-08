using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipVigenciaOrdenMedica
    {
        public int VomId { get; set; }
        public string VomNombre { get; set; }
        public bool? VomEstado { get; set; }
        public DateTime? VomFechaCreacion { get; set; }
        public DateTime? VomFechaModificaion { get; set; }
    }
}
