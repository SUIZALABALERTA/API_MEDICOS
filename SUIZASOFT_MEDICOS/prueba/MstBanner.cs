using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstBanner
    {
        public int BanId { get; set; }
        public string BanRutaImage { get; set; }
        public string BanDestino { get; set; }
        public string BanTextoAlternativo { get; set; }
        public string BanTitulo { get; set; }
        public string BanDescripcion { get; set; }
        public string BanUsuarioCreacion { get; set; }
        public DateTime? BanFechaCreacion { get; set; }
        public string BanUsuarioModificacion { get; set; }
        public DateTime? BanFechaModificacion { get; set; }
        public bool? BanEstado { get; set; }
        public string BanRutaLogo { get; set; }
        public string BanNameItem { get; set; }
        public string BanTipo { get; set; }
    }
}
