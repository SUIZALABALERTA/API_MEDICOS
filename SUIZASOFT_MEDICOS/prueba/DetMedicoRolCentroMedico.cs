using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetMedicoRolCentroMedico
    {
        public int DmrCmIdRol { get; set; }
        public int DmrCmIdMedico { get; set; }
        public bool DcmEstado { get; set; }
        public string DcmUsuarioCreacion { get; set; }
        public DateTime DcmFechaCreacion { get; set; }
        public string DcmUsuarioModificacion { get; set; }
        public DateTime? DcmFechaModificacion { get; set; }

        public virtual MstMedico DmrCmIdMedicoNavigation { get; set; }
        public virtual MstRolCentroMedico DmrCmIdRolNavigation { get; set; }
    }
}
