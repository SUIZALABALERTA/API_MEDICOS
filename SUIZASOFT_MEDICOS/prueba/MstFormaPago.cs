using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstFormaPago
    {
        public MstFormaPago()
        {
            MstCompania = new HashSet<MstCompanium>();
            MstFacturaCabeceras = new HashSet<MstFacturaCabecera>();
        }

        public int FpaId { get; set; }
        public string FpaDescripcion { get; set; }
        public string FpaCodigoAnterior { get; set; }
        public bool? FpaEstado { get; set; }
        public string FpaGrupoSap { get; set; }

        public virtual ICollection<MstCompanium> MstCompania { get; set; }
        public virtual ICollection<MstFacturaCabecera> MstFacturaCabeceras { get; set; }
    }
}
