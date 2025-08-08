using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class ConSecuenciaTabla
    {
        public string SecNombre { get; set; }
        public string SecPeriodo { get; set; }
        public string SecAnio { get; set; }
        public string SecDia { get; set; }
        public string SecSucursal { get; set; }
        public int SecId { get; set; }
        public string SecDescripcion { get; set; }
        public DateTime? SecFechaRegistro { get; set; }
        public string SecUsuarioRegistro { get; set; }
        public bool? SecEstado { get; set; }
        public int? SecCorrelativo { get; set; }
    }
}
