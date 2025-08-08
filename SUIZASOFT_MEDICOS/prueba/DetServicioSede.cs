using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetServicioSede
    {
        public int DssId { get; set; }
        public int? DssIdServicio { get; set; }
        public string DssIdSede { get; set; }
        public int? DssTiempoRespuesta { get; set; }
        public int? DssCupos { get; set; }
        public int? DssIdTipo { get; set; }
        public bool? DssEstado { get; set; }
        public string DssUsuarioCreacion { get; set; }
        public DateTime? DssFechaCreacion { get; set; }
        public string DssUsuarioModificacion { get; set; }
        public DateTime? DssFechaModificacion { get; set; }

        public virtual MstSucursal DssIdSedeNavigation { get; set; }
        public virtual MstServicio DssIdServicioNavigation { get; set; }
        public virtual SoTipoServicio DssIdTipoNavigation { get; set; }
    }
}
