using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipMedicoEspecialidad
    {
        public TipMedicoEspecialidad()
        {
            MstServicios = new HashSet<MstServicio>();
        }

        public int MesId { get; set; }
        public string MesNombre { get; set; }
        public string MesDescripcion { get; set; }
        public bool? MesEstado { get; set; }

        public virtual ICollection<MstServicio> MstServicios { get; set; }
    }
}
