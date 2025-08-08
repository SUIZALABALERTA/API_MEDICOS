using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTopicoEscaneo
    {
        public MstTopicoEscaneo()
        {
            DetTopicoMuestras = new HashSet<DetTopicoMuestra>();
        }

        public int ToeId { get; set; }
        public int ToeIdTipoIngreso { get; set; }
        public string ToeNombrePaciente { get; set; }
        public string ToeOrdenServicio { get; set; }
        public string ToeObservacion { get; set; }
        public string ToeUsuarioCreacion { get; set; }
        public DateTime? ToeFechaCreacion { get; set; }
        public string ToeDireccionIpRegistro { get; set; }
        public string ToeYearOrden { get; set; }

        public virtual TipTopicoIngreso ToeIdTipoIngresoNavigation { get; set; }
        public virtual ICollection<DetTopicoMuestra> DetTopicoMuestras { get; set; }
    }
}
