using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstPeriodoCredito
    {
        public MstPeriodoCredito()
        {
            MstCompania = new HashSet<MstCompanium>();
            MstFacturaCabeceras = new HashSet<MstFacturaCabecera>();
        }

        public int PcrId { get; set; }
        public string PcrDescripcion { get; set; }

        public virtual ICollection<MstCompanium> MstCompania { get; set; }
        public virtual ICollection<MstFacturaCabecera> MstFacturaCabeceras { get; set; }
    }
}
