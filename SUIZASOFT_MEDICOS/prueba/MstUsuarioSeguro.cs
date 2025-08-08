using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstUsuarioSeguro
    {
        public int UssId { get; set; }
        public string UssContrasena { get; set; }
        public string UssNombre { get; set; }
        public string UssCorreo { get; set; }
        public bool? UssEstado { get; set; }
        public string[] UssPerfil { get; set; }
        public string UssUsuarioRegistro { get; set; }
        public DateTime? UssFechaRegistro { get; set; }
        public string UssUsuarioModificacion { get; set; }
        public DateTime? UssFechaModificacion { get; set; }
        public string UssRefreshToken { get; set; }
    }
}
