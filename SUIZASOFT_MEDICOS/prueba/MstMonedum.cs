using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstMonedum
    {
        public MstMonedum()
        {
            DetFacturaMedioPagos = new HashSet<DetFacturaMedioPago>();
            MstFacturaCabeceras = new HashSet<MstFacturaCabecera>();
            MstNotaCreditoCabeceras = new HashSet<MstNotaCreditoCabecera>();
            MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
            MstPaqueteCabeceras = new HashSet<MstPaqueteCabecera>();
            MstPreticketCabeceras = new HashSet<MstPreticketCabecera>();
        }

        public int MonId { get; set; }
        public string MonDescripcion { get; set; }
        public string MonAbreviatura { get; set; }

        public virtual ICollection<DetFacturaMedioPago> DetFacturaMedioPagos { get; set; }
        public virtual ICollection<MstFacturaCabecera> MstFacturaCabeceras { get; set; }
        public virtual ICollection<MstNotaCreditoCabecera> MstNotaCreditoCabeceras { get; set; }
        public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
        public virtual ICollection<MstPaqueteCabecera> MstPaqueteCabeceras { get; set; }
        public virtual ICollection<MstPreticketCabecera> MstPreticketCabeceras { get; set; }
    }
}
