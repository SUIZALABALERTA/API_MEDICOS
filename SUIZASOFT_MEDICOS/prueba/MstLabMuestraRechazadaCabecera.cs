using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabMuestraRechazadaCabecera
    {
        public MstLabMuestraRechazadaCabecera()
        {
            DetLabMuestraRechazadaDetalles = new HashSet<DetLabMuestraRechazadaDetalle>();
            DetLabMuestraRechazadaImagens = new HashSet<DetLabMuestraRechazadaImagen>();
            DetLabMuestraRechazadaMsjs = new HashSet<DetLabMuestraRechazadaMsj>();
        }

        public int MurIdMueRechazada { get; set; }
        public string MurYearorden { get; set; }
        public int? MurTicketIdCabecera { get; set; }
        public string MurPeriodo { get; set; }
        public string MurAnio { get; set; }
        public string MurTicketIdSucursal { get; set; }
        public string MurIdSucursal { get; set; }
        public int? MurIdCompania { get; set; }
        public bool? MurEstado { get; set; }
        public string MurUsuarioRegistro { get; set; }
        public DateTime? MurFechaRegistro { get; set; }
        public string MurUsuarioModificacion { get; set; }
        public DateTime? MurFechaModificacion { get; set; }
        public string MurUsuarioAnulacion { get; set; }
        public DateTime? MurFechaAnulacion { get; set; }
        public string MurMotivoAnulacion { get; set; }
        public bool? MurFlagCerrado { get; set; }
        public string MurPaciente { get; set; }

        public virtual MstCompanium MurIdCompaniaNavigation { get; set; }
        public virtual MstOrdenServicioCabecera MurYearordenNavigation { get; set; }
        public virtual ICollection<DetLabMuestraRechazadaDetalle> DetLabMuestraRechazadaDetalles { get; set; }
        public virtual ICollection<DetLabMuestraRechazadaImagen> DetLabMuestraRechazadaImagens { get; set; }
        public virtual ICollection<DetLabMuestraRechazadaMsj> DetLabMuestraRechazadaMsjs { get; set; }
    }
}
