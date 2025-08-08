using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipServicioAreaLaboratorioBak
    {
        public TipServicioAreaLaboratorioBak()
        {
            MstSeccionLaboratorios = new HashSet<MstSeccionLaboratorio>();
            MstTipoLaboratorios = new HashSet<MstTipoLaboratorio>();
        }

        public int AreId { get; set; }
        public string AreDescripcion { get; set; }
        public bool? AreEstado { get; set; }

        public virtual ICollection<MstSeccionLaboratorio> MstSeccionLaboratorios { get; set; }
        public virtual ICollection<MstTipoLaboratorio> MstTipoLaboratorios { get; set; }
    }
}
