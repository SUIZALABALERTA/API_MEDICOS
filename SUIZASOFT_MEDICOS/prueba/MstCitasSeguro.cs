using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstCitasSeguro
    {
        public int CisId { get; set; }
        public int? CisIdTicket { get; set; }
        public int? CisIdPaciente { get; set; }
        public DateTime? CisFechaCita { get; set; }
        public int? CisEstadoCita { get; set; }
        public string CisLugarCita { get; set; }
        public int? CisTipoServicio { get; set; }
        public int? CisIdSucursal { get; set; }
        public decimal? CisMonto { get; set; }
        public int? CisIdUbigeo { get; set; }
        public string CisDireccion { get; set; }
        public string CisReferencia { get; set; }
        public int? CisSexo { get; set; }
        public int? CisTipoDocumento { get; set; }
        public string CisNumeroDocumento { get; set; }
        public string CisObservacion { get; set; }
        public string CisTelefono1 { get; set; }
        public string CisTelefono2 { get; set; }
        public string CisUsuarioRegistro { get; set; }
        public DateTime? CisFechaRegistro { get; set; }
        public string CisUsuarioModificacion { get; set; }
        public DateTime? CisFechaModificacion { get; set; }
    }
}
