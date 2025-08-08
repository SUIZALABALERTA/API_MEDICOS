using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class ScCupoHorario
    {
        public ScCupoHorario()
        {
            ScCita = new HashSet<ScCitum>();
        }

        public int CchId { get; set; }
        public int? CchPfsId { get; set; }
        public int? CchMinutosAtencion { get; set; }
        public TimeOnly? CchHoraInicio { get; set; }
        public TimeOnly? CchHoraFin { get; set; }
        public DateTime? CchFechaCreacion { get; set; }
        public bool? CchReservado { get; set; }

        public virtual ScProgramacionFechaServicio CchPfs { get; set; }
        public virtual ICollection<ScCitum> ScCita { get; set; }
    }
}
