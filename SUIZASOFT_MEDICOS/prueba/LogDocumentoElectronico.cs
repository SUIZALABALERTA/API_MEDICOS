using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class LogDocumentoElectronico
    {
        public int FeId { get; set; }
        public string FeTipodocumento { get; set; }
        public string FeNumerodocumento { get; set; }
        public string FeTramaEnviada { get; set; }
        public string FeErrores { get; set; }
        public string FeEstadoEnvio { get; set; }
        public DateTime? FeFechaRegistro { get; set; }
    }
}
