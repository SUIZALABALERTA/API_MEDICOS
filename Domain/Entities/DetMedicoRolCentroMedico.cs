using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public partial class DetMedicoRolCentroMedico
{
    public int IdRol { get; set; }

    public int IdMedico { get; set; }

    public bool Estado { get; set; }

    public string UsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string UsuarioModificacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual MstMedico XMedico { get; set; }

    public virtual MstRolCentroMedico XRol { get; set; }
}

