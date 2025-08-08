using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetPerfilResultado
    {
        public int PrIdServicio { get; set; }
        public int PrIdCatalogo { get; set; }
        public string PrUsuarioCreacion { get; set; }
        public DateTime PrFechaCreacion { get; set; }

        public virtual MstCatalogoResultado PrIdCatalogoNavigation { get; set; }
        public virtual MstLabPerfil PrIdServicioNavigation { get; set; }
    }
}
