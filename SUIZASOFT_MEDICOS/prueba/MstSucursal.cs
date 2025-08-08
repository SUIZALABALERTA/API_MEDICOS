using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstSucursal
    {
        public MstSucursal()
        {
            DetMedicoHorarios = new HashSet<DetMedicoHorario>();
            DetMedicoSedes = new HashSet<DetMedicoSede>();
            DetNotaCreditoDetalles = new HashSet<DetNotaCreditoDetalle>();
            DetServicioSedeFechas = new HashSet<DetServicioSedeFecha>();
            DetServicioSedes = new HashSet<DetServicioSede>();
            MstAgenteSeries = new HashSet<MstAgenteSerie>();
            MstCitaParticulars = new HashSet<MstCitaParticular>();
            MstFacturaCabeceras = new HashSet<MstFacturaCabecera>();
            MstFeriados = new HashSet<MstFeriado>();
            MstLabOrdenEscaneos = new HashSet<MstLabOrdenEscaneo>();
            MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
            MstPreticketCabeceras = new HashSet<MstPreticketCabecera>();
            MstSucursalModalidads = new HashSet<MstSucursalModalidad>();
        }

        public string SucId { get; set; }
        public string SucNombreLargo { get; set; }
        public string SucNombreCorto { get; set; }
        public string SucDireccion { get; set; }
        public string SucTelefono { get; set; }
        public bool? SucEnvioSap { get; set; }
        public string SucCodigoSucursal { get; set; }
        public bool? SucEstado { get; set; }
        public int? SucUsuarioRegistro { get; set; }
        public DateTime? SucFechaRegistro { get; set; }
        public int? SucUsuarioModificacion { get; set; }
        public DateTime? SucFechaModificacion { get; set; }
        public string SucUbigeo { get; set; }
        public string SucCodigoSap { get; set; }

        public virtual ICollection<DetMedicoHorario> DetMedicoHorarios { get; set; }
        public virtual ICollection<DetMedicoSede> DetMedicoSedes { get; set; }
        public virtual ICollection<DetNotaCreditoDetalle> DetNotaCreditoDetalles { get; set; }
        public virtual ICollection<DetServicioSedeFecha> DetServicioSedeFechas { get; set; }
        public virtual ICollection<DetServicioSede> DetServicioSedes { get; set; }
        public virtual ICollection<MstAgenteSerie> MstAgenteSeries { get; set; }
        public virtual ICollection<MstCitaParticular> MstCitaParticulars { get; set; }
        public virtual ICollection<MstFacturaCabecera> MstFacturaCabeceras { get; set; }
        public virtual ICollection<MstFeriado> MstFeriados { get; set; }
        public virtual ICollection<MstLabOrdenEscaneo> MstLabOrdenEscaneos { get; set; }
        public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
        public virtual ICollection<MstPreticketCabecera> MstPreticketCabeceras { get; set; }
        public virtual ICollection<MstSucursalModalidad> MstSucursalModalidads { get; set; }
    }
}
