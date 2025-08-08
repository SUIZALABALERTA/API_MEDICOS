using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipModuloFacturacion
    {
        public TipModuloFacturacion()
        {
            MstFacturaCabeceras = new HashSet<MstFacturaCabecera>();
            MstNotaCreditoCabeceras = new HashSet<MstNotaCreditoCabecera>();
        }

        public int MfaId { get; set; }
        public string MfaNombre { get; set; }
        public string MfaNombreCorto { get; set; }
        public string MfaDescripcion { get; set; }

        public virtual ICollection<MstFacturaCabecera> MstFacturaCabeceras { get; set; }
        public virtual ICollection<MstNotaCreditoCabecera> MstNotaCreditoCabeceras { get; set; }
    }
}
