using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetLineaNegocioServicioArea
    {
        public int LnsLineaNegocioId { get; set; }
        public int LnsAreaId { get; set; }
        public bool? LnsEstado { get; set; }

        public virtual MstServicioAreaNegocio LnsArea { get; set; }
        public virtual TipLineaNegocio LnsLineaNegocio { get; set; }
    }
}
