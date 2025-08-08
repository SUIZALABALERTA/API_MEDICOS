using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTarifarioCategorium
    {
        public int TacIdTarifa { get; set; }
        public int TacIdServicio { get; set; }
        public string TacTarifa { get; set; }
        public string TacObservacion { get; set; }
        public decimal? TacPretarifa { get; set; }
        public bool? TacEstado { get; set; }
        public decimal? TacValorUnitarioSinigv { get; set; }
        public string TacUsuarioRegistro { get; set; }
        public DateTime? TacFechaRegistro { get; set; }
        public string TacUsuarioModificacion { get; set; }
        public DateTime? TacFechaModificacion { get; set; }

        public virtual MstServicio TacIdServicioNavigation { get; set; }
        public virtual MstTarifario TacIdTarifaNavigation { get; set; }
    }
}
