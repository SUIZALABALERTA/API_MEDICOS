using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class ScSubModalidad
    {
        public int CsmId { get; set; }
        public string CsmTmoId { get; set; }
        public bool? CsmEstado { get; set; }
        public DateTime? CsmFechaCreacion { get; set; }

        public virtual MstTipoModalidad CsmTmo { get; set; }
    }
}
