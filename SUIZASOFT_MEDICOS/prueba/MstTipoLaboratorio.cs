using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTipoLaboratorio
    {
        public MstTipoLaboratorio()
        {
            MstSeccionLaboratorios = new HashSet<MstSeccionLaboratorio>();
        }

        public int TipId { get; set; }
        public int? TipAreId { get; set; }
        public string TipDescripcion { get; set; }
        public bool? TipEstado { get; set; }

        public virtual TipServicioAreaLaboratorioBak TipAre { get; set; }
        public virtual ICollection<MstSeccionLaboratorio> MstSeccionLaboratorios { get; set; }
    }
}
