using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetCompaniaSucursal
    {
        public int CsuId { get; set; }
        public int CsuIdCompania { get; set; }
        public string CsuRucCompania { get; set; }
        public string CsuNombreSucursal { get; set; }
        public string CsuDireccionSucursal { get; set; }
        public string CsuReferenciaSucursal { get; set; }
        public int? CsuIdUbigeoSucursal { get; set; }
        public string CsuTelefonoContacto { get; set; }
        public string CsuNombreCobranzas { get; set; }
        public string CsuCargoCobranzas { get; set; }
        public string CsuTelefonoCobranzas { get; set; }
        public string CsuEmailCobranzas { get; set; }
        public string CsuNombreComercial { get; set; }
        public string CsuCargoComercial { get; set; }
        public string CsuTelefonoComercial { get; set; }
        public string CsuEmailComercial { get; set; }
        public string CsuNombreFacturacion { get; set; }
        public string CsuCargoFacturacion { get; set; }
        public string CsuTelefonoFacturacion { get; set; }
        public string CsuEmailFacturacion { get; set; }
        public string CsuDistritoRecojoMotorizado { get; set; }
        public string CsuNombreMotorizado { get; set; }
        public string CsuTelefonoMotorizado { get; set; }
        public bool? CsuEstado { get; set; }
        public string CsuUsuarioCreacion { get; set; }
        public DateTime? CsuFechaCreacion { get; set; }
        public string CsuUsuarioModificacion { get; set; }
        public DateTime? CsuFechaModificacion { get; set; }

        public virtual MstCompanium CsuIdCompaniaNavigation { get; set; }
        public virtual MstUbigeo CsuIdUbigeoSucursalNavigation { get; set; }
    }
}
