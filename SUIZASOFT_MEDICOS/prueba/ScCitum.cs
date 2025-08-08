using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class ScCitum
    {
        public int CitId { get; set; }
        public string CitCodigo { get; set; }
        public int? CitCchId { get; set; }
        public int? CitPacId { get; set; }
        public int? CitEstado { get; set; }
        public DateTime? CitFechaCreacion { get; set; }

        public virtual ScCupoHorario CitCch { get; set; }
        public virtual MstPaciente CitCchNavigation { get; set; }
    }
}
