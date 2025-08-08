using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class TipMuestraLaboratorio
    {
        public TipMuestraLaboratorio()
        {
            DetLabMuestraRechazadaDetalles = new HashSet<DetLabMuestraRechazadaDetalle>();
            DetServicioMuestraLaboratorios = new HashSet<DetServicioMuestraLaboratorio>();
            DetTopicoMuestras = new HashSet<DetTopicoMuestra>();
            DetTopicoPreScaneos = new HashSet<DetTopicoPreScaneo>();
            LabOrdenMuestras = new HashSet<LabOrdenMuestra>();
        }

        public int MueId { get; set; }
        public string MueDescripcion { get; set; }
        public string MueCodigoAnterior { get; set; }
        public bool? MueEstado { get; set; }
        public int? MueIdTubo { get; set; }
        public int? MueIdContenedor { get; set; }

        public virtual TipContenedor MueIdContenedorNavigation { get; set; }
        public virtual TipTubo MueIdTuboNavigation { get; set; }
        public virtual ICollection<DetLabMuestraRechazadaDetalle> DetLabMuestraRechazadaDetalles { get; set; }
        public virtual ICollection<DetServicioMuestraLaboratorio> DetServicioMuestraLaboratorios { get; set; }
        public virtual ICollection<DetTopicoMuestra> DetTopicoMuestras { get; set; }
        public virtual ICollection<DetTopicoPreScaneo> DetTopicoPreScaneos { get; set; }
        public virtual ICollection<LabOrdenMuestra> LabOrdenMuestras { get; set; }
    }
}
