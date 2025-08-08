using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstModalidad
    {
        public MstModalidad()
        {
            DetComModTarPaqs = new HashSet<DetComModTarPaq>();
            MstFacturaCabeceras = new HashSet<MstFacturaCabecera>();
            MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
            MstPaqueteCabeceras = new HashSet<MstPaqueteCabecera>();
            MstPreticketCabeceras = new HashSet<MstPreticketCabecera>();
            MstPromotors = new HashSet<MstPromotor>();
            MstSucursalModalidads = new HashSet<MstSucursalModalidad>();
            MstTarifarios = new HashSet<MstTarifario>();
            MstTipoModalidads = new HashSet<MstTipoModalidad>();
        }

        public int ModId { get; set; }
        public string ModDescripcion { get; set; }
        public bool? ModEstado { get; set; }
        public bool? ModComision { get; set; }
        public bool? ModComisionPreventiva { get; set; }

        public virtual ICollection<DetComModTarPaq> DetComModTarPaqs { get; set; }
        public virtual ICollection<MstFacturaCabecera> MstFacturaCabeceras { get; set; }
        public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
        public virtual ICollection<MstPaqueteCabecera> MstPaqueteCabeceras { get; set; }
        public virtual ICollection<MstPreticketCabecera> MstPreticketCabeceras { get; set; }
        public virtual ICollection<MstPromotor> MstPromotors { get; set; }
        public virtual ICollection<MstSucursalModalidad> MstSucursalModalidads { get; set; }
        public virtual ICollection<MstTarifario> MstTarifarios { get; set; }
        public virtual ICollection<MstTipoModalidad> MstTipoModalidads { get; set; }
    }
}
