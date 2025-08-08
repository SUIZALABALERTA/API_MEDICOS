using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetMedicoSede
    {
        public int DmsId { get; set; }
        public int? DmsIdMedico { get; set; }
        public string DmsIdSede { get; set; }
        public string DmsUsuarioCreacion { get; set; }
        public DateTime? DmsFechaCreacion { get; set; }
        public string DmsUsuarioModificacion { get; set; }
        public DateTime? DmsFechaModificacion { get; set; }
        public bool? DmsEstado { get; set; }

        public virtual MstMedico DmsIdMedicoNavigation { get; set; }
        public virtual MstSucursal DmsIdSedeNavigation { get; set; }
    }
}
