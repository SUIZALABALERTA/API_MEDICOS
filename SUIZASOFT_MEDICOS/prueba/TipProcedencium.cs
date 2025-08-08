using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipProcedencium
    {
        public TipProcedencium()
        {
            MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
        }

        public int ProId { get; set; }
        public string ProDescripcion { get; set; }
        public bool ProEstado { get; set; }
        public string ProUsuarioCreacion { get; set; }
        public DateTime? ProFechaCreacion { get; set; }
        public string ProUsuarioModificacion { get; set; }
        public DateTime? ProFechaModificacion { get; set; }

        public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
    }
}
