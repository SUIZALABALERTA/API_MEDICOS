using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTipoEvaluacion
    {
        public MstTipoEvaluacion()
        {
            MstPaqueteCabeceras = new HashSet<MstPaqueteCabecera>();
        }

        public int TieId { get; set; }
        public string TieDescripcion { get; set; }
        public bool? TieEstado { get; set; }

        public virtual ICollection<MstPaqueteCabecera> MstPaqueteCabeceras { get; set; }
    }
}
