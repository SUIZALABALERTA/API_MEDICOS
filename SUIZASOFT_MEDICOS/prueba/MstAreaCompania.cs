using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstAreaCompania
    {
        public MstAreaCompania()
        {
            DetCompaniasAreasComps = new HashSet<DetCompaniasAreasComp>();
        }

        public int MacId { get; set; }
        public int MacIdCompania { get; set; }
        public string MacCodigo { get; set; }
        public string MacDescripcion { get; set; }
        public bool MacEstado { get; set; }
        public string MacUsuarioCreacion { get; set; }
        public DateTime MacFechaCreacion { get; set; }
        public string MacUsuarioModificacion { get; set; }
        public DateTime? MacFechaModificacion { get; set; }

        public virtual MstCompanium MacIdCompaniaNavigation { get; set; }
        public virtual ICollection<DetCompaniasAreasComp> DetCompaniasAreasComps { get; set; }
    }
}
