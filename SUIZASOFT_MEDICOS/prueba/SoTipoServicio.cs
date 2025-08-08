using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class SoTipoServicio
    {
        public SoTipoServicio()
        {
            DetServicioSedeFechas = new HashSet<DetServicioSedeFecha>();
            DetServicioSedes = new HashSet<DetServicioSede>();
            MstCitaParticulars = new HashSet<MstCitaParticular>();
        }

        public int TseId { get; set; }
        public string TseNombre { get; set; }
        public bool? TseEstado { get; set; }

        public virtual ICollection<DetServicioSedeFecha> DetServicioSedeFechas { get; set; }
        public virtual ICollection<DetServicioSede> DetServicioSedes { get; set; }
        public virtual ICollection<MstCitaParticular> MstCitaParticulars { get; set; }
    }
}
