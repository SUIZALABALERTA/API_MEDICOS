namespace Domain.Payloads
{
    public class CreateMedicoPayload
    {
        public int? IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string FechaNacimiento { get; set; }
        public int? IdSexo { get; set; }
        public string Direccion { get; set; }
        public string DireccionReferencia { get; set; }
        public int? IdUbigeo { get; set; }
        public string Correo { get; set; }
        public string TelefonoMovil { get; set; }
        public string TelefonoCasa { get; set; }
        public string FechaInscripcion { get; set; }
        public string ConsultorioDireccion { get; set; }
        public string ConsultorioReferencia { get; set; }
        public int? IdUbigeoConsultorio { get; set; }
        public string ColegioCodigo { get; set; }
        public int? IdColegioTipo { get; set; }
        public int? IdTipo { get; set; }
        public int? IdEspecialidad { get; set; }
        public int? IdPromotor { get; set; }
        public bool? AccesoWeb { get; set; }
        public string UsuarioWeb { get; set; }
        public string PasswordWeb { get; set; }
        public string ImageRuta { get; set; }
        public bool? Estado { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Doctoralia { get; set; }

    }
}
