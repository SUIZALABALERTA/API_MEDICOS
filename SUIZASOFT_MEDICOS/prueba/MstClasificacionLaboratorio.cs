using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstClasificacionLaboratorio
    {
        public int ClaId { get; set; }
        public string ClaCodigoNivel1 { get; set; }
        public string ClaDescripcionNivel1 { get; set; }
        public string ClaCodigoNivel2 { get; set; }
        public string ClaDescripcionNivel2 { get; set; }
        public string ClaCodigoNivel3 { get; set; }
        public string ClaDescripcionNivel3 { get; set; }
        public bool? ClaEstado { get; set; }
    }
}
