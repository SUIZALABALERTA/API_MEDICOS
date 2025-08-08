using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class SoMedicoCitaHorario
    {
        public int MchId { get; set; }
        public int? MchIdMedico { get; set; }
        public DateOnly? MchFecha { get; set; }
        public TimeOnly? MchHora { get; set; }
        public string MchUsuarioCreacion { get; set; }
        public DateTime? MchFechaCreacion { get; set; }
        public string MchDia { get; set; }
        public char MchEstado { get; set; }

        public virtual MstMedico MchIdMedicoNavigation { get; set; }
    }
}
