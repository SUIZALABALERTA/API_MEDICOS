using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstBitacoraAtencionAuditorium
    {
        public int TrauId { get; set; }
        public int TrauOrdIdNumeroCab { get; set; }
        public string TrauOrdPeriodo { get; set; }
        public string TrauOrdAnio { get; set; }
        public string TrauOrdIdSucursal { get; set; }
        public int TrauOrdItem { get; set; }
        public int TrauIdServicio { get; set; }
        public short TrauIdBitacoraAccion { get; set; }
        public int TrauIdMedico { get; set; }
        public int TrauIdRol { get; set; }
        public string TrauMensaje { get; set; }
        public bool TrauEstado { get; set; }
        public string TrauUsuarioCreacion { get; set; }
        public DateTime TrauFechaCreacion { get; set; }
        public string TrauUsuarioModificacion { get; set; }
        public DateTime? TrauFechaModificacion { get; set; }

        public virtual TipAccionBitacora TrauIdBitacoraAccionNavigation { get; set; }
        public virtual MstMedico TrauIdMedicoNavigation { get; set; }
        public virtual MstRolCentroMedico TrauIdRolNavigation { get; set; }
        public virtual MstServicio TrauIdServicioNavigation { get; set; }
        public virtual DetOrdenServicioDetalle TrauOrd { get; set; }
    }
}
