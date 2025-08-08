using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabOrdenAntibiogramaDetalle
    {
        public string LadYearorden { get; set; }
        public string LadIdServicio { get; set; }
        public string LadIdExaCodigo { get; set; }
        public int? LadPanelCodigo { get; set; }
        public int? LadLisCodigo { get; set; }
        public string LadMicroCodigo { get; set; }
        public string LadMicroDescripcion { get; set; }
        public string LadAntibioCodigo { get; set; }
        public string LadAntibioDescripcion { get; set; }
        public string LadAntibioResiste { get; set; }
        public string LadAntibioSensibi { get; set; }
        public string LadSubtant { get; set; }
        public string LadUsuarioRegistro { get; set; }
        public DateTime? LadFechaRegistro { get; set; }
        public string LadUsuarioModificacion { get; set; }
        public DateTime? LadFechaModificacion { get; set; }
        public bool? LadEstado { get; set; }
    }
}
