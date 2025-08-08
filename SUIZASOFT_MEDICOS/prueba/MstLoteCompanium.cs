using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLoteCompanium
    {
        public int LteId { get; set; }
        public string LteNro { get; set; }
        public int LteIdCompania { get; set; }
        public DateTime? LteFechaProceso { get; set; }
        public string LteUsuarioCreador { get; set; }
        public DateTime? LteFechaCreacion { get; set; }
        public string LteUsuarioModificador { get; set; }
        public DateTime? LteFechaModificacion { get; set; }
    }
}
