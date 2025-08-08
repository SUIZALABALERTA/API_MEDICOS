using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public partial class MstRolCentroMedico
{
    public MstRolCentroMedico()
    {
        XMedicoRolCentroMedico = new HashSet<DetMedicoRolCentroMedico>();
    }

    public int RolCmId { get; set; }

    public string RolCmDescripcion { get; set; }

    public bool RolCmEstado { get; set; }

    public virtual ICollection<DetMedicoRolCentroMedico> XMedicoRolCentroMedico { get; set; }
}
