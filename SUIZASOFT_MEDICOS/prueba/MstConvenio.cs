using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstConvenio
    {
        public long ConvId { get; set; }
        public string ConvDescripcion { get; set; }
        public bool? ConvEstado { get; set; }
        public string ConvCodigoAnterior { get; set; }
    }
}
