using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabPerfilServicio
    {
        public int PesIdPerfil { get; set; }
        public int PesIdServicio { get; set; }
        public int PesLisId { get; set; }
        public string PesUsuarioRegistro { get; set; }
        public DateTime? PesFechaRegistro { get; set; }
        public string PesUsuarioModificacion { get; set; }
        public DateTime? PesFechaModificacion { get; set; }
        public bool? PesEstado { get; set; }
        public bool? PesFlagPerfil { get; set; }
        public string PesExaCodigoAnterior { get; set; }
        public int? PesIndex { get; set; }

        public virtual MstLabPerfil PesIdPerfilNavigation { get; set; }
        public virtual MstServicio PesIdServicioNavigation { get; set; }
        public virtual MstLisProveedor PesLis { get; set; }
    }
}
