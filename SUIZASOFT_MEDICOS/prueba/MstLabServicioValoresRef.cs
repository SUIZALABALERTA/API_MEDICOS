using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabServicioValoresRef
    {
        public int SevId { get; set; }
        public int SevIdServicio { get; set; }
        public short SevIdGrupoEtnico { get; set; }
        public short SevIdFisiologico { get; set; }
        public string SevMetodo { get; set; }
        public string SevLiteral { get; set; }
        public short SevPeriodoInicial { get; set; }
        public short SevUnidadEdadMinima { get; set; }
        public short SevPeriodoFinal { get; set; }
        public short SevUnidadEdadMaxima { get; set; }
        public decimal SevNormalInferior { get; set; }
        public decimal SevNormalSuperior { get; set; }
        public bool SevEstado { get; set; }
        public string SevUsuarioCreacion { get; set; }
        public DateTime SevFechaCreacion { get; set; }
        public string SevUsuarioModificacion { get; set; }
        public DateTime? SevFechaModificacion { get; set; }

        public virtual TipFisiologicoInterface SevIdFisiologicoNavigation { get; set; }
        public virtual TipGrupoEtnicoInterface SevIdGrupoEtnicoNavigation { get; set; }
        public virtual MstServicio SevIdServicioNavigation { get; set; }
        public virtual TipUnidadEdadInterface SevUnidadEdadMaximaNavigation { get; set; }
        public virtual TipUnidadEdadInterface SevUnidadEdadMinimaNavigation { get; set; }
    }
}
