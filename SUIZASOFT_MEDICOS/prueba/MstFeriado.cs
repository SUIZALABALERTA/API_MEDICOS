using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstFeriado
    {
        public int FerId { get; set; }
        public string FerIdSucursal { get; set; }
        public DateOnly? FerFecha { get; set; }
        public string FerTipo { get; set; }
        public TimeOnly? FerHoraInicio { get; set; }
        public TimeOnly? FerHoraFin { get; set; }
        public string FerUsuarioCreacion { get; set; }
        public DateTime? FerFechaCreacion { get; set; }
        public string FerUsuarioModificacion { get; set; }
        public DateTime? FerFechaModificacion { get; set; }
        public bool? FerEstado { get; set; }
        public string FerDescripcion { get; set; }

        public virtual MstSucursal FerIdSucursalNavigation { get; set; }
    }
}
