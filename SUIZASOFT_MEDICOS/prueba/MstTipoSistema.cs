using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTipoSistema
    {
        public int TsiId { get; set; }
        public string TsiNombre { get; set; }
        public string TsiDescripcion { get; set; }
        public int TsiUsuarioCreacion { get; set; }
        public DateTime TsiFechaCreacion { get; set; }
        public int TsiUsuarioModificacion { get; set; }
        public DateTime TsiFechaModificacion { get; set; }
    }
}
