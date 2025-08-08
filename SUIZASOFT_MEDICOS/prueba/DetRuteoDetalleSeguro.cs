using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetRuteoDetalleSeguro
    {
        public int RudIdRuteoCabecera { get; set; }
        public int? RudIdMedico { get; set; }
        public TimeOnly? RudHoraInicio { get; set; }
        public TimeOnly? RudHoraFin { get; set; }
        public int? RudIdCita { get; set; }
        public bool? RudEstado { get; set; }
        public string RudUsuarioRegistro { get; set; }
        public DateTime? RudFechaRegistro { get; set; }
        public string RudUsuarioModificacion { get; set; }
        public DateTime? RudFechaModificacion { get; set; }
    }
}
