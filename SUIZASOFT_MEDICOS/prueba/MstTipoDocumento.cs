using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTipoDocumento
    {
        public MstTipoDocumento()
        {
            MstCompania = new HashSet<MstCompanium>();
            MstFacturaCabeceras = new HashSet<MstFacturaCabecera>();
            MstMedicos = new HashSet<MstMedico>();
            MstNotaCreditoCabeceras = new HashSet<MstNotaCreditoCabecera>();
            MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
            MstPacientePacIdDocAltNavigations = new HashSet<MstPaciente>();
            MstPacientePacIdTipoDocumentoNavigations = new HashSet<MstPaciente>();
            MstPromotors = new HashSet<MstPromotor>();
        }

        public int TdoId { get; set; }
        public string TdoNombreDocumento { get; set; }
        public bool? TdoEstado { get; set; }
        public string TdoUsumod { get; set; }
        public string TdoNombreCorto { get; set; }
        public short? TdoFeCodDoc { get; set; }

        public virtual ICollection<MstCompanium> MstCompania { get; set; }
        public virtual ICollection<MstFacturaCabecera> MstFacturaCabeceras { get; set; }
        public virtual ICollection<MstMedico> MstMedicos { get; set; }
        public virtual ICollection<MstNotaCreditoCabecera> MstNotaCreditoCabeceras { get; set; }
        public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
        public virtual ICollection<MstPaciente> MstPacientePacIdDocAltNavigations { get; set; }
        public virtual ICollection<MstPaciente> MstPacientePacIdTipoDocumentoNavigations { get; set; }
        public virtual ICollection<MstPromotor> MstPromotors { get; set; }
    }
}
