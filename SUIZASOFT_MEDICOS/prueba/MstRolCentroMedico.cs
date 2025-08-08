using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstRolCentroMedico
    {
        public MstRolCentroMedico()
        {
            DetMedicoRolCentroMedicos = new HashSet<DetMedicoRolCentroMedico>();
            MstBitacoraAtencionAuditoria = new HashSet<MstBitacoraAtencionAuditorium>();
        }

        public int RolCmId { get; set; }
        public string RolCmDescripcion { get; set; }
        public bool RolCmEstado { get; set; }

        public virtual ICollection<DetMedicoRolCentroMedico> DetMedicoRolCentroMedicos { get; set; }
        public virtual ICollection<MstBitacoraAtencionAuditorium> MstBitacoraAtencionAuditoria { get; set; }
    }
}
