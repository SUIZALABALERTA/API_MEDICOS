using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstCompanium
    {
        public MstCompanium()
        {
            DetComModTarPaqs = new HashSet<DetComModTarPaq>();
            DetCompaniaAsociacionDcaCompaniaPrimariaNavigations = new HashSet<DetCompaniaAsociacion>();
            DetCompaniaAsociacionDcaCompaniaSecundariaNavigations = new HashSet<DetCompaniaAsociacion>();
            DetCompaniaSucursals = new HashSet<DetCompaniaSucursal>();
            DetCompaniasAreasComps = new HashSet<DetCompaniasAreasComp>();
            DetFacturaAnticipos = new HashSet<DetFacturaAnticipo>();
            DetPacienteCompania = new HashSet<DetPacienteCompanium>();
            MstAreaCompania = new HashSet<MstAreaCompania>();
            MstFacturaCabeceras = new HashSet<MstFacturaCabecera>();
            MstLabLoteLaboratorioCabeceras = new HashSet<MstLabLoteLaboratorioCabecera>();
            MstLabMuestraRechazadaCabeceras = new HashSet<MstLabMuestraRechazadaCabecera>();
            MstOrdenServicioCabeceras = new HashSet<MstOrdenServicioCabecera>();
            MstPreticketCabeceraPrcIdCompaniaAsociadaNavigations = new HashSet<MstPreticketCabecera>();
            MstPreticketCabeceraPrcIdCompaniaNavigations = new HashSet<MstPreticketCabecera>();
        }

        public int ComId { get; set; }
        public int? ComTipoDocumento { get; set; }
        public string ComNumeroDocumento { get; set; }
        public string ComRazonSocial { get; set; }
        public string ComNombreComercial { get; set; }
        public int? ComIdActividadCom { get; set; }
        public string ComDireccionFiscal { get; set; }
        public string ComReferenciaDireccion { get; set; }
        public int? ComIdUbigeo { get; set; }
        public string ComTelefono { get; set; }
        public int? ComIdDocumentoFiscal { get; set; }
        public int? ComIdFormaPago { get; set; }
        public int? ComIdTipoPago { get; set; }
        public int? ComIdTipoVenta { get; set; }
        public int? ComIdPeriodoFact { get; set; }
        public int? ComIdPeriodoCredito { get; set; }
        public string ComLineaCredito { get; set; }
        public int? ComIdPromotor { get; set; }
        public bool? ComAccesoWeb { get; set; }
        public string ComUsuarioWeb { get; set; }
        public string ComPasswordWeb { get; set; }
        public string ComTelefonoResultado { get; set; }
        public string ComCorreoResultado { get; set; }
        public string ComUsuarioCreacion { get; set; }
        public DateTime? ComFechaCreacion { get; set; }
        public string ComUsuarioModificacion { get; set; }
        public DateTime? ComFechaModificacion { get; set; }
        public bool? ComEstado { get; set; }
        public bool? ComReferencia { get; set; }
        public string ComCorreo { get; set; }
        public string ComEstadoSap { get; set; }
        public string ComErrorSap { get; set; }
        public bool? ComEnvioSap { get; set; }
        public string ComTipoPersona { get; set; }
        public string ComNombre { get; set; }
        public string ComApellidoPaterno { get; set; }
        public string ComApellidoMaterno { get; set; }
        public string[] ComRoles { get; set; }
        public string[] ComAccesos { get; set; }

        public virtual MstActividadComercial ComIdActividadComNavigation { get; set; }
        public virtual MstDocumentoFiscal ComIdDocumentoFiscalNavigation { get; set; }
        public virtual MstFormaPago ComIdFormaPagoNavigation { get; set; }
        public virtual MstPeriodoCredito ComIdPeriodoCreditoNavigation { get; set; }
        public virtual MstPeriodoFacturacion ComIdPeriodoFactNavigation { get; set; }
        public virtual MstPromotor ComIdPromotorNavigation { get; set; }
        public virtual MstTipoPago ComIdTipoPagoNavigation { get; set; }
        public virtual MstTipoVentum ComIdTipoVentaNavigation { get; set; }
        public virtual MstUbigeo ComIdUbigeoNavigation { get; set; }
        public virtual MstTipoDocumento ComTipoDocumentoNavigation { get; set; }
        public virtual ICollection<DetComModTarPaq> DetComModTarPaqs { get; set; }
        public virtual ICollection<DetCompaniaAsociacion> DetCompaniaAsociacionDcaCompaniaPrimariaNavigations { get; set; }
        public virtual ICollection<DetCompaniaAsociacion> DetCompaniaAsociacionDcaCompaniaSecundariaNavigations { get; set; }
        public virtual ICollection<DetCompaniaSucursal> DetCompaniaSucursals { get; set; }
        public virtual ICollection<DetCompaniasAreasComp> DetCompaniasAreasComps { get; set; }
        public virtual ICollection<DetFacturaAnticipo> DetFacturaAnticipos { get; set; }
        public virtual ICollection<DetPacienteCompanium> DetPacienteCompania { get; set; }
        public virtual ICollection<MstAreaCompania> MstAreaCompania { get; set; }
        public virtual ICollection<MstFacturaCabecera> MstFacturaCabeceras { get; set; }
        public virtual ICollection<MstLabLoteLaboratorioCabecera> MstLabLoteLaboratorioCabeceras { get; set; }
        public virtual ICollection<MstLabMuestraRechazadaCabecera> MstLabMuestraRechazadaCabeceras { get; set; }
        public virtual ICollection<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
        public virtual ICollection<MstPreticketCabecera> MstPreticketCabeceraPrcIdCompaniaAsociadaNavigations { get; set; }
        public virtual ICollection<MstPreticketCabecera> MstPreticketCabeceraPrcIdCompaniaNavigations { get; set; }
    }
}
