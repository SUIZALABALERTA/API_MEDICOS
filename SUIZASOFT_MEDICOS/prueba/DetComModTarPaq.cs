using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetComModTarPaq
    {
        public int CmtpId { get; set; }
        public int? CmtpIdCompania { get; set; }
        public int? CmtpIdModalidad { get; set; }
        public int? CmtpIdTarifa { get; set; }
        public int? CmtpIdPaquete { get; set; }
        public string CmtpUsuarioCreacion { get; set; }
        public DateTime? CmtpFechaCreacion { get; set; }

        public virtual MstCompanium CmtpIdCompaniaNavigation { get; set; }
        public virtual MstModalidad CmtpIdModalidadNavigation { get; set; }
        public virtual MstPaqueteCabecera CmtpIdPaqueteNavigation { get; set; }
        public virtual MstTarifario CmtpIdTarifaNavigation { get; set; }
    }
}
