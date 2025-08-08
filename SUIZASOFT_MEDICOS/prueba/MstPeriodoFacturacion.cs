using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstPeriodoFacturacion
    {
        public MstPeriodoFacturacion()
        {
            MstCompania = new HashSet<MstCompanium>();
        }

        public int PfaId { get; set; }
        public string PfaDescripcion { get; set; }
        public string PfaCodigoAnterior { get; set; }
        public bool? PfaEstado { get; set; }

        public virtual ICollection<MstCompanium> MstCompania { get; set; }
    }
}
