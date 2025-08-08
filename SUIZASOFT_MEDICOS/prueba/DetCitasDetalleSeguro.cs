using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetCitasDetalleSeguro
    {
        public int CidId { get; set; }
        public int? CidIdCitas { get; set; }
        public int? CidIdServicio { get; set; }
        public bool? CidFlagPaquete { get; set; }
        public string CidRutaInforme { get; set; }
        public bool? CidEstado { get; set; }
        public string CidUsuarioRegistro { get; set; }
        public DateTime? CidFechaRegistro { get; set; }
        public string CidUsuarioModificacion { get; set; }
        public DateTime? CidFechaModificacion { get; set; }
    }
}
