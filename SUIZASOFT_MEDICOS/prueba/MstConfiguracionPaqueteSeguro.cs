using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstConfiguracionPaqueteSeguro
    {
        public int CopId { get; set; }
        public int? CopIdPaquete { get; set; }
        public int? CopIdCompania { get; set; }
        public int? CopSexo { get; set; }
        public int? CopEdadMinima { get; set; }
        public int? CopEdadMaxima { get; set; }
        public decimal? CopMontoMinimo { get; set; }
        public decimal? CopMontoMaximo { get; set; }
        public bool? CopEstado { get; set; }
        public string CopUsuarioRegistro { get; set; }
        public DateTime? CopFechaRegistro { get; set; }
        public string CopUsuarioModificacion { get; set; }
        public DateTime? CopFechaModificacion { get; set; }
    }
}
