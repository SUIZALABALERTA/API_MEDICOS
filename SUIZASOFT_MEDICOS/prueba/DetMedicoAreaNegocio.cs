using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetMedicoAreaNegocio
    {
        public int DmanIdMedico { get; set; }
        public int DmanIdAreaNegocio { get; set; }
        public bool DmanEstado { get; set; }
        public string DmanUsuarioCreacion { get; set; }
        public DateTime DmanFechaCreacion { get; set; }
        public string DmanUsuarioModificacion { get; set; }
        public DateTime? DmanFechaModificacion { get; set; }

        public virtual MstServicioAreaNegocio DmanIdAreaNegocioNavigation { get; set; }
        public virtual MstMedico DmanIdMedicoNavigation { get; set; }
    }
}
