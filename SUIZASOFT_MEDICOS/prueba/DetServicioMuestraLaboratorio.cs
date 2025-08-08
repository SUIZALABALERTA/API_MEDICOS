using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetServicioMuestraLaboratorio
    {
        public int SemId { get; set; }
        public int SemIdServicio { get; set; }
        public int SemIdMuestra { get; set; }
        public bool? SemEstado { get; set; }
        public string SemUsuarioRegistro { get; set; }
        public DateTime? SemFechaRegistro { get; set; }
        public string SemUsuarioModificacion { get; set; }
        public DateTime? SemFechaModificacion { get; set; }
        public bool? SemFlagPerfil { get; set; }

        public virtual TipMuestraLaboratorio SemIdMuestraNavigation { get; set; }
    }
}
