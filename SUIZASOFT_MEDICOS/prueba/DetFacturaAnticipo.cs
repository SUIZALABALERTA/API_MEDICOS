using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetFacturaAnticipo
    {
        public int DfaId { get; set; }
        public int? DfaIdCompania { get; set; }
        public int? DfaIdAgenteSerie { get; set; }
        public string DfaUsuarioCreacion { get; set; }
        public DateTime? DfaFechaCreacion { get; set; }
        public string DfaUsuarioModificacion { get; set; }
        public DateTime? DfaFechaModificacion { get; set; }
        public decimal? DfaPago { get; set; }
        public string DfaSerie { get; set; }
        public int? DfaCorrelativo { get; set; }

        public virtual MstAgenteSerie DfaIdAgenteSerieNavigation { get; set; }
        public virtual MstCompanium DfaIdCompaniaNavigation { get; set; }
    }
}
