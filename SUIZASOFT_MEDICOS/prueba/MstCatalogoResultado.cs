using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstCatalogoResultado
    {
        public MstCatalogoResultado()
        {
            DetPerfilResultados = new HashSet<DetPerfilResultado>();
            DetServicioResultados = new HashSet<DetServicioResultado>();
        }

        public int CrId { get; set; }
        public string CrNombre { get; set; }
        public bool CrEstado { get; set; }
        public string CrUsuarioCreacion { get; set; }
        public DateTime CrFechaCreacion { get; set; }
        public string CrUsuarioModificacion { get; set; }
        public DateTime? CrFechaModificacion { get; set; }

        public virtual ICollection<DetPerfilResultado> DetPerfilResultados { get; set; }
        public virtual ICollection<DetServicioResultado> DetServicioResultados { get; set; }
    }
}
