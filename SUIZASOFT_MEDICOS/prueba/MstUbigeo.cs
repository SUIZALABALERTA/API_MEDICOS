using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstUbigeo
    {
        public MstUbigeo()
        {
            DetCompaniaSucursals = new HashSet<DetCompaniaSucursal>();
            MstCompania = new HashSet<MstCompanium>();
            MstMedicoMedIdUbigeoConsultorioNavigations = new HashSet<MstMedico>();
            MstMedicoMedIdUbigeoNavigations = new HashSet<MstMedico>();
            MstPacientes = new HashSet<MstPaciente>();
            MstPromotors = new HashSet<MstPromotor>();
        }

        public int UbiId { get; set; }
        public string UbiCodigoDepartamento { get; set; }
        public string UbiNombreDepartamento { get; set; }
        public string UbiCodigoProvincia { get; set; }
        public string UbiNombreProvincia { get; set; }
        public string UbiCodigoDistrito { get; set; }
        public string UbiNombreDistrito { get; set; }
        public bool? UbiEstado { get; set; }

        public virtual ICollection<DetCompaniaSucursal> DetCompaniaSucursals { get; set; }
        public virtual ICollection<MstCompanium> MstCompania { get; set; }
        public virtual ICollection<MstMedico> MstMedicoMedIdUbigeoConsultorioNavigations { get; set; }
        public virtual ICollection<MstMedico> MstMedicoMedIdUbigeoNavigations { get; set; }
        public virtual ICollection<MstPaciente> MstPacientes { get; set; }
        public virtual ICollection<MstPromotor> MstPromotors { get; set; }
    }
}
