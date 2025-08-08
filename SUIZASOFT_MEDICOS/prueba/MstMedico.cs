using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstMedico
    {
        public MstMedico()
        {
            DetMedicoAreaNegocios = new HashSet<DetMedicoAreaNegocio>();
            DetMedicoHorarios = new HashSet<DetMedicoHorario>();
            DetMedicoRolCentroMedicos = new HashSet<DetMedicoRolCentroMedico>();
            DetMedicoSedes = new HashSet<DetMedicoSede>();
            MstBitacoraAtencionAuditoria = new HashSet<MstBitacoraAtencionAuditorium>();
            MstCitaParticulars = new HashSet<MstCitaParticular>();
            MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
            MstPreticketCabeceras = new HashSet<MstPreticketCabecera>();
            ScProgramacionFechaServicios = new HashSet<ScProgramacionFechaServicio>();
            SoMedicoCitaHorarios = new HashSet<SoMedicoCitaHorario>();
        }

        public int MedId { get; set; }
        public int? MedIdTipoDocumento { get; set; }
        public string MedNumeroDocumento { get; set; }
        public string MedNombre { get; set; }
        public string MedApellidoPaterno { get; set; }
        public string MedApellidoMaterno { get; set; }
        public DateOnly? MedFechaNacimiento { get; set; }
        public int? MedIdSexo { get; set; }
        public string MedDireccion { get; set; }
        public string MedDireccionReferencia { get; set; }
        public int? MedIdUbigeo { get; set; }
        public string MedCorreo { get; set; }
        public string MedTelefonoMovil { get; set; }
        public string MedTelefonoCasa { get; set; }
        public DateTime? MedFechaInscripcion { get; set; }
        public string MedConsultorioDireccion { get; set; }
        public string MedConsultorioReferencia { get; set; }
        public int? MedIdUbigeoConsultorio { get; set; }
        public string MedColegioCodigo { get; set; }
        public int? MedIdColegioTipo { get; set; }
        public int? MedIdTipo { get; set; }
        public int? MedIdPromotor { get; set; }
        public bool? MedAccesoWeb { get; set; }
        public string MedUsuarioWeb { get; set; }
        public string MedPasswordWeb { get; set; }
        public string MedImageRuta { get; set; }
        public bool? MedEstado { get; set; }
        public string MedLinkedin { get; set; }
        public string MedTwitter { get; set; }
        public string MedDoctoralia { get; set; }
        public string MedUsuarioCreacion { get; set; }
        public DateTime? MedFechaCreacion { get; set; }
        public string MedUsuarioModificacion { get; set; }
        public DateTime? MedFechaModificacion { get; set; }
        public string MedNombreCompleto { get; set; }
        public string MedRne { get; set; }
        public string MedRna { get; set; }

        public virtual TipMedicoColegiatura MedIdColegioTipoNavigation { get; set; }
        public virtual MstPromotor MedIdPromotorNavigation { get; set; }
        public virtual MstSexo MedIdSexoNavigation { get; set; }
        public virtual MstTipoDocumento MedIdTipoDocumentoNavigation { get; set; }
        public virtual TipMedico MedIdTipoNavigation { get; set; }
        public virtual MstUbigeo MedIdUbigeoConsultorioNavigation { get; set; }
        public virtual MstUbigeo MedIdUbigeoNavigation { get; set; }
        public virtual ICollection<DetMedicoAreaNegocio> DetMedicoAreaNegocios { get; set; }
        public virtual ICollection<DetMedicoHorario> DetMedicoHorarios { get; set; }
        public virtual ICollection<DetMedicoRolCentroMedico> DetMedicoRolCentroMedicos { get; set; }
        public virtual ICollection<DetMedicoSede> DetMedicoSedes { get; set; }
        public virtual ICollection<MstBitacoraAtencionAuditorium> MstBitacoraAtencionAuditoria { get; set; }
        public virtual ICollection<MstCitaParticular> MstCitaParticulars { get; set; }
        public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
        public virtual ICollection<MstPreticketCabecera> MstPreticketCabeceras { get; set; }
        public virtual ICollection<ScProgramacionFechaServicio> ScProgramacionFechaServicios { get; set; }
        public virtual ICollection<SoMedicoCitaHorario> SoMedicoCitaHorarios { get; set; }
    }
}
