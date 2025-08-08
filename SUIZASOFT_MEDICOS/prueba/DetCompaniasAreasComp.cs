using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetCompaniasAreasComp
    {
        public DetCompaniasAreasComp()
        {
            MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
        }

        public int DcacId { get; set; }
        public int DcacIdCompania { get; set; }
        public int DcacIdAreaCompania { get; set; }
        public string DcacUsuarioCreacion { get; set; }
        public DateTime DcacFechaCreacion { get; set; }

        public virtual MstAreaCompania DcacIdAreaCompaniaNavigation { get; set; }
        public virtual MstCompanium DcacIdCompaniaNavigation { get; set; }
        public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
    }
}
