using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class LogDocumentoEnterprice
    {
        public int FeId { get; set; }
        public string FeNroservicio { get; set; }
        public string FeErrores { get; set; }
        public string FeEstadoEnvio { get; set; }
        public DateTime? FeFechaRegistro { get; set; }
    }
}
