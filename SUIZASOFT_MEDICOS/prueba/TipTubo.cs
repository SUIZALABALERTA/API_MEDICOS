using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipTubo
    {
        public TipTubo()
        {
            MstLabPerfils = new HashSet<MstLabPerfil>();
            MstServicios = new HashSet<MstServicio>();
            TipMuestraLaboratorios = new HashSet<TipMuestraLaboratorio>();
        }

        public int TubId { get; set; }
        public string TubDescripcion { get; set; }
        public string TubCodigoAnterior { get; set; }
        public bool? TubEstado { get; set; }

        public virtual ICollection<MstLabPerfil> MstLabPerfils { get; set; }
        public virtual ICollection<MstServicio> MstServicios { get; set; }
        public virtual ICollection<TipMuestraLaboratorio> TipMuestraLaboratorios { get; set; }
    }
}
