using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTarifarioPerfil
    {
        public int TapIdTarifa { get; set; }
        public int TapIdPerfil { get; set; }
        public string TapTarifa { get; set; }
        public string TapObservacion { get; set; }
        public decimal? TapPretarifa { get; set; }
        public bool? TapEstado { get; set; }
        public decimal? TapValorUnitarioSinigv { get; set; }
        public string TapUsuarioRegistro { get; set; }
        public DateTime? TapFechaRegistro { get; set; }
        public string TapUsuarioModificacion { get; set; }
        public DateTime? TapFechaModificacion { get; set; }

        public virtual MstLabPerfil TapIdPerfilNavigation { get; set; }
        public virtual MstTarifario TapIdTarifaNavigation { get; set; }
    }
}
