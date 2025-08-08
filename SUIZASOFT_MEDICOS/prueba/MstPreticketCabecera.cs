using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstPreticketCabecera
    {
        public int PrcId { get; set; }
        public string PrcPeriodo { get; set; }
        public string PrcAnio { get; set; }
        public string PrcIdSucursal { get; set; }
        public int? PrcIdEstado { get; set; }
        public decimal? PrcTipoCambio { get; set; }
        public int? PrcIdCompania { get; set; }
        public int? PrcIdPaciente { get; set; }
        public int? PrcIdTarifa { get; set; }
        public int? PrcIdEmpresaCompania { get; set; }
        public string PrcMotivoAnulacion { get; set; }
        public DateOnly? PrcFechaAnulacion { get; set; }
        public int? PrcIdMedico { get; set; }
        public decimal? PrcTotalGravado { get; set; }
        public decimal? PrcTotalDebe { get; set; }
        public decimal? PrcTotalHaber { get; set; }
        public decimal? PrcTotalAcuenta { get; set; }
        public string PrcObservacion { get; set; }
        public decimal? PrcTotalSolesLetra { get; set; }
        public bool? PrcFlagPaquete { get; set; }
        public string PrcOrdenNumero { get; set; }
        public int? PrcIdPaquete { get; set; }
        public decimal? PrcDescuentoTotal { get; set; }
        public decimal? PrsSubTotal { get; set; }
        public string PrcIpIngreso { get; set; }
        public string PrcIpModificacion { get; set; }
        public string PrcIpAnulacion { get; set; }
        public string PrcUsuarioRegistro { get; set; }
        public DateTime? PrcFechaRegistro { get; set; }
        public string PrcUsuarioModificacion { get; set; }
        public DateTime? PrcFechaModificacion { get; set; }
        public int? PrcIdModalidad { get; set; }
        public decimal? PrcFranquicia { get; set; }
        public decimal? PrcSaldo { get; set; }
        public decimal? PrcTotalVenta { get; set; }
        public decimal? PrcImporteTotal { get; set; }
        public decimal? PrcTotalIgv { get; set; }
        public decimal? PrcTotal { get; set; }
        public int? PrcIdMoneda { get; set; }
        public int? PrcIdCompaniaAsociada { get; set; }
        public string PrcCargo { get; set; }
        public string PrcArea { get; set; }
        public string PrcSede { get; set; }
        public DateTime? PrcFechaAtencion { get; set; }

        public virtual MstCompanium PrcIdCompaniaAsociadaNavigation { get; set; }
        public virtual MstCompanium PrcIdCompaniaNavigation { get; set; }
        public virtual EstTicket PrcIdEstadoNavigation { get; set; }
        public virtual MstMedico PrcIdMedicoNavigation { get; set; }
        public virtual MstModalidad PrcIdModalidadNavigation { get; set; }
        public virtual MstMonedum PrcIdMonedaNavigation { get; set; }
        public virtual MstPaciente PrcIdPacienteNavigation { get; set; }
        public virtual MstSucursal PrcIdSucursalNavigation { get; set; }
    }
}
