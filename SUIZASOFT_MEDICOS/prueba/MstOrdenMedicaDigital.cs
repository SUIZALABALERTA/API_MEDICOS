using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstOrdenMedicaDigital
    {
        public int OmdId { get; set; }
        public string OmdPeriodo { get; set; }
        public string OmdAnio { get; set; }
        public string OmdSucId { get; set; }
        public string OmdOrsTicket { get; set; }
        public int OmdMedId { get; set; }
        public int OmdPacId { get; set; }
        public int OmdPacEdad { get; set; }
        public string OmdPacCip { get; set; }
        public int? OmdParId { get; set; }
        public string OmdNroHistoria { get; set; }
        public string OmdCodigoOnconaval { get; set; }
        public int? OmdTaaId { get; set; }
        public int? OmdTprId { get; set; }
        public string OmdConsultorio { get; set; }
        public string OmdCama { get; set; }
        public int? OmdCantidadPruebas { get; set; }
        public int? OmdVigenciaId { get; set; }
        public string OmdObservaciones { get; set; }
        public bool? OmdEstado { get; set; }
        public DateTime? OmdFechaCreacion { get; set; }
        public DateTime? OmdFechaModificacion { get; set; }
    }
}
