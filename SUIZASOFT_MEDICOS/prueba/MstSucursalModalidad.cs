using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstSucursalModalidad
    {
        public int SumId { get; set; }
        public string SumIdSucursal { get; set; }
        public int? SumIdModalidad { get; set; }
        public bool? SucEstado { get; set; }
        public string SucUsuarioRegistro { get; set; }
        public DateTime? SucFechaRegistro { get; set; }
        public string SucUsuarioModificacion { get; set; }
        public DateTime? SucFechaModificacion { get; set; }

        public virtual MstModalidad SumIdModalidadNavigation { get; set; }
        public virtual MstSucursal SumIdSucursalNavigation { get; set; }
    }
}
