using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstTokenPaciente
    {
        /// <summary>
        /// id_paciente
        /// </summary>
        public int? MtpPacId { get; set; }
        /// <summary>
        /// pk
        /// </summary>
        public int MtpId { get; set; }
        public string MtpToken { get; set; }
        public DateOnly? MtpFechaExpiracion { get; set; }
        public DateOnly? MtpFechaCreacion { get; set; }
        public DateOnly? MtpRevoked { get; set; }

        public virtual MstPaciente MtpPac { get; set; }
    }
}
