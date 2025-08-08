using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetServicioResultado
    {
        public int SrIdServicio { get; set; }
        public int SrIdCatalogo { get; set; }
        public string SrUsuarioCreacion { get; set; }
        public DateTime SrFechaCreacion { get; set; }

        public virtual MstCatalogoResultado SrIdCatalogoNavigation { get; set; }
        public virtual MstServicio SrIdServicioNavigation { get; set; }
    }
}
