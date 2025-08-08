using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTarifario
    {
        public MstTarifario()
        {
            DetComModTarPaqs = new HashSet<DetComModTarPaq>();
            MstTarifarioCategoria = new HashSet<MstTarifarioCategorium>();
            MstTarifarioPaquetes = new HashSet<MstTarifarioPaquete>();
            MstTarifarioPerfils = new HashSet<MstTarifarioPerfil>();
        }

        public int TarId { get; set; }
        public string TarDescripcion { get; set; }
        public bool? TarEstado { get; set; }
        public string TarObservacion { get; set; }
        public string TarUsuarioRegistro { get; set; }
        public DateTime? TarFechaRegistro { get; set; }
        public string TarUsuarioModificacion { get; set; }
        public DateTime? TarFechaModificacion { get; set; }
        public string TarCodigoAnterior { get; set; }
        public int? TarIdModalidad { get; set; }

        public virtual MstModalidad TarIdModalidadNavigation { get; set; }
        public virtual ICollection<DetComModTarPaq> DetComModTarPaqs { get; set; }
        public virtual ICollection<MstTarifarioCategorium> MstTarifarioCategoria { get; set; }
        public virtual ICollection<MstTarifarioPaquete> MstTarifarioPaquetes { get; set; }
        public virtual ICollection<MstTarifarioPerfil> MstTarifarioPerfils { get; set; }
    }
}
