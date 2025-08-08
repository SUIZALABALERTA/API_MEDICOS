using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabBiopsium
    {
        public int LabId { get; set; }
        public int LabIdTicket { get; set; }
        public string LabPeriodoTicket { get; set; }
        public string LabAnioTicket { get; set; }
        public string LabSucursalTicket { get; set; }
        public bool? PerEstado { get; set; }
        public string LabMotivoAnulacion { get; set; }
        public string LabFechaAnulacion { get; set; }
        public string LabMuestra { get; set; }
        public string LabRegistro { get; set; }
        public string LabDescripcionMacroscopica { get; set; }
        public string LabDescripcionMicroscopica { get; set; }
        public string LabRutaImagen1 { get; set; }
        public string LabRutaImagen2 { get; set; }
        public string LabRutaImagen3 { get; set; }
        public bool? LabHallazgo { get; set; }
        public string LabUsuarioRegistro { get; set; }
        public DateTime? LabFechaRegistro { get; set; }
        public string LabUsuarioModificacion { get; set; }
        public DateTime? LabFechaModificacion { get; set; }
    }
}
