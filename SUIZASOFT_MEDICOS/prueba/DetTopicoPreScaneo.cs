using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetTopicoPreScaneo
    {
        public int DtsId { get; set; }
        public string DtsOrden { get; set; }
        public int? DtsIdMuestra { get; set; }
        public int? DtsIdIngreso { get; set; }
        public string DtsPaciente { get; set; }
        public DateTime? DtsFechaOrden { get; set; }
        public string DtsUsuarioEscaneo { get; set; }
        public DateTime? DtsFechaEscaneo { get; set; }
        public string DtsObservacion { get; set; }
        public bool? DtsEstado { get; set; }
        public bool? DtsEnviado { get; set; }
        public string DtsIdentificadorSedeOrigen { get; set; }
        public string DtsNumeroDocumento { get; set; }
        public DateTime? DtsFechaNacimiento { get; set; }
        public string DtsSexo { get; set; }
        public string DtsYearOrden { get; set; }

        public virtual TipMuestraLaboratorio DtsIdMuestraNavigation { get; set; }
    }
}
