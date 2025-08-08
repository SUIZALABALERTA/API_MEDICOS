using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstAgenteSerie
    {
        public MstAgenteSerie()
        {
            DetFacturaAnticipos = new HashSet<DetFacturaAnticipo>();
            MstUsuarioSeries = new HashSet<MstUsuarioSerie>();
        }

        public int AseId { get; set; }
        public string AseIdSucursal { get; set; }
        public int? AseIdTipoDocVenta { get; set; }
        public string AseSerie { get; set; }
        public int? AseCorrelativo { get; set; }
        public bool? AseEstado { get; set; }
        public string AseUsuarioCreacion { get; set; }
        public DateTime? AseFechaCreacion { get; set; }
        public string AseUsuarioModificacion { get; set; }
        public DateTime? AseFechaModificacion { get; set; }

        public virtual MstSucursal AseIdSucursalNavigation { get; set; }
        public virtual MstTipoDocumentoVentum AseIdTipoDocVentaNavigation { get; set; }
        public virtual ICollection<DetFacturaAnticipo> DetFacturaAnticipos { get; set; }
        public virtual ICollection<MstUsuarioSerie> MstUsuarioSeries { get; set; }
    }
}
