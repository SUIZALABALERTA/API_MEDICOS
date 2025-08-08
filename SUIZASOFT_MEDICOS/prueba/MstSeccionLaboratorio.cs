using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstSeccionLaboratorio
    {
        public int SecId { get; set; }
        public int? SecAreId { get; set; }
        public int? SecTipId { get; set; }
        public string SecDescripcion { get; set; }
        public bool? SecEstado { get; set; }

        public virtual TipServicioAreaLaboratorioBak SecAre { get; set; }
        public virtual MstTipoLaboratorio SecTip { get; set; }
    }
}
