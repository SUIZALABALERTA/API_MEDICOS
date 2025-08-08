using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstPaciente
    {
        public MstPaciente()
        {
            DetPacienteCompania = new HashSet<DetPacienteCompanium>();
            MstCitaParticulars = new HashSet<MstCitaParticular>();
            MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
            MstPreticketCabeceras = new HashSet<MstPreticketCabecera>();
            ScCita = new HashSet<ScCitum>();
        }

        public int PacId { get; set; }
        public int PacIdTipoDocumento { get; set; }
        public string PacNumeroDocumento { get; set; }
        public string PacNombre { get; set; }
        public string PacApellidoPaterno { get; set; }
        public string PacApellidoMaterno { get; set; }
        public string PacApellidoCasado { get; set; }
        public DateOnly? PacFechaNacimiento { get; set; }
        public int? PacIdSexo { get; set; }
        public int? PacIdEstadoCivil { get; set; }
        public string PacTelefonoMovil { get; set; }
        public string PacTelefonoCasa { get; set; }
        public string PacEmail { get; set; }
        public int? PacEdad { get; set; }
        public bool? PacResultadoWhatsapp { get; set; }
        public bool? PacAccesoWeb { get; set; }
        public string PacUsuarioWeb { get; set; }
        public string PacPasswordWeb { get; set; }
        public string PacDireccion1 { get; set; }
        public string PacDireccion2 { get; set; }
        public bool? PacEstado { get; set; }
        public string PacUsuarioCreacion { get; set; }
        public DateTime? PacFechaCreacion { get; set; }
        public string PacUsuarioModificacion { get; set; }
        public DateTime? PacFechaModificacion { get; set; }
        public int? PacIdDocAlt { get; set; }
        public string PacNumeroDocAlt { get; set; }
        public string PacNacionalidad { get; set; }
        public int? PacIdUbigeo { get; set; }
        public string PacImageRuta { get; set; }
        public string PacCodigoHistoriaClinica { get; set; }
        public int? PacIdGrupoSanguineo { get; set; }
        public int? PacIdFactorRh { get; set; }
        public int? PacIdGrupoEtnico { get; set; }
        public string PacCodigoValidacion { get; set; }
        public bool? PacCorreoValidado { get; set; }

        public virtual MstTipoDocumento PacIdDocAltNavigation { get; set; }
        public virtual MstEstadoCivil PacIdEstadoCivilNavigation { get; set; }
        public virtual MstFactorRh PacIdFactorRhNavigation { get; set; }
        public virtual MstLabGrupoEtnico PacIdGrupoEtnicoNavigation { get; set; }
        public virtual MstGrupoSanguineo PacIdGrupoSanguineoNavigation { get; set; }
        public virtual MstSexo PacIdSexoNavigation { get; set; }
        public virtual MstTipoDocumento PacIdTipoDocumentoNavigation { get; set; }
        public virtual MstUbigeo PacIdUbigeoNavigation { get; set; }
        public virtual ICollection<DetPacienteCompanium> DetPacienteCompania { get; set; }
        public virtual ICollection<MstCitaParticular> MstCitaParticulars { get; set; }
        public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
        public virtual ICollection<MstPreticketCabecera> MstPreticketCabeceras { get; set; }
        public virtual ICollection<ScCitum> ScCita { get; set; }
    }
}
