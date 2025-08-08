using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabLoteLaboratorioCabecera
    {
        public int LosId { get; set; }
        public bool? LosEstado { get; set; }
        public string LosUsuarioRegistro { get; set; }
        public DateTime? LosFechaRegistro { get; set; }
        public int? LosIdCompania { get; set; }

        public virtual MstCompanium LosIdCompaniaNavigation { get; set; }
    }
}
