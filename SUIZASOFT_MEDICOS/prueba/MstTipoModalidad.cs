using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTipoModalidad
    {
        public string TmoId { get; set; }
        public string TmoDescripcion { get; set; }
        public int? TmoIdModalidad { get; set; }
        public string TmoCodigoAnterior { get; set; }
        public bool? TmoEstado { get; set; }

        public virtual MstModalidad TmoIdModalidadNavigation { get; set; }
    }
}
