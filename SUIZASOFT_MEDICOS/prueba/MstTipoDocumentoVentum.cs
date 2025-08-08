using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTipoDocumentoVentum
    {
        public MstTipoDocumentoVentum()
        {
            DetNotaCreditoDetalles = new HashSet<DetNotaCreditoDetalle>();
            MstAgenteSeries = new HashSet<MstAgenteSerie>();
            MstFacturaCabeceras = new HashSet<MstFacturaCabecera>();
            MstNotaCreditoCabeceraNccIdTipDocVentaFacNavigations = new HashSet<MstNotaCreditoCabecera>();
            MstNotaCreditoCabeceraNccIdTipoDocVentaNcNavigations = new HashSet<MstNotaCreditoCabecera>();
        }

        public int TdvId { get; set; }
        public string TdvNombre { get; set; }
        public string TdvNombreCorto { get; set; }
        public bool? TdvEstado { get; set; }

        public virtual ICollection<DetNotaCreditoDetalle> DetNotaCreditoDetalles { get; set; }
        public virtual ICollection<MstAgenteSerie> MstAgenteSeries { get; set; }
        public virtual ICollection<MstFacturaCabecera> MstFacturaCabeceras { get; set; }
        public virtual ICollection<MstNotaCreditoCabecera> MstNotaCreditoCabeceraNccIdTipDocVentaFacNavigations { get; set; }
        public virtual ICollection<MstNotaCreditoCabecera> MstNotaCreditoCabeceraNccIdTipoDocVentaNcNavigations { get; set; }
    }
}
