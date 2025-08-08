using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetServicioSedeFecha
    {
        public int DssfId { get; set; }
        public int? DssfIdServicio { get; set; }
        public string DssfIdSede { get; set; }
        public DateOnly? DssfFecha { get; set; }
        public int? DssfTiempoRespuesta { get; set; }
        public int? DssfCupos { get; set; }
        public int? DssfTipo { get; set; }
        public string DssfUsuarioCreacion { get; set; }
        public DateTime? DssfFechaCreacion { get; set; }

        public virtual MstSucursal DssfIdSedeNavigation { get; set; }
        public virtual MstServicio DssfIdServicioNavigation { get; set; }
        public virtual SoTipoServicio DssfTipoNavigation { get; set; }
    }
}
