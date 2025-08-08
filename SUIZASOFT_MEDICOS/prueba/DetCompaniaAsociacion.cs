using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetCompaniaAsociacion
    {
        public int DcaCompaniaPrimaria { get; set; }
        public int DcaCompaniaSecundaria { get; set; }
        public string DcaUsuarioCreacion { get; set; }
        public DateTime? DcaFechaCreacion { get; set; }
        public bool? DcaEstado { get; set; }
        public string DcaUsuarioModificacion { get; set; }
        public DateTime? DcaFechaModificacion { get; set; }

        public virtual MstCompanium DcaCompaniaPrimariaNavigation { get; set; }
        public virtual MstCompanium DcaCompaniaSecundariaNavigation { get; set; }
    }
}
