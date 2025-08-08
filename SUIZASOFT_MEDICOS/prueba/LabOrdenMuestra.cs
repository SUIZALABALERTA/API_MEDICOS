using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class LabOrdenMuestra
    {
        public string OrmYearorden { get; set; }
        public int OrmMueCodigo { get; set; }
        public string OrmOrdenNumero { get; set; }
        public string OrmUsuarioRegistro { get; set; }
        public DateTime? OrmFechaRegistro { get; set; }
        public string OrmUsuarioModificacion { get; set; }
        public DateTime? OrmFechaModificacion { get; set; }
        public bool? OrmEstado { get; set; }

        public virtual TipMuestraLaboratorio OrmMueCodigoNavigation { get; set; }
        public virtual MstOrdenServicioCabecera OrmYearordenNavigation { get; set; }
    }
}
