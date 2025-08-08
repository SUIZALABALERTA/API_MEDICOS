using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstUsuarioSerie
    {
        public int UseId { get; set; }
        public string UseUid { get; set; }
        public string UseUsername { get; set; }
        public int? UseIdAgenteSerie { get; set; }
        public bool? UseEstado { get; set; }
        public string UseUsuarioCreacion { get; set; }
        public DateTime? UseFechaCreacion { get; set; }
        public string UseUsuarioModificacion { get; set; }
        public DateTime? UseFechaModificacion { get; set; }

        public virtual MstAgenteSerie UseIdAgenteSerieNavigation { get; set; }
    }
}
