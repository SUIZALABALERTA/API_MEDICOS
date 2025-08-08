using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class suizasoftContext : DbContext
    {
        public suizasoftContext()
        {
        }

        public suizasoftContext(DbContextOptions<suizasoftContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cantidadtotal> Cantidadtotals { get; set; }
        public virtual DbSet<ConSecuenciaTabla> ConSecuenciaTablas { get; set; }
        public virtual DbSet<ConSecuenciaTablaServicio> ConSecuenciaTablaServicios { get; set; }
        public virtual DbSet<ConTopicoLote> ConTopicoLotes { get; set; }
        public virtual DbSet<DetCitasDetalleSeguro> DetCitasDetalleSeguros { get; set; }
        public virtual DbSet<DetComModTarPaq> DetComModTarPaqs { get; set; }
        public virtual DbSet<DetCompaniaAsociacion> DetCompaniaAsociacions { get; set; }
        public virtual DbSet<DetCompaniaSucursal> DetCompaniaSucursals { get; set; }
        public virtual DbSet<DetCompaniasAreasComp> DetCompaniasAreasComps { get; set; }
        public virtual DbSet<DetDiagnosticoOrdenMedica> DetDiagnosticoOrdenMedicas { get; set; }
        public virtual DbSet<DetDiagnosticoRecomendacione> DetDiagnosticoRecomendaciones { get; set; }
        public virtual DbSet<DetFacturaAnticipo> DetFacturaAnticipos { get; set; }
        public virtual DbSet<DetFacturaDetalle> DetFacturaDetalles { get; set; }
        public virtual DbSet<DetFacturaMedioPago> DetFacturaMedioPagos { get; set; }
        public virtual DbSet<DetFacturaTicket> DetFacturaTickets { get; set; }
        public virtual DbSet<DetFormaterium> DetFormateria { get; set; }
        public virtual DbSet<DetLabLoteLaboratorioDetalle> DetLabLoteLaboratorioDetalles { get; set; }
        public virtual DbSet<DetLabMuestraRechazadaDetalle> DetLabMuestraRechazadaDetalles { get; set; }
        public virtual DbSet<DetLabMuestraRechazadaImagen> DetLabMuestraRechazadaImagens { get; set; }
        public virtual DbSet<DetLabMuestraRechazadaMsj> DetLabMuestraRechazadaMsjs { get; set; }
        public virtual DbSet<DetLabOrdenImpresion> DetLabOrdenImpresions { get; set; }
        public virtual DbSet<DetLineaNegocioServicioArea> DetLineaNegocioServicioAreas { get; set; }
        public virtual DbSet<DetMedicoAreaNegocio> DetMedicoAreaNegocios { get; set; }
        public virtual DbSet<DetMedicoHorario> DetMedicoHorarios { get; set; }
        public virtual DbSet<DetMedicoRolCentroMedico> DetMedicoRolCentroMedicos { get; set; }
        public virtual DbSet<DetMedicoSede> DetMedicoSedes { get; set; }
        public virtual DbSet<DetNotaCreditoDetalle> DetNotaCreditoDetalles { get; set; }
        public virtual DbSet<DetOrdenMedicaDigital> DetOrdenMedicaDigitals { get; set; }
        public virtual DbSet<DetOrdenServicioDetalle> DetOrdenServicioDetalles { get; set; }
        public virtual DbSet<DetOrdenServicioOrdenMedica> DetOrdenServicioOrdenMedicas { get; set; }
        public virtual DbSet<DetOrdenTrazabilidad> DetOrdenTrazabilidads { get; set; }
        public virtual DbSet<DetPacienteCompaniaRiesgo> DetPacienteCompaniaRiesgos { get; set; }
        public virtual DbSet<DetPacienteCompanium> DetPacienteCompania { get; set; }
        public virtual DbSet<DetPaqueteDetalle> DetPaqueteDetalles { get; set; }
        public virtual DbSet<DetPerfilResultado> DetPerfilResultados { get; set; }
        public virtual DbSet<DetPreticketDetalle> DetPreticketDetalles { get; set; }
        public virtual DbSet<DetRuteoDetalleSeguro> DetRuteoDetalleSeguros { get; set; }
        public virtual DbSet<DetServicioMuestraLaboratorio> DetServicioMuestraLaboratorios { get; set; }
        public virtual DbSet<DetServicioResultado> DetServicioResultados { get; set; }
        public virtual DbSet<DetServicioSede> DetServicioSedes { get; set; }
        public virtual DbSet<DetServicioSedeFecha> DetServicioSedeFechas { get; set; }
        public virtual DbSet<DetTicketEstado> DetTicketEstados { get; set; }
        public virtual DbSet<DetTopicoMuestra> DetTopicoMuestras { get; set; }
        public virtual DbSet<DetTopicoObservacion> DetTopicoObservacions { get; set; }
        public virtual DbSet<DetTopicoPreScaneo> DetTopicoPreScaneos { get; set; }
        public virtual DbSet<EstComprobante> EstComprobantes { get; set; }
        public virtual DbSet<EstNotaCredito> EstNotaCreditos { get; set; }
        public virtual DbSet<EstTicket> EstTickets { get; set; }
        public virtual DbSet<LabOrdenMuestra> LabOrdenMuestras { get; set; }
        public virtual DbSet<LogDocumentoElectronico> LogDocumentoElectronicos { get; set; }
        public virtual DbSet<LogDocumentoEnterprice> LogDocumentoEnterprices { get; set; }
        public virtual DbSet<MiTabla> MiTablas { get; set; }
        public virtual DbSet<MstActividadComercial> MstActividadComercials { get; set; }
        public virtual DbSet<MstAgenteSerie> MstAgenteSeries { get; set; }
        public virtual DbSet<MstAreaCompania> MstAreaCompanias { get; set; }
        public virtual DbSet<MstAuditorium> MstAuditoria { get; set; }
        public virtual DbSet<MstBanner> MstBanners { get; set; }
        public virtual DbSet<MstBitacoraAtencionAuditorium> MstBitacoraAtencionAuditoria { get; set; }
        public virtual DbSet<MstCarGenPrestacion> MstCarGenPrestacions { get; set; }
        public virtual DbSet<MstCatalogoResultado> MstCatalogoResultados { get; set; }
        public virtual DbSet<MstCentroCosto> MstCentroCostos { get; set; }
        public virtual DbSet<MstCie10> MstCie10s { get; set; }
        public virtual DbSet<MstCitaParticular> MstCitaParticulars { get; set; }
        public virtual DbSet<MstCitasSeguro> MstCitasSeguros { get; set; }
        public virtual DbSet<MstClasificacionLaboratorio> MstClasificacionLaboratorios { get; set; }
        public virtual DbSet<MstCompanium> MstCompania { get; set; }
        public virtual DbSet<MstConfiguracionPaqueteSeguro> MstConfiguracionPaqueteSeguros { get; set; }
        public virtual DbSet<MstConvenio> MstConvenios { get; set; }
        public virtual DbSet<MstDetalleServicio> MstDetalleServicios { get; set; }
        public virtual DbSet<MstDiaSemana> MstDiaSemanas { get; set; }
        public virtual DbSet<MstDiagnostico> MstDiagnosticos { get; set; }
        public virtual DbSet<MstDocumentoFacturador> MstDocumentoFacturadors { get; set; }
        public virtual DbSet<MstDocumentoFiscal> MstDocumentoFiscals { get; set; }
        public virtual DbSet<MstEstadoCivil> MstEstadoCivils { get; set; }
        public virtual DbSet<MstFactorRh> MstFactorRhs { get; set; }
        public virtual DbSet<MstFacturaCabecera> MstFacturaCabeceras { get; set; }
        public virtual DbSet<MstFeriado> MstFeriados { get; set; }
        public virtual DbSet<MstFormaPago> MstFormaPagos { get; set; }
        public virtual DbSet<MstFormaterium> MstFormateria { get; set; }
        public virtual DbSet<MstGrupoSanguineo> MstGrupoSanguineos { get; set; }
        public virtual DbSet<MstGrupoSeguro> MstGrupoSeguros { get; set; }
        public virtual DbSet<MstGrupoServicioOmd> MstGrupoServicioOmds { get; set; }
        public virtual DbSet<MstJefePromotor> MstJefePromotors { get; set; }
        public virtual DbSet<MstLabBiopsium> MstLabBiopsia { get; set; }
        public virtual DbSet<MstLabGrupoEtnico> MstLabGrupoEtnicos { get; set; }
        public virtual DbSet<MstLabLoteLaboratorioCabecera> MstLabLoteLaboratorioCabeceras { get; set; }
        public virtual DbSet<MstLabMuestraRechazadaCabecera> MstLabMuestraRechazadaCabeceras { get; set; }
        public virtual DbSet<MstLabOrdenAntibiogramaCabecera> MstLabOrdenAntibiogramaCabeceras { get; set; }
        public virtual DbSet<MstLabOrdenAntibiogramaDetalle> MstLabOrdenAntibiogramaDetalles { get; set; }
        public virtual DbSet<MstLabOrdenEscaneo> MstLabOrdenEscaneos { get; set; }
        public virtual DbSet<MstLabOrdenImpresion> MstLabOrdenImpresions { get; set; }
        public virtual DbSet<MstLabOrdenMuestraPerfil> MstLabOrdenMuestraPerfils { get; set; }
        public virtual DbSet<MstLabOrdenMuestraServicio> MstLabOrdenMuestraServicios { get; set; }
        public virtual DbSet<MstLabOrdenResultado> MstLabOrdenResultados { get; set; }
        public virtual DbSet<MstLabOrdenResultadoHistorial> MstLabOrdenResultadoHistorials { get; set; }
        public virtual DbSet<MstLabPerfil> MstLabPerfils { get; set; }
        public virtual DbSet<MstLabPerfilServicio> MstLabPerfilServicios { get; set; }
        public virtual DbSet<MstLabServicioValoresRef> MstLabServicioValoresRefs { get; set; }
        public virtual DbSet<MstLabUnidadEdad> MstLabUnidadEdads { get; set; }
        public virtual DbSet<MstLabUnidadServicio> MstLabUnidadServicios { get; set; }
        public virtual DbSet<MstLisProveedor> MstLisProveedors { get; set; }
        public virtual DbSet<MstLoteCompanium> MstLoteCompania { get; set; }
        public virtual DbSet<MstMedico> MstMedicos { get; set; }
        public virtual DbSet<MstModalidad> MstModalidads { get; set; }
        public virtual DbSet<MstMonedum> MstMoneda { get; set; }
        public virtual DbSet<MstNotaCreditoCabecera> MstNotaCreditoCabeceras { get; set; }
        public virtual DbSet<MstOrdenMedicaDigital> MstOrdenMedicaDigitals { get; set; }
        public virtual DbSet<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
        public virtual DbSet<MstPaciente> MstPacientes { get; set; }
        public virtual DbSet<MstPaqueteCabecera> MstPaqueteCabeceras { get; set; }
        public virtual DbSet<MstParametroSistema> MstParametroSistemas { get; set; }
        public virtual DbSet<MstPaternidad> MstPaternidads { get; set; }
        public virtual DbSet<MstPeriodoCredito> MstPeriodoCreditos { get; set; }
        public virtual DbSet<MstPeriodoFacturacion> MstPeriodoFacturacions { get; set; }
        public virtual DbSet<MstPreticketCabecera> MstPreticketCabeceras { get; set; }
        public virtual DbSet<MstProductoSeguro> MstProductoSeguros { get; set; }
        public virtual DbSet<MstProductosFarmacium> MstProductosFarmacia { get; set; }
        public virtual DbSet<MstPromotor> MstPromotors { get; set; }
        public virtual DbSet<MstProyecto> MstProyectos { get; set; }
        public virtual DbSet<MstResultadosRutaAw> MstResultadosRutaAws { get; set; }
        public virtual DbSet<MstRol> MstRols { get; set; }
        public virtual DbSet<MstRolCentroMedico> MstRolCentroMedicos { get; set; }
        public virtual DbSet<MstRuteoSeguro> MstRuteoSeguros { get; set; }
        public virtual DbSet<MstSeccionLaboratorio> MstSeccionLaboratorios { get; set; }
        public virtual DbSet<MstServicio> MstServicios { get; set; }
        public virtual DbSet<MstServicioAreaNegocio> MstServicioAreaNegocios { get; set; }
        public virtual DbSet<MstServicioIncor> MstServicioIncors { get; set; }
        public virtual DbSet<MstSexo> MstSexos { get; set; }
        public virtual DbSet<MstSistema> MstSistemas { get; set; }
        public virtual DbSet<MstSucursal> MstSucursals { get; set; }
        public virtual DbSet<MstSucursalModalidad> MstSucursalModalidads { get; set; }
        public virtual DbSet<MstTarifario> MstTarifarios { get; set; }
        public virtual DbSet<MstTarifarioCategorium> MstTarifarioCategoria { get; set; }
        public virtual DbSet<MstTarifarioPaquete> MstTarifarioPaquetes { get; set; }
        public virtual DbSet<MstTarifarioPerfil> MstTarifarioPerfils { get; set; }
        public virtual DbSet<MstTiempoProceso> MstTiempoProcesos { get; set; }
        public virtual DbSet<MstTipoCambio> MstTipoCambios { get; set; }
        public virtual DbSet<MstTipoDocumento> MstTipoDocumentos { get; set; }
        public virtual DbSet<MstTipoDocumentoVentum> MstTipoDocumentoVenta { get; set; }
        public virtual DbSet<MstTipoEvaluacion> MstTipoEvaluacions { get; set; }
        public virtual DbSet<MstTipoLaboratorio> MstTipoLaboratorios { get; set; }
        public virtual DbSet<MstTipoModalidad> MstTipoModalidads { get; set; }
        public virtual DbSet<MstTipoPago> MstTipoPagos { get; set; }
        public virtual DbSet<MstTipoServicioLaboratorio> MstTipoServicioLaboratorios { get; set; }
        public virtual DbSet<MstTipoSistema> MstTipoSistemas { get; set; }
        public virtual DbSet<MstTipoVentum> MstTipoVenta { get; set; }
        public virtual DbSet<MstTokenPaciente> MstTokenPacientes { get; set; }
        public virtual DbSet<MstTopicoEscaneo> MstTopicoEscaneos { get; set; }
        public virtual DbSet<MstTramaDetDen> MstTramaDetDens { get; set; }
        public virtual DbSet<MstTramaRuc> MstTramaRucs { get; set; }
        public virtual DbSet<MstTransaccione> MstTransacciones { get; set; }
        public virtual DbSet<MstUbigeo> MstUbigeos { get; set; }
        public virtual DbSet<MstUnidadNegocio> MstUnidadNegocios { get; set; }
        public virtual DbSet<MstUsuario> MstUsuarios { get; set; }
        public virtual DbSet<MstUsuarioOmd> MstUsuarioOmds { get; set; }
        public virtual DbSet<MstUsuarioSeguro> MstUsuarioSeguros { get; set; }
        public virtual DbSet<MstUsuarioSerie> MstUsuarioSeries { get; set; }
        public virtual DbSet<MstUsuariosGrupo> MstUsuariosGrupos { get; set; }
        public virtual DbSet<MstUsuariosSuizaPartner> MstUsuariosSuizaPartners { get; set; }
        public virtual DbSet<PCountExa> PCountExas { get; set; }
        public virtual DbSet<PCountSiEstaValidado> PCountSiEstaValidados { get; set; }
        public virtual DbSet<PEsperfilOServicio> PEsperfilOServicios { get; set; }
        public virtual DbSet<PEsperfilOServicio1> PEsperfilOServicios1 { get; set; }
        public virtual DbSet<PTotalRegistro> PTotalRegistros { get; set; }
        public virtual DbSet<ResAntibiograma> ResAntibiogramas { get; set; }
        public virtual DbSet<ScCitum> ScCita { get; set; }
        public virtual DbSet<ScCupoHorario> ScCupoHorarios { get; set; }
        public virtual DbSet<ScProgramacionFecha> ScProgramacionFechas { get; set; }
        public virtual DbSet<ScProgramacionFechaServicio> ScProgramacionFechaServicios { get; set; }
        public virtual DbSet<ScProgramacionSucursal> ScProgramacionSucursals { get; set; }
        public virtual DbSet<ScSubModalidad> ScSubModalidads { get; set; }
        public virtual DbSet<SoCitaComplemento> SoCitaComplementos { get; set; }
        public virtual DbSet<SoComplemento> SoComplementos { get; set; }
        public virtual DbSet<SoMedicoCitaHorario> SoMedicoCitaHorarios { get; set; }
        public virtual DbSet<SoTipoAtencion> SoTipoAtencions { get; set; }
        public virtual DbSet<SoTipoSeguro> SoTipoSeguros { get; set; }
        public virtual DbSet<SoTipoServicio> SoTipoServicios { get; set; }
        public virtual DbSet<TefCompanium> TefCompania { get; set; }
        public virtual DbSet<TefDetallePlantillaTrama> TefDetallePlantillaTramas { get; set; }
        public virtual DbSet<TefPlantillaTrama> TefPlantillaTramas { get; set; }
        public virtual DbSet<TefTipoServicioLote> TefTipoServicioLotes { get; set; }
        public virtual DbSet<TipAccionBitacora> TipAccionBitacoras { get; set; }
        public virtual DbSet<TipAfectacionIgv> TipAfectacionIgvs { get; set; }
        public virtual DbSet<TipAreaAtencion> TipAreaAtencions { get; set; }
        public virtual DbSet<TipCentroCostoNegocio> TipCentroCostoNegocios { get; set; }
        public virtual DbSet<TipContenedor> TipContenedors { get; set; }
        public virtual DbSet<TipEquipoLaboratorio> TipEquipoLaboratorios { get; set; }
        public virtual DbSet<TipEstadoCitasSeguro> TipEstadoCitasSeguros { get; set; }
        public virtual DbSet<TipFisiologicoInterface> TipFisiologicoInterfaces { get; set; }
        public virtual DbSet<TipGrupoEtnicoInterface> TipGrupoEtnicoInterfaces { get; set; }
        public virtual DbSet<TipGrupoOmd> TipGrupoOmds { get; set; }
        public virtual DbSet<TipLineaNegocio> TipLineaNegocios { get; set; }
        public virtual DbSet<TipMedico> TipMedicos { get; set; }
        public virtual DbSet<TipMedicoColegiatura> TipMedicoColegiaturas { get; set; }
        public virtual DbSet<TipMedicoEspecialidad> TipMedicoEspecialidads { get; set; }
        public virtual DbSet<TipModuloFacturacion> TipModuloFacturacions { get; set; }
        public virtual DbSet<TipMuestraLaboratorio> TipMuestraLaboratorios { get; set; }
        public virtual DbSet<TipNotaCreditoOperacion> TipNotaCreditoOperacions { get; set; }
        public virtual DbSet<TipOrdenEstado> TipOrdenEstados { get; set; }
        public virtual DbSet<TipPagoCuentum> TipPagoCuenta { get; set; }
        public virtual DbSet<TipPagoTarjetum> TipPagoTarjeta { get; set; }
        public virtual DbSet<TipParentesco> TipParentescos { get; set; }
        public virtual DbSet<TipPrioridad> TipPrioridads { get; set; }
        public virtual DbSet<TipPrioridadAtencion> TipPrioridadAtencions { get; set; }
        public virtual DbSet<TipProcedencium> TipProcedencia { get; set; }
        public virtual DbSet<TipPromotor> TipPromotors { get; set; }
        public virtual DbSet<TipRiesgo> TipRiesgos { get; set; }
        public virtual DbSet<TipSeguro> TipSeguros { get; set; }
        public virtual DbSet<TipServicioArea> TipServicioAreas { get; set; }
        public virtual DbSet<TipServicioAreaLaboratorioBak> TipServicioAreaLaboratorioBaks { get; set; }
        public virtual DbSet<TipServicioMetodoLaboratorio> TipServicioMetodoLaboratorios { get; set; }
        public virtual DbSet<TipServicioProceso> TipServicioProcesos { get; set; }
        public virtual DbSet<TipServicioTemperatura> TipServicioTemperaturas { get; set; }
        public virtual DbSet<TipTopicoEnvio> TipTopicoEnvios { get; set; }
        public virtual DbSet<TipTopicoIngreso> TipTopicoIngresos { get; set; }
        public virtual DbSet<TipTopicoLaboratorio> TipTopicoLaboratorios { get; set; }
        public virtual DbSet<TipTubo> TipTubos { get; set; }
        public virtual DbSet<TipUnidadEdadInterface> TipUnidadEdadInterfaces { get; set; }
        public virtual DbSet<TipUnidadMedidum> TipUnidadMedida { get; set; }
        public virtual DbSet<TipVigenciaOrdenMedica> TipVigenciaOrdenMedicas { get; set; }
        public virtual DbSet<VCpsId> VCpsIds { get; set; }
        public virtual DbSet<VEdad> VEdads { get; set; }
        public virtual DbSet<VOmdId> VOmdIds { get; set; }
        public virtual DbSet<WatchdogLog> WatchdogLogs { get; set; }
        public virtual DbSet<WatchdogWatchexceptionlog> WatchdogWatchexceptionlogs { get; set; }
        public virtual DbSet<WatchdogWatchlog> WatchdogWatchlogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=ls-95bad1a0b2037a2b57e54db42404bb6d675bffd4.cwhzeaelmcdv.us-east-1.rds.amazonaws.com;Port=5432;Database=suizasoft;User Id=dbmasteruser;Password=(K_F)[^&3n#%lMcWDiMT1PV4JBcD2A)K;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");

            modelBuilder.Entity<Cantidadtotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cantidadtotal");

                entity.Property(e => e.Count).HasColumnName("count");
            });

            modelBuilder.Entity<ConSecuenciaTabla>(entity =>
            {
                entity.HasKey(e => new { e.SecNombre, e.SecPeriodo, e.SecAnio, e.SecDia, e.SecSucursal })
                    .HasName("CON_SECUENCIA_TABLA_pkey");

                entity.ToTable("CON_SECUENCIA_TABLA", "suizasoft");

                entity.Property(e => e.SecNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("sec_nombre");

                entity.Property(e => e.SecPeriodo)
                    .HasMaxLength(2)
                    .HasColumnName("sec_periodo");

                entity.Property(e => e.SecAnio)
                    .HasMaxLength(2)
                    .HasColumnName("sec_anio");

                entity.Property(e => e.SecDia)
                    .HasMaxLength(2)
                    .HasColumnName("sec_dia");

                entity.Property(e => e.SecSucursal)
                    .HasMaxLength(2)
                    .HasColumnName("sec_sucursal");

                entity.Property(e => e.SecCorrelativo).HasColumnName("sec_correlativo");

                entity.Property(e => e.SecDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("sec_descripcion");

                entity.Property(e => e.SecEstado).HasColumnName("sec_estado");

                entity.Property(e => e.SecFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("sec_fecha_registro");

                entity.Property(e => e.SecId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sec_id");

                entity.Property(e => e.SecUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("sec_usuario_registro");
            });

            modelBuilder.Entity<ConSecuenciaTablaServicio>(entity =>
            {
                entity.HasKey(e => e.SesAbreviaturaCodigo)
                    .HasName("CON_SECUENCIA_TABLA_SERVICIOS_pkey");

                entity.ToTable("CON_SECUENCIA_TABLA_SERVICIOS", "suizasoft");

                entity.Property(e => e.SesAbreviaturaCodigo)
                    .HasMaxLength(3)
                    .HasColumnName("ses_abreviatura_codigo");

                entity.Property(e => e.SesCorrelativo)
                    .HasMaxLength(5)
                    .HasColumnName("ses_correlativo");

                entity.Property(e => e.SesEstado).HasColumnName("ses_estado");

                entity.Property(e => e.SesFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ses_fecha_registro");

                entity.Property(e => e.SesUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("ses_usuario_registro");
            });

            modelBuilder.Entity<ConTopicoLote>(entity =>
            {
                entity.HasKey(e => e.CtlId)
                    .HasName("CON_TOPICO_LOTE_pkey");

                entity.ToTable("CON_TOPICO_LOTE", "suizasoft");

                entity.Property(e => e.CtlId).HasColumnName("ctl_id");

                entity.Property(e => e.CtlLote)
                    .HasColumnType("character varying")
                    .HasColumnName("ctl_lote");
            });

            modelBuilder.Entity<DetCitasDetalleSeguro>(entity =>
            {
                entity.HasKey(e => e.CidId)
                    .HasName("DET_CITAS_SEGUROS_DETALLE_pkey");

                entity.ToTable("DET_CITAS_DETALLE_SEGUROS", "suizasoft");

                entity.Property(e => e.CidId).HasColumnName("cid_id");

                entity.Property(e => e.CidEstado).HasColumnName("cid_estado");

                entity.Property(e => e.CidFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cid_fecha_modificacion");

                entity.Property(e => e.CidFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cid_fecha_registro");

                entity.Property(e => e.CidFlagPaquete).HasColumnName("cid_flag_paquete");

                entity.Property(e => e.CidIdCitas).HasColumnName("cid_id_citas");

                entity.Property(e => e.CidIdServicio).HasColumnName("cid_id_servicio");

                entity.Property(e => e.CidRutaInforme)
                    .HasColumnType("character varying")
                    .HasColumnName("cid_ruta_informe");

                entity.Property(e => e.CidUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("cid_usuario_modificacion");

                entity.Property(e => e.CidUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("cid_usuario_registro");
            });

            modelBuilder.Entity<DetComModTarPaq>(entity =>
            {
                entity.HasKey(e => e.CmtpId)
                    .HasName("DET_COM_MOD_TAR_PAQ_pkey");

                entity.ToTable("DET_COM_MOD_TAR_PAQ", "suizasoft");

                entity.HasIndex(e => new { e.CmtpIdCompania, e.CmtpIdModalidad, e.CmtpIdTarifa, e.CmtpIdPaquete }, "DET_COM_MOD_TAR_PAQ_cmtp_id_compania_cmtp_id_modalidad_cmtp_key")
                    .IsUnique();

                entity.HasIndex(e => e.CmtpIdModalidad, "IX_DET_COM_MOD_TAR_PAQ_cmtp_id_modalidad");

                entity.HasIndex(e => e.CmtpIdPaquete, "IX_DET_COM_MOD_TAR_PAQ_cmtp_id_paquete");

                entity.HasIndex(e => e.CmtpIdTarifa, "IX_DET_COM_MOD_TAR_PAQ_cmtp_id_tarifa");

                entity.Property(e => e.CmtpId).HasColumnName("cmtp_id");

                entity.Property(e => e.CmtpFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cmtp_fecha_creacion");

                entity.Property(e => e.CmtpIdCompania).HasColumnName("cmtp_id_compania");

                entity.Property(e => e.CmtpIdModalidad).HasColumnName("cmtp_id_modalidad");

                entity.Property(e => e.CmtpIdPaquete).HasColumnName("cmtp_id_paquete");

                entity.Property(e => e.CmtpIdTarifa).HasColumnName("cmtp_id_tarifa");

                entity.Property(e => e.CmtpUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("cmtp_usuario_creacion");

                entity.HasOne(d => d.CmtpIdCompaniaNavigation)
                    .WithMany(p => p.DetComModTarPaqs)
                    .HasForeignKey(d => d.CmtpIdCompania)
                    .HasConstraintName("DET_COM_MOD_TAR_PAQ_cmtp_id_compania_fkey");

                entity.HasOne(d => d.CmtpIdModalidadNavigation)
                    .WithMany(p => p.DetComModTarPaqs)
                    .HasForeignKey(d => d.CmtpIdModalidad)
                    .HasConstraintName("DET_COM_MOD_TAR_PAQ_cmtp_id_modalidad_fkey");

                entity.HasOne(d => d.CmtpIdPaqueteNavigation)
                    .WithMany(p => p.DetComModTarPaqs)
                    .HasForeignKey(d => d.CmtpIdPaquete)
                    .HasConstraintName("DET_COM_MOD_TAR_PAQ_cmtp_id paquete_fkey");

                entity.HasOne(d => d.CmtpIdTarifaNavigation)
                    .WithMany(p => p.DetComModTarPaqs)
                    .HasForeignKey(d => d.CmtpIdTarifa)
                    .HasConstraintName("DET_COM_MOD_TAR_PAQ_cmtp_id_tarifa_fkey");
            });

            modelBuilder.Entity<DetCompaniaAsociacion>(entity =>
            {
                entity.HasKey(e => new { e.DcaCompaniaPrimaria, e.DcaCompaniaSecundaria })
                    .HasName("DET_COMPANIA_ASOCIACION_pkey");

                entity.ToTable("DET_COMPANIA_ASOCIACION", "suizasoft");

                entity.HasIndex(e => e.DcaCompaniaSecundaria, "IX_DET_COMPANIA_ASOCIACION_dca_compania_secundaria");

                entity.Property(e => e.DcaCompaniaPrimaria).HasColumnName("dca_compania_primaria");

                entity.Property(e => e.DcaCompaniaSecundaria).HasColumnName("dca_compania_secundaria");

                entity.Property(e => e.DcaEstado).HasColumnName("dca_estado");

                entity.Property(e => e.DcaFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dca_fecha_creacion");

                entity.Property(e => e.DcaFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dca_fecha_modificacion");

                entity.Property(e => e.DcaUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dca_usuario_creacion");

                entity.Property(e => e.DcaUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dca_usuario_modificacion");

                entity.HasOne(d => d.DcaCompaniaPrimariaNavigation)
                    .WithMany(p => p.DetCompaniaAsociacionDcaCompaniaPrimariaNavigations)
                    .HasForeignKey(d => d.DcaCompaniaPrimaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_COMPANIA_ASOCIACION_dca_compania_primaria_fkey");

                entity.HasOne(d => d.DcaCompaniaSecundariaNavigation)
                    .WithMany(p => p.DetCompaniaAsociacionDcaCompaniaSecundariaNavigations)
                    .HasForeignKey(d => d.DcaCompaniaSecundaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_COMPANIA_ASOCIACION_dca_compania_secundaria_fkey");
            });

            modelBuilder.Entity<DetCompaniaSucursal>(entity =>
            {
                entity.HasKey(e => new { e.CsuId, e.CsuIdCompania })
                    .HasName("MST_COMP_SUCURSAL_pkey");

                entity.ToTable("DET_COMPANIA_SUCURSAL", "suizasoft");

                entity.HasIndex(e => e.CsuIdCompania, "IX_DET_COMPANIA_SUCURSAL_csu_id_compania");

                entity.HasIndex(e => e.CsuIdUbigeoSucursal, "IX_DET_COMPANIA_SUCURSAL_csu_id_ubigeo_sucursal");

                entity.Property(e => e.CsuId).HasColumnName("csu_id");

                entity.Property(e => e.CsuIdCompania).HasColumnName("csu_id_compania");

                entity.Property(e => e.CsuCargoCobranzas)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_cargo_cobranzas");

                entity.Property(e => e.CsuCargoComercial)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_cargo_comercial");

                entity.Property(e => e.CsuCargoFacturacion)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_cargo_facturacion");

                entity.Property(e => e.CsuDireccionSucursal)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_direccion_sucursal");

                entity.Property(e => e.CsuDistritoRecojoMotorizado)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_distrito_recojo_motorizado");

                entity.Property(e => e.CsuEmailCobranzas)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_email_cobranzas");

                entity.Property(e => e.CsuEmailComercial)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_email_comercial");

                entity.Property(e => e.CsuEmailFacturacion)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_email_facturacion");

                entity.Property(e => e.CsuEstado).HasColumnName("csu_estado");

                entity.Property(e => e.CsuFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("csu_fecha_creacion");

                entity.Property(e => e.CsuFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("csu_fecha_modificacion");

                entity.Property(e => e.CsuIdUbigeoSucursal).HasColumnName("csu_id_ubigeo_sucursal");

                entity.Property(e => e.CsuNombreCobranzas)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_nombre_cobranzas");

                entity.Property(e => e.CsuNombreComercial)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_nombre_comercial");

                entity.Property(e => e.CsuNombreFacturacion)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_nombre_facturacion");

                entity.Property(e => e.CsuNombreMotorizado)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_nombre_motorizado");

                entity.Property(e => e.CsuNombreSucursal)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_nombre_sucursal");

                entity.Property(e => e.CsuReferenciaSucursal)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_referencia_sucursal");

                entity.Property(e => e.CsuRucCompania)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_ruc_compania");

                entity.Property(e => e.CsuTelefonoCobranzas)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_telefono_cobranzas");

                entity.Property(e => e.CsuTelefonoComercial)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_telefono_comercial");

                entity.Property(e => e.CsuTelefonoContacto)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_telefono_contacto");

                entity.Property(e => e.CsuTelefonoFacturacion)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_telefono_facturacion");

                entity.Property(e => e.CsuTelefonoMotorizado)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_telefono_motorizado");

                entity.Property(e => e.CsuUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_usuario_creacion");

                entity.Property(e => e.CsuUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("csu_usuario_modificacion");

                entity.HasOne(d => d.CsuIdCompaniaNavigation)
                    .WithMany(p => p.DetCompaniaSucursals)
                    .HasForeignKey(d => d.CsuIdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_COMPANIA_SUCURSAL_csu_id_compania_fkey");

                entity.HasOne(d => d.CsuIdUbigeoSucursalNavigation)
                    .WithMany(p => p.DetCompaniaSucursals)
                    .HasForeignKey(d => d.CsuIdUbigeoSucursal)
                    .HasConstraintName("MST_COMPANIA_SUCURSAL_csu_id_ubigeo_sucursal_fkey");
            });

            modelBuilder.Entity<DetCompaniasAreasComp>(entity =>
            {
                entity.HasKey(e => e.DcacId)
                    .HasName("DET_COMPANIAS_AREAS_COMP_pkey");

                entity.ToTable("DET_COMPANIAS_AREAS_COMP", "suizasoft");

                entity.HasIndex(e => e.DcacIdAreaCompania, "IX_DET_COMPANIAS_AREAS_COMP_dcac_id_area_compania");

                entity.HasIndex(e => e.DcacIdCompania, "IX_DET_COMPANIAS_AREAS_COMP_dcac_id_compania");

                entity.Property(e => e.DcacId).HasColumnName("dcac_id");

                entity.Property(e => e.DcacFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dcac_fecha_creacion");

                entity.Property(e => e.DcacIdAreaCompania).HasColumnName("dcac_id_area_compania");

                entity.Property(e => e.DcacIdCompania).HasColumnName("dcac_id_compania");

                entity.Property(e => e.DcacUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("dcac_usuario_creacion");

                entity.HasOne(d => d.DcacIdAreaCompaniaNavigation)
                    .WithMany(p => p.DetCompaniasAreasComps)
                    .HasForeignKey(d => d.DcacIdAreaCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_COMPANIAS_AREAS_COMP_dcac_id_area_compania_fkey");

                entity.HasOne(d => d.DcacIdCompaniaNavigation)
                    .WithMany(p => p.DetCompaniasAreasComps)
                    .HasForeignKey(d => d.DcacIdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_COMPANIAS_AREAS_COMP_dcac_id_compania_fkey");
            });

            modelBuilder.Entity<DetDiagnosticoOrdenMedica>(entity =>
            {
                entity.HasKey(e => e.DdoId)
                    .HasName("DET_DIAGNOSTICO_ORDEN_MEDICA_pkey");

                entity.ToTable("DET_DIAGNOSTICO_ORDEN_MEDICA", "suizasoft");

                entity.Property(e => e.DdoId).HasColumnName("ddo_id");

                entity.Property(e => e.DdoDigId)
                    .HasMaxLength(10)
                    .HasColumnName("ddo_dig_id");

                entity.Property(e => e.DdoEstado)
                    .HasColumnName("ddo_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DdoFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ddo_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DdoFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ddo_fecha_modificacion");

                entity.Property(e => e.DdoOmdAnio)
                    .HasMaxLength(2)
                    .HasColumnName("ddo_omd_anio")
                    .IsFixedLength();

                entity.Property(e => e.DdoOmdId).HasColumnName("ddo_omd_id");

                entity.Property(e => e.DdoOmdPeriodo)
                    .HasMaxLength(2)
                    .HasColumnName("ddo_omd_periodo")
                    .IsFixedLength();

                entity.Property(e => e.DdoOmdSucId)
                    .HasMaxLength(2)
                    .HasColumnName("ddo_omd_suc_id")
                    .IsFixedLength();
            });

            modelBuilder.Entity<DetDiagnosticoRecomendacione>(entity =>
            {
                entity.HasKey(e => e.DdrId)
                    .HasName("DET_DIAGNOSTICO_RECOMENDACIONES_pkey");

                entity.ToTable("DET_DIAGNOSTICO_RECOMENDACIONES", "suizasoft");

                entity.HasIndex(e => e.DdrIdDiagnostico, "IX_DET_DIAGNOSTICO_RECOMENDACIONES_ddr_id_diagnostico");

                entity.Property(e => e.DdrId).HasColumnName("ddr_id");

                entity.Property(e => e.DdrEstado).HasColumnName("ddr_estado");

                entity.Property(e => e.DdrFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ddr_fecha_creacion");

                entity.Property(e => e.DdrFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ddr_fecha_modificacion");

                entity.Property(e => e.DdrIdDiagnostico)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("ddr_id_diagnostico")
                    .IsFixedLength();

                entity.Property(e => e.DdrRecomendacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ddr_recomendacion");

                entity.Property(e => e.DdrUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("ddr_usuario_creacion");

                entity.Property(e => e.DdrUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ddr_usuario_modificacion");

                entity.HasOne(d => d.DdrIdDiagnosticoNavigation)
                    .WithMany(p => p.DetDiagnosticoRecomendaciones)
                    .HasForeignKey(d => d.DdrIdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_DIAGNOSTICO_RECOMENDACIONES_ddr_id_diagnostico_fkey");
            });

            modelBuilder.Entity<DetFacturaAnticipo>(entity =>
            {
                entity.HasKey(e => e.DfaId)
                    .HasName("DET_FACTURA_ANTICIPO_pkey");

                entity.ToTable("DET_FACTURA_ANTICIPO", "suizasoft");

                entity.HasIndex(e => e.DfaIdAgenteSerie, "IX_DET_FACTURA_ANTICIPO_dfa_id_agente_serie");

                entity.HasIndex(e => e.DfaIdCompania, "IX_DET_FACTURA_ANTICIPO_dfa_id_compania");

                entity.Property(e => e.DfaId).HasColumnName("dfa_id");

                entity.Property(e => e.DfaCorrelativo).HasColumnName("dfa_correlativo");

                entity.Property(e => e.DfaFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dfa_fecha_creacion");

                entity.Property(e => e.DfaFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dfa_fecha_modificacion");

                entity.Property(e => e.DfaIdAgenteSerie).HasColumnName("dfa_id_agente_serie");

                entity.Property(e => e.DfaIdCompania).HasColumnName("dfa_id_compania");

                entity.Property(e => e.DfaPago)
                    .HasPrecision(13, 2)
                    .HasColumnName("dfa_pago");

                entity.Property(e => e.DfaSerie)
                    .HasColumnType("character varying")
                    .HasColumnName("dfa_serie");

                entity.Property(e => e.DfaUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dfa_usuario_creacion");

                entity.Property(e => e.DfaUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dfa_usuario_modificacion");

                entity.HasOne(d => d.DfaIdAgenteSerieNavigation)
                    .WithMany(p => p.DetFacturaAnticipos)
                    .HasForeignKey(d => d.DfaIdAgenteSerie)
                    .HasConstraintName("DET_FACTURA_ANTICIPO_dfa_id_agente_serie_fkey");

                entity.HasOne(d => d.DfaIdCompaniaNavigation)
                    .WithMany(p => p.DetFacturaAnticipos)
                    .HasForeignKey(d => d.DfaIdCompania)
                    .HasConstraintName("DET_FACTURA_ANTICIPO_dfa_id_compania_fkey");
            });

            modelBuilder.Entity<DetFacturaDetalle>(entity =>
            {
                entity.HasKey(e => e.FadId)
                    .HasName("DET_FACTURA_DETALLE_pkey");

                entity.ToTable("DET_FACTURA_DETALLE", "suizasoft");

                entity.HasIndex(e => e.FadIdCabecera, "IX_DET_FACTURA_DETALLE_fad_id_cabecera");

                entity.Property(e => e.FadId).HasColumnName("fad_id");

                entity.Property(e => e.FadCantidad).HasColumnName("fad_cantidad");

                entity.Property(e => e.FadCobertura)
                    .HasPrecision(13, 2)
                    .HasColumnName("fad_cobertura");

                entity.Property(e => e.FadCodigoAfectoIgv)
                    .HasColumnType("character varying")
                    .HasColumnName("fad_codigo_afecto_igv");

                entity.Property(e => e.FadCorrelativo).HasColumnName("fad_correlativo");

                entity.Property(e => e.FadFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fad_fecha_creacion");

                entity.Property(e => e.FadFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fad_fecha_modificacion");

                entity.Property(e => e.FadIdAfectoIgv).HasColumnName("fad_id_afecto_igv");

                entity.Property(e => e.FadIdCabecera).HasColumnName("fad_id_cabecera");

                entity.Property(e => e.FadIdServicioPerfil).HasColumnName("fad_id_servicio_perfil");

                entity.Property(e => e.FadIdTipoDocVenta).HasColumnName("fad_id_tipo_doc_venta");

                entity.Property(e => e.FadIdUnidadMedida)
                    .HasColumnType("character varying")
                    .HasColumnName("fad_id_unidad_medida");

                entity.Property(e => e.FadIndex).HasColumnName("fad_index");

                entity.Property(e => e.FadMontoACuenta)
                    .HasPrecision(13, 2)
                    .HasColumnName("fad_monto_a_cuenta");

                entity.Property(e => e.FadMontoDeducible)
                    .HasPrecision(13, 2)
                    .HasColumnName("fad_monto_deducible");

                entity.Property(e => e.FadObservacion)
                    .HasColumnType("character varying")
                    .HasColumnName("fad_observacion");

                entity.Property(e => e.FadPerfil).HasColumnName("fad_perfil");

                entity.Property(e => e.FadSerie)
                    .HasColumnType("character varying")
                    .HasColumnName("fad_serie");

                entity.Property(e => e.FadSerieCorrelativo)
                    .HasColumnType("character varying")
                    .HasColumnName("fad_serie_correlativo");

                entity.Property(e => e.FadServicioPerfil)
                    .HasColumnType("character varying")
                    .HasColumnName("fad_servicio_perfil");

                entity.Property(e => e.FadSucursal)
                    .HasColumnType("character varying")
                    .HasColumnName("fad_sucursal");

                entity.Property(e => e.FadTicket)
                    .HasColumnType("character varying")
                    .HasColumnName("fad_ticket");

                entity.Property(e => e.FadUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("fad_usuario_creacion");

                entity.Property(e => e.FadUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("fad_usuario_modificacion");

                entity.Property(e => e.FadValorUnitarioDol)
                    .HasPrecision(13, 2)
                    .HasColumnName("fad_valor_unitario_dol");

                entity.Property(e => e.FadValorUnitarioIgvDol)
                    .HasPrecision(13, 2)
                    .HasColumnName("fad_valor_unitario_igv_dol");

                entity.Property(e => e.FadValorUnitarioIgvSol)
                    .HasPrecision(13, 2)
                    .HasColumnName("fad_valor_unitario_igv_sol");

                entity.Property(e => e.FadValorUnitarioSol)
                    .HasPrecision(13, 2)
                    .HasColumnName("fad_valor_unitario_sol");

                entity.Property(e => e.FadValorUnitarioTotalDol)
                    .HasPrecision(13, 2)
                    .HasColumnName("fad_valor_unitario_total_dol");

                entity.Property(e => e.FadValorUnitarioTotalSol)
                    .HasPrecision(13, 2)
                    .HasColumnName("fad_valor_unitario_total_sol");

                entity.HasOne(d => d.FadIdCabeceraNavigation)
                    .WithMany(p => p.DetFacturaDetalles)
                    .HasForeignKey(d => d.FadIdCabecera)
                    .HasConstraintName("DET_FACTURA_DETALLE_fad_id_cabecera_fkey");
            });

            modelBuilder.Entity<DetFacturaMedioPago>(entity =>
            {
                entity.HasKey(e => e.FmpId)
                    .HasName("DET_FACTURA_MEDIO_PAGO_pkey");

                entity.ToTable("DET_FACTURA_MEDIO_PAGO", "suizasoft");

                entity.HasIndex(e => e.FmpIdFactura, "IX_DET_FACTURA_MEDIO_PAGO_fmp_id_factura");

                entity.HasIndex(e => e.FmpIdMoneda, "IX_DET_FACTURA_MEDIO_PAGO_fmp_id_moneda");

                entity.HasIndex(e => e.FmpIdNotaCredito, "IX_DET_FACTURA_MEDIO_PAGO_fmp_id_nota_credito");

                entity.HasIndex(e => e.FmpIdPagoCuenta, "IX_DET_FACTURA_MEDIO_PAGO_fmp_id_pago_cuenta");

                entity.HasIndex(e => e.FmpIdTipoPago, "IX_DET_FACTURA_MEDIO_PAGO_fmp_id_tipo_pago");

                entity.HasIndex(e => e.FmpIdTipoTarjeta, "IX_DET_FACTURA_MEDIO_PAGO_fmp_id_tipo_tarjeta");

                entity.Property(e => e.FmpId).HasColumnName("fmp_id");

                entity.Property(e => e.FmpEnvioSap).HasColumnName("fmp_envio_sap");

                entity.Property(e => e.FmpEnvioSapRedondeo).HasColumnName("fmp_envio_sap_redondeo");

                entity.Property(e => e.FmpEstado).HasColumnName("fmp_estado");

                entity.Property(e => e.FmpFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fmp_fecha_creacion");

                entity.Property(e => e.FmpFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fmp_fecha_modificacion");

                entity.Property(e => e.FmpIdFactura).HasColumnName("fmp_id_factura");

                entity.Property(e => e.FmpIdMoneda).HasColumnName("fmp_id_moneda");

                entity.Property(e => e.FmpIdNotaCredito).HasColumnName("fmp_id_nota_credito");

                entity.Property(e => e.FmpIdPagoCuenta).HasColumnName("fmp_id_pago_cuenta");

                entity.Property(e => e.FmpIdTipoPago).HasColumnName("fmp_id_tipo_pago");

                entity.Property(e => e.FmpIdTipoTarjeta).HasColumnName("fmp_id_tipo_tarjeta");

                entity.Property(e => e.FmpIndexFormaPago).HasColumnName("fmp_index_forma_pago");

                entity.Property(e => e.FmpLote)
                    .HasColumnType("character varying")
                    .HasColumnName("fmp_lote");

                entity.Property(e => e.FmpMonto)
                    .HasPrecision(13, 2)
                    .HasColumnName("fmp_monto");

                entity.Property(e => e.FmpRedondeoCentimos)
                    .HasPrecision(13, 2)
                    .HasColumnName("fmp_redondeo_centimos");

                entity.Property(e => e.FmpReferenciaOperacion)
                    .HasColumnType("character varying")
                    .HasColumnName("fmp_referencia_operacion");

                entity.Property(e => e.FmpUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("fmp_usuario_creacion");

                entity.Property(e => e.FmpUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("fmp_usuario_modificacion");

                entity.Property(e => e.FmpVueltoPago)
                    .HasPrecision(13, 2)
                    .HasColumnName("fmp_vuelto_pago");

                entity.HasOne(d => d.FmpIdFacturaNavigation)
                    .WithMany(p => p.DetFacturaMedioPagos)
                    .HasForeignKey(d => d.FmpIdFactura)
                    .HasConstraintName("DET_FACTURA_MEDIO_PAGO_fmp_id_factura_fkey");

                entity.HasOne(d => d.FmpIdMonedaNavigation)
                    .WithMany(p => p.DetFacturaMedioPagos)
                    .HasForeignKey(d => d.FmpIdMoneda)
                    .HasConstraintName("DET_FACTURA_MEDIO_PAGO_fmp_id_moneda_fkey");

                entity.HasOne(d => d.FmpIdNotaCreditoNavigation)
                    .WithMany(p => p.DetFacturaMedioPagos)
                    .HasForeignKey(d => d.FmpIdNotaCredito)
                    .HasConstraintName("DET_FACTURA_MEDIO_PAGO_fmp_id_nota_credito_fkey");

                entity.HasOne(d => d.FmpIdPagoCuentaNavigation)
                    .WithMany(p => p.DetFacturaMedioPagos)
                    .HasForeignKey(d => d.FmpIdPagoCuenta)
                    .HasConstraintName("DET_FACTURA_MEDIO_PAGO_fmp_id_pago_cuenta_fkey");

                entity.HasOne(d => d.FmpIdTipoPagoNavigation)
                    .WithMany(p => p.DetFacturaMedioPagos)
                    .HasForeignKey(d => d.FmpIdTipoPago)
                    .HasConstraintName("DET_FACTURA_MEDIO_PAGO_fmp_id_tipo_pago_fkey");

                entity.HasOne(d => d.FmpIdTipoTarjetaNavigation)
                    .WithMany(p => p.DetFacturaMedioPagos)
                    .HasForeignKey(d => d.FmpIdTipoTarjeta)
                    .HasConstraintName("DET_FACTURA_MEDIO_PAGO_fmp_id_tipo_tarjeta_fkey");
            });

            modelBuilder.Entity<DetFacturaTicket>(entity =>
            {
                entity.HasKey(e => new { e.DftIdFactura, e.DftNumeroTicket })
                    .HasName("DET_FACTURA_TICKET_pkey");

                entity.ToTable("DET_FACTURA_TICKET", "suizasoft");

                entity.Property(e => e.DftIdFactura).HasColumnName("dft_id_factura");

                entity.Property(e => e.DftNumeroTicket)
                    .HasColumnType("character varying")
                    .HasColumnName("dft_numero_ticket");

                entity.Property(e => e.DftCantidadServicios).HasColumnName("dft_cantidad_servicios");

                entity.Property(e => e.DftEstado).HasColumnName("dft_estado");

                entity.Property(e => e.DftFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dft_fecha_creacion");

                entity.Property(e => e.DftFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dft_fecha_modificacion");

                entity.Property(e => e.DftNumeroDocumento)
                    .HasColumnType("character varying")
                    .HasColumnName("dft_numero_documento");

                entity.Property(e => e.DftPaciente)
                    .HasColumnType("character varying")
                    .HasColumnName("dft_paciente");

                entity.Property(e => e.DftUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dft_usuario_creacion");

                entity.Property(e => e.DftUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dft_usuario_modificacion");

                entity.HasOne(d => d.DftIdFacturaNavigation)
                    .WithMany(p => p.DetFacturaTickets)
                    .HasForeignKey(d => d.DftIdFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_FACTURA_TICKET_dft_id_factura_fkey");
            });

            modelBuilder.Entity<DetFormaterium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DET_FORMATERIA", "suizasoft");

                entity.Property(e => e.DfoCampo)
                    .HasColumnType("character varying")
                    .HasColumnName("dfo_campo");

                entity.Property(e => e.DfoFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dfo_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DfoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("dfo_id");

                entity.Property(e => e.DfoMfoId).HasColumnName("dfo_mfo_id");

                entity.Property(e => e.DfoTipoDato)
                    .HasMaxLength(10)
                    .HasColumnName("dfo_tipo_dato");
            });

            modelBuilder.Entity<DetLabLoteLaboratorioDetalle>(entity =>
            {
                entity.HasKey(e => e.LldId)
                    .HasName("DET_LAB_LOTE_LABORATORIO_DETALLE_pkey");

                entity.ToTable("DET_LAB_LOTE_LABORATORIO_DETALLE", "suizasoft");

                entity.Property(e => e.LldId).HasColumnName("lld_id");

                entity.Property(e => e.LldAnioTicket)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lld_anio_ticket")
                    .IsFixedLength();

                entity.Property(e => e.LldEstado).HasColumnName("lld_estado");

                entity.Property(e => e.LldIdCabecera).HasColumnName("lld_id_cabecera");

                entity.Property(e => e.LldIdTicket).HasColumnName("lld_id_ticket");

                entity.Property(e => e.LldPeriodoTicket)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lld_periodo_ticket")
                    .IsFixedLength();

                entity.Property(e => e.LldSucursalTicket)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lld_sucursal_ticket")
                    .IsFixedLength();
            });

            modelBuilder.Entity<DetLabMuestraRechazadaDetalle>(entity =>
            {
                entity.HasKey(e => new { e.MudIdMueRechazada, e.MudIdMuestra })
                    .HasName("DET_LAB_MUESTRA_RECHAZADA_DETALLE_pkey");

                entity.ToTable("DET_LAB_MUESTRA_RECHAZADA_DETALLE", "suizasoft");

                entity.HasIndex(e => e.MudIdMuestra, "IX_DET_LAB_MUESTRA_RECHAZADA_DETALLE_mud_id_muestra");

                entity.Property(e => e.MudIdMueRechazada).HasColumnName("mud_id_mue_rechazada");

                entity.Property(e => e.MudIdMuestra).HasColumnName("mud_id_muestra");

                entity.Property(e => e.MudEstado).HasColumnName("mud_estado");

                entity.Property(e => e.MudFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("mud_fecha_registro");

                entity.Property(e => e.MudUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("mud_usuario_registro");

                entity.HasOne(d => d.MudIdMueRechazadaNavigation)
                    .WithMany(p => p.DetLabMuestraRechazadaDetalles)
                    .HasForeignKey(d => d.MudIdMueRechazada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_MUESTRA_RECHAZADA_DET_muestra_rechazada_id_fkey");

                entity.HasOne(d => d.MudIdMuestraNavigation)
                    .WithMany(p => p.DetLabMuestraRechazadaDetalles)
                    .HasForeignKey(d => d.MudIdMuestra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_MUESTRA_RECHAZADA_DET_muestra_id_fkey");
            });

            modelBuilder.Entity<DetLabMuestraRechazadaImagen>(entity =>
            {
                entity.HasKey(e => new { e.MuiIdMueRechazada, e.MuiIdItem })
                    .HasName("DET_LAB_MUESTRA_RECHAZADA_IMAGEN_pkey");

                entity.ToTable("DET_LAB_MUESTRA_RECHAZADA_IMAGEN", "suizasoft");

                entity.Property(e => e.MuiIdMueRechazada).HasColumnName("mui_id_mue_rechazada");

                entity.Property(e => e.MuiIdItem).HasColumnName("mui_id_item");

                entity.Property(e => e.MuiEstado).HasColumnName("mui_estado");

                entity.Property(e => e.MuiFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("mui_fecha_registro");

                entity.Property(e => e.MuiImagen)
                    .HasColumnType("character varying")
                    .HasColumnName("mui_imagen");

                entity.Property(e => e.MuiUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("mui_usuario_registro");

                entity.HasOne(d => d.MuiIdMueRechazadaNavigation)
                    .WithMany(p => p.DetLabMuestraRechazadaImagens)
                    .HasForeignKey(d => d.MuiIdMueRechazada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MUESTRA_RECHAZADA_IMG_MUESTRA_RECHA_CAB_id_fkey");
            });

            modelBuilder.Entity<DetLabMuestraRechazadaMsj>(entity =>
            {
                entity.HasKey(e => new { e.MumIdMueRechazada, e.MumIdItem })
                    .HasName("DET_LAB_MUESTRA_RECHAZADA_MSJ_pkey");

                entity.ToTable("DET_LAB_MUESTRA_RECHAZADA_MSJ", "suizasoft");

                entity.Property(e => e.MumIdMueRechazada).HasColumnName("mum_id_mue_rechazada");

                entity.Property(e => e.MumIdItem).HasColumnName("mum_id_item");

                entity.Property(e => e.MumEstado).HasColumnName("mum_estado");

                entity.Property(e => e.MumFechaMensaje)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("mum_fecha_mensaje");

                entity.Property(e => e.MumMensaje)
                    .HasColumnType("character varying")
                    .HasColumnName("mum_mensaje");

                entity.Property(e => e.MumUsuarioMensaje)
                    .HasColumnType("character varying")
                    .HasColumnName("mum_usuario_mensaje");

                entity.HasOne(d => d.MumIdMueRechazadaNavigation)
                    .WithMany(p => p.DetLabMuestraRechazadaMsjs)
                    .HasForeignKey(d => d.MumIdMueRechazada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_LAB_MUESTRADET_MST_MUESTRA_CAB_fkey");
            });

            modelBuilder.Entity<DetLabOrdenImpresion>(entity =>
            {
                entity.HasKey(e => e.DloiId)
                    .HasName("DET_LAB_ORDEN_IMPRESION_pkey");

                entity.ToTable("DET_LAB_ORDEN_IMPRESION", "suizasoft");

                entity.HasIndex(e => e.DloiIdOrdenImpresion, "IX_DET_LAB_ORDEN_IMPRESION_dloi_id_orden_impresion");

                entity.Property(e => e.DloiId).HasColumnName("dloi_id");

                entity.Property(e => e.DloiIdOrdenImpresion).HasColumnName("dloi_id_orden_impresion");

                entity.Property(e => e.LoiEstado).HasColumnName("loi_estado");

                entity.Property(e => e.LoiFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("loi_fecha_creacion");

                entity.Property(e => e.LoiFlagPerfil).HasColumnName("loi_flag_perfil");

                entity.Property(e => e.LoiIdServicio).HasColumnName("loi_id_servicio");

                entity.Property(e => e.LoiTicketItem).HasColumnName("loi_ticket_item");

                entity.Property(e => e.LoiUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("loi_usuario_creacion");

                entity.HasOne(d => d.DloiIdOrdenImpresionNavigation)
                    .WithMany(p => p.DetLabOrdenImpresions)
                    .HasForeignKey(d => d.DloiIdOrdenImpresion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_LAB_ORDEN_IMPRESION_dloi_id_orden_impresion_fkey");
            });

            modelBuilder.Entity<DetLineaNegocioServicioArea>(entity =>
            {
                entity.HasKey(e => new { e.LnsLineaNegocioId, e.LnsAreaId })
                    .HasName("DET_LINEA_NEGOCIO_SERVICIO_AREA_pkey");

                entity.ToTable("DET_LINEA_NEGOCIO_SERVICIO_AREA", "suizasoft");

                entity.HasIndex(e => e.LnsAreaId, "IX_DET_LINEA_NEGOCIO_SERVICIO_AREA_lns_area_id");

                entity.Property(e => e.LnsLineaNegocioId).HasColumnName("lns_linea_negocio_id");

                entity.Property(e => e.LnsAreaId).HasColumnName("lns_area_id");

                entity.Property(e => e.LnsEstado).HasColumnName("lns_estado");

                entity.HasOne(d => d.LnsArea)
                    .WithMany(p => p.DetLineaNegocioServicioAreas)
                    .HasForeignKey(d => d.LnsAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_LINEA_NEGOCIO_SERVICIO_AREA_SERVICIO_AREA_fkey");

                entity.HasOne(d => d.LnsLineaNegocio)
                    .WithMany(p => p.DetLineaNegocioServicioAreas)
                    .HasForeignKey(d => d.LnsLineaNegocioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_LINEA_NEGOCIO_SERVICIO_AREA_LINEA_NEOGICO_fkey");
            });

            modelBuilder.Entity<DetMedicoAreaNegocio>(entity =>
            {
                entity.HasKey(e => new { e.DmanIdMedico, e.DmanIdAreaNegocio })
                    .HasName("DET_MEDICO_AREA_NEGOCIO_pkey");

                entity.ToTable("DET_MEDICO_AREA_NEGOCIO", "suizasoft");

                entity.HasIndex(e => e.DmanIdAreaNegocio, "IX_DET_MEDICO_AREA_NEGOCIO_dman_id_area_negocio");

                entity.Property(e => e.DmanIdMedico).HasColumnName("dman_id_medico");

                entity.Property(e => e.DmanIdAreaNegocio).HasColumnName("dman_id_area_negocio");

                entity.Property(e => e.DmanEstado).HasColumnName("dman_estado");

                entity.Property(e => e.DmanFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dman_fecha_creacion");

                entity.Property(e => e.DmanFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dman_fecha_modificacion");

                entity.Property(e => e.DmanUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("dman_usuario_creacion");

                entity.Property(e => e.DmanUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dman_usuario_modificacion");

                entity.HasOne(d => d.DmanIdAreaNegocioNavigation)
                    .WithMany(p => p.DetMedicoAreaNegocios)
                    .HasForeignKey(d => d.DmanIdAreaNegocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_MEDICO_AREA_NEGOCIO_dman_id_area_negocio_fkey");

                entity.HasOne(d => d.DmanIdMedicoNavigation)
                    .WithMany(p => p.DetMedicoAreaNegocios)
                    .HasForeignKey(d => d.DmanIdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_MEDICO_AREA_NEGOCIO_dman_id_medico_fkey");
            });

            modelBuilder.Entity<DetMedicoHorario>(entity =>
            {
                entity.HasKey(e => e.DmhId)
                    .HasName("DET_MEDICO_HORARIO_pkey");

                entity.ToTable("DET_MEDICO_HORARIO", "suizasoft");

                entity.HasIndex(e => e.DmhIdEspecialidad, "IX_DET_MEDICO_HORARIO_dmh_id_especialidad");

                entity.HasIndex(e => e.DmhIdMedico, "IX_DET_MEDICO_HORARIO_dmh_id_medico");

                entity.HasIndex(e => e.DmhIdSucursal, "IX_DET_MEDICO_HORARIO_dmh_id_sucursal");

                entity.Property(e => e.DmhId).HasColumnName("dmh_id");

                entity.Property(e => e.DmhDia)
                    .HasColumnType("character varying")
                    .HasColumnName("dmh_dia");

                entity.Property(e => e.DmhEstado).HasColumnName("dmh_estado");

                entity.Property(e => e.DmhFecha).HasColumnName("dmh_fecha");

                entity.Property(e => e.DmhFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dmh_fecha_creacion");

                entity.Property(e => e.DmhFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dmh_fecha_modificacion");

                entity.Property(e => e.DmhHoraFin).HasColumnName("dmh_hora_fin");

                entity.Property(e => e.DmhHoraInicio).HasColumnName("dmh_hora_inicio");

                entity.Property(e => e.DmhIdEspecialidad).HasColumnName("dmh_id_especialidad");

                entity.Property(e => e.DmhIdMedico).HasColumnName("dmh_id_medico");

                entity.Property(e => e.DmhIdSucursal)
                    .HasColumnType("character varying")
                    .HasColumnName("dmh_id_sucursal");

                entity.Property(e => e.DmhTiempoAtencion).HasColumnName("dmh_tiempo_atencion");

                entity.Property(e => e.DmhUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dmh_usuario_creacion");

                entity.Property(e => e.DmhUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dmh_usuario_modificacion");

                entity.HasOne(d => d.DmhIdEspecialidadNavigation)
                    .WithMany(p => p.DetMedicoHorarios)
                    .HasForeignKey(d => d.DmhIdEspecialidad)
                    .HasConstraintName("DET_MEDICO_HORARIO_dmh_id_especialidad_fkey");

                entity.HasOne(d => d.DmhIdMedicoNavigation)
                    .WithMany(p => p.DetMedicoHorarios)
                    .HasForeignKey(d => d.DmhIdMedico)
                    .HasConstraintName("DET_MEDICO_HORARIO_dmh_id_medico_fkey");

                entity.HasOne(d => d.DmhIdSucursalNavigation)
                    .WithMany(p => p.DetMedicoHorarios)
                    .HasForeignKey(d => d.DmhIdSucursal)
                    .HasConstraintName("DET_MEDICO_HORARIO_dmh_id_sucursal_fkey");
            });

            modelBuilder.Entity<DetMedicoRolCentroMedico>(entity =>
            {
                entity.HasKey(e => new { e.DmrCmIdRol, e.DmrCmIdMedico })
                    .HasName("DET_MEDICO_ROL_CENTRO_MEDICO_pkey");

                entity.ToTable("DET_MEDICO_ROL_CENTRO_MEDICO", "suizasoft");

                entity.HasIndex(e => e.DmrCmIdMedico, "IX_DET_MEDICO_ROL_CENTRO_MEDICO_dmr_cm_id_medico");

                entity.Property(e => e.DmrCmIdRol).HasColumnName("dmr_cm_id_rol");

                entity.Property(e => e.DmrCmIdMedico).HasColumnName("dmr_cm_id_medico");

                entity.Property(e => e.DcmEstado).HasColumnName("dcm_estado");

                entity.Property(e => e.DcmFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dcm_fecha_creacion");

                entity.Property(e => e.DcmFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dcm_fecha_modificacion");

                entity.Property(e => e.DcmUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("dcm_usuario_creacion");

                entity.Property(e => e.DcmUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dcm_usuario_modificacion");

                entity.HasOne(d => d.DmrCmIdMedicoNavigation)
                    .WithMany(p => p.DetMedicoRolCentroMedicos)
                    .HasForeignKey(d => d.DmrCmIdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_MEDICO_ROL_CENTRO_MEDICO_dmr_cm_id_medico_fkey");

                entity.HasOne(d => d.DmrCmIdRolNavigation)
                    .WithMany(p => p.DetMedicoRolCentroMedicos)
                    .HasForeignKey(d => d.DmrCmIdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_MEDICO_ROL_CENTRO_MEDICO_dmr_cm_id_rol_fkey");
            });

            modelBuilder.Entity<DetMedicoSede>(entity =>
            {
                entity.HasKey(e => e.DmsId)
                    .HasName("DET_MEDICO_SEDE_pkey");

                entity.ToTable("DET_MEDICO_SEDE", "suizasoft");

                entity.HasIndex(e => new { e.DmsIdMedico, e.DmsIdSede }, "DET_MEDICO_SEDE_dms_id_medico_dms_id_sede_key")
                    .IsUnique();

                entity.HasIndex(e => e.DmsIdSede, "IX_DET_MEDICO_SEDE_dms_id_sede");

                entity.Property(e => e.DmsId).HasColumnName("dms_id");

                entity.Property(e => e.DmsEstado).HasColumnName("dms_estado");

                entity.Property(e => e.DmsFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dms_fecha_creacion");

                entity.Property(e => e.DmsFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dms_fecha_modificacion");

                entity.Property(e => e.DmsIdMedico).HasColumnName("dms_id_medico");

                entity.Property(e => e.DmsIdSede)
                    .HasColumnType("character varying")
                    .HasColumnName("dms_id_sede");

                entity.Property(e => e.DmsUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dms_usuario_creacion");

                entity.Property(e => e.DmsUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dms_usuario_modificacion");

                entity.HasOne(d => d.DmsIdMedicoNavigation)
                    .WithMany(p => p.DetMedicoSedes)
                    .HasForeignKey(d => d.DmsIdMedico)
                    .HasConstraintName("DET_MEDICO_SEDE_dms_id_medico_fkey");

                entity.HasOne(d => d.DmsIdSedeNavigation)
                    .WithMany(p => p.DetMedicoSedes)
                    .HasForeignKey(d => d.DmsIdSede)
                    .HasConstraintName("DET_MEDICO_SEDE_dms_id_sede_fkey");
            });

            modelBuilder.Entity<DetNotaCreditoDetalle>(entity =>
            {
                entity.HasKey(e => e.NcdId)
                    .HasName("DET_NOTA_CREDITO_DETALLE_pkey");

                entity.ToTable("DET_NOTA_CREDITO_DETALLE", "suizasoft");

                entity.HasIndex(e => e.NcdIdCabecera, "IX_DET_NOTA_CREDITO_DETALLE_ncd_id_cabecera");

                entity.HasIndex(e => e.NcdIdServicio, "IX_DET_NOTA_CREDITO_DETALLE_ncd_id_servicio");

                entity.HasIndex(e => e.NcdIdTipoDocVenta, "IX_DET_NOTA_CREDITO_DETALLE_ncd_id_tipo_doc_venta");

                entity.HasIndex(e => e.NcdSucursal, "IX_DET_NOTA_CREDITO_DETALLE_ncd_sucursal");

                entity.Property(e => e.NcdId).HasColumnName("ncd_id");

                entity.Property(e => e.NcdCorrelativo).HasColumnName("ncd_correlativo");

                entity.Property(e => e.NcdDescuentoManual).HasColumnName("ncd_descuento_manual");

                entity.Property(e => e.NcdFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ncd_fecha_creacion");

                entity.Property(e => e.NcdFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ncd_fecha_modificacion");

                entity.Property(e => e.NcdIdCabecera).HasColumnName("ncd_id_cabecera");

                entity.Property(e => e.NcdIdServicio).HasColumnName("ncd_id_servicio");

                entity.Property(e => e.NcdIdTipoDocVenta).HasColumnName("ncd_id_tipo_doc_venta");

                entity.Property(e => e.NcdIndex).HasColumnName("ncd_index");

                entity.Property(e => e.NcdSerie)
                    .HasColumnType("character varying")
                    .HasColumnName("ncd_serie");

                entity.Property(e => e.NcdSucursal)
                    .HasColumnType("character varying")
                    .HasColumnName("ncd_sucursal");

                entity.Property(e => e.NcdTicket)
                    .HasColumnType("character varying")
                    .HasColumnName("ncd_ticket");

                entity.Property(e => e.NcdUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ncd_usuario_creacion");

                entity.Property(e => e.NcdUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ncd_usuario_modificacion");

                entity.Property(e => e.NcdValorUnitarioDol)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncd_valor_unitario_dol");

                entity.Property(e => e.NcdValorUnitarioIgvDol)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncd_valor_unitario_igv_dol");

                entity.Property(e => e.NcdValorUnitarioIgvSol)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncd_valor_unitario_igv_sol");

                entity.Property(e => e.NcdValorUnitarioSol)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncd_valor_unitario_sol");

                entity.Property(e => e.NcdValorUnitarioTotalDol)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncd_valor_unitario_total_dol");

                entity.Property(e => e.NcdValorUnitarioTotalSol)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncd_valor_unitario_total_sol");

                entity.HasOne(d => d.NcdIdCabeceraNavigation)
                    .WithMany(p => p.DetNotaCreditoDetalles)
                    .HasForeignKey(d => d.NcdIdCabecera)
                    .HasConstraintName("DET_NOTA_CREDITO_DETALLE_ncd_id_cabecera_fkey");

                entity.HasOne(d => d.NcdIdServicioNavigation)
                    .WithMany(p => p.DetNotaCreditoDetalles)
                    .HasForeignKey(d => d.NcdIdServicio)
                    .HasConstraintName("DET_NOTA_CREDITO_DETALLE_ncd_id_servicio_fkey");

                entity.HasOne(d => d.NcdIdTipoDocVentaNavigation)
                    .WithMany(p => p.DetNotaCreditoDetalles)
                    .HasForeignKey(d => d.NcdIdTipoDocVenta)
                    .HasConstraintName("DET_NOTA_CREDITO_DETALLE_ncd_id_tipo_doc_venta_fkey");

                entity.HasOne(d => d.NcdSucursalNavigation)
                    .WithMany(p => p.DetNotaCreditoDetalles)
                    .HasForeignKey(d => d.NcdSucursal)
                    .HasConstraintName("DET_NOTA_CREDITO_DETALLE_ncd_sucursal_fkey");
            });

            modelBuilder.Entity<DetOrdenMedicaDigital>(entity =>
            {
                entity.HasKey(e => e.DomId)
                    .HasName("DET_ORDEN_MEDICA_DIGITAL_pkey");

                entity.ToTable("DET_ORDEN_MEDICA_DIGITAL", "suizasoft");

                entity.Property(e => e.DomId)
                    .ValueGeneratedNever()
                    .HasColumnName("dom_id");

                entity.Property(e => e.DomFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dom_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DomFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dom_fecha_modificacion");

                entity.Property(e => e.DomItem).HasColumnName("dom_item");

                entity.Property(e => e.DomOmdAnio)
                    .HasMaxLength(2)
                    .HasColumnName("dom_omd_anio")
                    .IsFixedLength();

                entity.Property(e => e.DomOmdId).HasColumnName("dom_omd_id");

                entity.Property(e => e.DomOmdPeriodo)
                    .HasMaxLength(2)
                    .HasColumnName("dom_omd_periodo")
                    .IsFixedLength();

                entity.Property(e => e.DomOmdSucId)
                    .HasMaxLength(2)
                    .HasColumnName("dom_omd_suc_id")
                    .IsFixedLength();

                entity.Property(e => e.DomSerCodigo).HasColumnName("dom_ser_codigo");

                entity.Property(e => e.DomSerFox)
                    .HasMaxLength(6)
                    .HasColumnName("dom_ser_fox");
            });

            modelBuilder.Entity<DetOrdenServicioDetalle>(entity =>
            {
                entity.HasKey(e => new { e.OrdIdNumeroCab, e.OrdPeriodo, e.OrdAnio, e.OrdIdSucursal, e.OrdItem })
                    .HasName("DET_ORDEN_SERVICIO_DETALLE2_pkey");

                entity.ToTable("DET_ORDEN_SERVICIO_DETALLE", "suizasoft");

                entity.Property(e => e.OrdIdNumeroCab).HasColumnName("ord_id_numero_cab");

                entity.Property(e => e.OrdPeriodo)
                    .HasMaxLength(2)
                    .HasColumnName("ord_periodo")
                    .IsFixedLength();

                entity.Property(e => e.OrdAnio)
                    .HasMaxLength(2)
                    .HasColumnName("ord_anio")
                    .IsFixedLength();

                entity.Property(e => e.OrdIdSucursal)
                    .HasMaxLength(2)
                    .HasColumnName("ord_id_sucursal")
                    .IsFixedLength();

                entity.Property(e => e.OrdItem)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ord_item");

                entity.Property(e => e.OrdAsignacionMedico)
                    .HasColumnName("ord_asignacion_medico")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdBiopsia)
                    .HasColumnName("ord_biopsia")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdCantidadServicio)
                    .HasColumnName("ord_cantidad_servicio")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OrdEnvioEnterpriseFlag).HasColumnName("ord_envio_enterprise_flag");

                entity.Property(e => e.OrdFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ord_fecha_modificacion");

                entity.Property(e => e.OrdFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ord_fecha_registro");

                entity.Property(e => e.OrdFlagRegistroLab)
                    .HasColumnName("ord_flag_registro_lab")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdFlagSolicitudModificacionPendiente)
                    .HasColumnName("ord_flag_solicitud_modificacion_pendiente")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdIdEstadoAtencion)
                    .HasColumnName("ord_id_estado_atencion")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OrdIdPaquete).HasColumnName("ord_id_paquete");

                entity.Property(e => e.OrdIdServicioPerfil).HasColumnName("ord_id_servicio_perfil");

                entity.Property(e => e.OrdLabEnvioFlag)
                    .HasColumnName("ord_lab_envio_flag")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdLabEnvioFlagInfinity)
                    .HasColumnName("ord_lab_envio_flag_infinity")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdLabEnvioFlagIntelicheck)
                    .HasColumnName("ord_lab_envio_flag_intelicheck")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdLabFechaEnvio)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ord_lab_fecha_envio");

                entity.Property(e => e.OrdLabFlag)
                    .HasColumnName("ord_lab_flag")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdLabImpresionFlag)
                    .HasColumnName("ord_lab_impresion_flag")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdLabMueFlag)
                    .HasColumnName("ord_lab_mue_flag")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdLabReprocesoFlag)
                    .HasColumnName("ord_lab_reproceso_flag")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdLabValFlag)
                    .HasColumnName("ord_lab_val_flag")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdPaqueteFlag).HasColumnName("ord_paquete_flag");

                entity.Property(e => e.OrdPerfil)
                    .HasColumnName("ord_perfil")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdPrecioDolar)
                    .HasPrecision(13, 3)
                    .HasColumnName("ord_precio_dolar");

                entity.Property(e => e.OrdPrecioSol)
                    .HasPrecision(13, 3)
                    .HasColumnName("ord_precio_sol");

                entity.Property(e => e.OrdSubTotal)
                    .HasPrecision(13, 3)
                    .HasColumnName("ord_sub_total");

                entity.Property(e => e.OrdUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ord_usuario_modificacion");

                entity.Property(e => e.OrdUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("ord_usuario_registro");

                entity.Property(e => e.OrdValorDescuento)
                    .HasPrecision(13, 3)
                    .HasColumnName("ord_valor_descuento");

                entity.Property(e => e.OrdValorPrecioCantidad)
                    .HasPrecision(13, 3)
                    .HasColumnName("ord_valor_precio_cantidad");

                entity.Property(e => e.OrdValorPrecioUnitario)
                    .HasPrecision(13, 3)
                    .HasColumnName("ord_valor_precio_unitario");

                entity.Property(e => e.OrdValorUnitarioConIgv)
                    .HasPrecision(13, 3)
                    .HasColumnName("ord_valor_unitario_con_igv");

                entity.Property(e => e.OrdValorUnitarioSinIgv)
                    .HasPrecision(13, 3)
                    .HasColumnName("ord_valor_unitario_sin_igv");
            });

            modelBuilder.Entity<DetOrdenServicioOrdenMedica>(entity =>
            {
                entity.HasKey(e => e.DosomId)
                    .HasName("DET_ORDEN_SERVICIO_ORDEN_MEDICA_pkey");

                entity.ToTable("DET_ORDEN_SERVICIO_ORDEN_MEDICA", "suizasoft");

                entity.HasIndex(e => new { e.DosomTicketId, e.DosomTicketPeriodo, e.DosomTicketAnio, e.DosomTicketIdSucursal }, "IX_DET_ORDEN_SERVICIO_ORDEN_MEDICA_dosom_ticket_id_dosom_ticke~");

                entity.Property(e => e.DosomId).HasColumnName("dosom_id");

                entity.Property(e => e.DosomEstado).HasColumnName("dosom_estado");

                entity.Property(e => e.DosomFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dosom_fecha_creacion");

                entity.Property(e => e.DosomFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dosom_fecha_modificacion");

                entity.Property(e => e.DosomNombreArchivo)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("dosom_nombre_archivo");

                entity.Property(e => e.DosomRutaOrdenMedica)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("dosom_ruta_orden_medica");

                entity.Property(e => e.DosomTicketAnio)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("dosom_ticket_anio")
                    .IsFixedLength();

                entity.Property(e => e.DosomTicketId).HasColumnName("dosom_ticket_id");

                entity.Property(e => e.DosomTicketIdSucursal)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("dosom_ticket_id_sucursal")
                    .IsFixedLength();

                entity.Property(e => e.DosomTicketPeriodo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("dosom_ticket_periodo")
                    .IsFixedLength();

                entity.Property(e => e.DosomUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("dosom_usuario_creacion");

                entity.Property(e => e.DosomUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dosom_usuario_modificacion");

                entity.HasOne(d => d.DosomTicket)
                    .WithMany(p => p.DetOrdenServicioOrdenMedicas)
                    .HasForeignKey(d => new { d.DosomTicketId, d.DosomTicketPeriodo, d.DosomTicketAnio, d.DosomTicketIdSucursal })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("det_orden_servicio_orden_medica_orden_cab_fk");
            });

            modelBuilder.Entity<DetOrdenTrazabilidad>(entity =>
            {
                entity.HasKey(e => e.DotOrdenId)
                    .HasName("DET_ORDEN_TRAZABILIDAD_pkey");

                entity.ToTable("DET_ORDEN_TRAZABILIDAD", "suizasoft");

                entity.Property(e => e.DotOrdenId).HasColumnName("dot_orden_id");

                entity.Property(e => e.DotEstado).HasColumnName("dot_estado");

                entity.Property(e => e.DotFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dot_fecha_creacion");

                entity.Property(e => e.DotMuestra).HasColumnName("dot_muestra");

                entity.Property(e => e.DotOrden)
                    .HasColumnType("character varying")
                    .HasColumnName("dot_orden");

                entity.Property(e => e.DotUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dot_usuario_creacion");
            });

            modelBuilder.Entity<DetPacienteCompaniaRiesgo>(entity =>
            {
                entity.HasKey(e => new { e.DpcrIdPacienteCompania, e.DpcrIdTipoRiesgo })
                    .HasName("DET_PACIENTE_COMPANIA_RIESGO_pkey");

                entity.ToTable("DET_PACIENTE_COMPANIA_RIESGO", "suizasoft");

                entity.HasIndex(e => e.DpcrIdTipoRiesgo, "IX_DET_PACIENTE_COMPANIA_RIESGO_dpcr_id_tipo_riesgo");

                entity.Property(e => e.DpcrIdPacienteCompania).HasColumnName("dpcr_id_paciente_compania");

                entity.Property(e => e.DpcrIdTipoRiesgo).HasColumnName("dpcr_id_tipo_riesgo");

                entity.Property(e => e.DpcrEstado).HasColumnName("dpcr_estado");

                entity.Property(e => e.DpcrFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dpcr_fecha_creacion");

                entity.Property(e => e.DpcrFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dpcr_fecha_modificacion");

                entity.Property(e => e.DpcrUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("dpcr_usuario_creacion");

                entity.Property(e => e.DpcrUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dpcr_usuario_modificacion");

                entity.HasOne(d => d.DpcrIdPacienteCompaniaNavigation)
                    .WithMany(p => p.DetPacienteCompaniaRiesgos)
                    .HasForeignKey(d => d.DpcrIdPacienteCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_PACIENTE_COMPANIA_dpcr_id_paciente_compania_fkey");

                entity.HasOne(d => d.DpcrIdTipoRiesgoNavigation)
                    .WithMany(p => p.DetPacienteCompaniaRiesgos)
                    .HasForeignKey(d => d.DpcrIdTipoRiesgo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_PACIENTE_COMPANIA_dpcr_id_tipo_riesgo_fkey");
            });

            modelBuilder.Entity<DetPacienteCompanium>(entity =>
            {
                entity.HasKey(e => e.DpcId)
                    .HasName("DET_PACIENTE_COMPANIA_pkey");

                entity.ToTable("DET_PACIENTE_COMPANIA", "suizasoft");

                entity.HasIndex(e => e.DpcIdCompania, "IX_DET_PACIENTE_COMPANIA_dpc_id_compania");

                entity.HasIndex(e => e.DpcIdPaciente, "IX_DET_PACIENTE_COMPANIA_dpc_id_paciente");

                entity.Property(e => e.DpcId).HasColumnName("dpc_id");

                entity.Property(e => e.DpcArea)
                    .HasMaxLength(200)
                    .HasColumnName("dpc_area");

                entity.Property(e => e.DpcCargo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("dpc_cargo");

                entity.Property(e => e.DpcEstado).HasColumnName("dpc_estado");

                entity.Property(e => e.DpcFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dpc_fecha_creacion");

                entity.Property(e => e.DpcFechaFinLaboral).HasColumnName("dpc_fecha_fin_laboral");

                entity.Property(e => e.DpcFechaInicioLaboral).HasColumnName("dpc_fecha_inicio_laboral");

                entity.Property(e => e.DpcFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dpc_fecha_modificacion");

                entity.Property(e => e.DpcFlagActual).HasColumnName("dpc_flag_actual");

                entity.Property(e => e.DpcHorasLaboral).HasColumnName("dpc_horas_laboral");

                entity.Property(e => e.DpcIdCompania).HasColumnName("dpc_id_compania");

                entity.Property(e => e.DpcIdPaciente).HasColumnName("dpc_id_paciente");

                entity.Property(e => e.DpcNroDiasLaboral)
                    .HasColumnName("dpc_nro_dias_laboral")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DpcUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("dpc_usuario_creacion");

                entity.Property(e => e.DpcUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dpc_usuario_modificacion");

                entity.HasOne(d => d.DpcIdCompaniaNavigation)
                    .WithMany(p => p.DetPacienteCompania)
                    .HasForeignKey(d => d.DpcIdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_PACIENTE_COMPANIA_dpc_id_compania_fkey");

                entity.HasOne(d => d.DpcIdPacienteNavigation)
                    .WithMany(p => p.DetPacienteCompania)
                    .HasForeignKey(d => d.DpcIdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_PACIENTE_COMPANIA_dpc_id_paciente_fkey");
            });

            modelBuilder.Entity<DetPaqueteDetalle>(entity =>
            {
                entity.HasKey(e => new { e.PadIdPaqueteCab, e.PadIdservicio })
                    .HasName("MST_PAQUETE_DETALLE_pkey");

                entity.ToTable("DET_PAQUETE_DETALLE", "suizasoft");

                entity.HasIndex(e => e.PadIdservicio, "IX_DET_PAQUETE_DETALLE_pad_idservicio");

                entity.Property(e => e.PadIdPaqueteCab).HasColumnName("pad_id_paquete_cab");

                entity.Property(e => e.PadIdservicio).HasColumnName("pad_idservicio");

                entity.Property(e => e.PadCostoMinimoServicio)
                    .HasPrecision(13, 2)
                    .HasColumnName("pad_costo_minimo_servicio");

                entity.Property(e => e.PadFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pad_fecha_creacion");

                entity.Property(e => e.PadFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pad_fecha_modificacion");

                entity.Property(e => e.PadNumano)
                    .HasColumnType("character varying")
                    .HasColumnName("pad_numano");

                entity.Property(e => e.PadNumfox)
                    .HasColumnType("character varying")
                    .HasColumnName("pad_numfox");

                entity.Property(e => e.PadNumfpers)
                    .HasColumnType("character varying")
                    .HasColumnName("pad_numfpers");

                entity.Property(e => e.PadNumpqc)
                    .HasColumnType("character varying")
                    .HasColumnName("pad_numpqc");

                entity.Property(e => e.PadNumtfp)
                    .HasColumnType("character varying")
                    .HasColumnName("pad_numtfp");

                entity.Property(e => e.PadUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("pad_usuario_creacion");

                entity.Property(e => e.PadUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("pad_usuario_modificacion");

                entity.Property(e => e.PadValorUnitarioConIgv)
                    .HasPrecision(13, 2)
                    .HasColumnName("pad_valor_unitario_con_igv");

                entity.Property(e => e.PadValorUnitarioSinIgv)
                    .HasPrecision(13, 2)
                    .HasColumnName("pad_valor_unitario_sin_igv");

                entity.HasOne(d => d.PadIdPaqueteCabNavigation)
                    .WithMany(p => p.DetPaqueteDetalles)
                    .HasForeignKey(d => d.PadIdPaqueteCab)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_PAQUETE_DETALLE_pad_id_paq_fkey");

                entity.HasOne(d => d.PadIdservicioNavigation)
                    .WithMany(p => p.DetPaqueteDetalles)
                    .HasForeignKey(d => d.PadIdservicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("paquetedetalle_servicio_fk");
            });

            modelBuilder.Entity<DetPerfilResultado>(entity =>
            {
                entity.HasKey(e => new { e.PrIdServicio, e.PrIdCatalogo })
                    .HasName("DET_PERFIL_RESULTADOS_pkey");

                entity.ToTable("DET_PERFIL_RESULTADOS", "suizasoft");

                entity.Property(e => e.PrIdServicio).HasColumnName("pr_id_servicio");

                entity.Property(e => e.PrIdCatalogo).HasColumnName("pr_id_catalogo");

                entity.Property(e => e.PrFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pr_fecha_creacion");

                entity.Property(e => e.PrUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("pr_usuario_creacion");

                entity.HasOne(d => d.PrIdCatalogoNavigation)
                    .WithMany(p => p.DetPerfilResultados)
                    .HasForeignKey(d => d.PrIdCatalogo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_PERFIL_RESULTADOS_pr_id_catalogo_fkey");

                entity.HasOne(d => d.PrIdServicioNavigation)
                    .WithMany(p => p.DetPerfilResultados)
                    .HasForeignKey(d => d.PrIdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_PERFIL_RESULTADOS_pr_id_servicio_fkey");
            });

            modelBuilder.Entity<DetPreticketDetalle>(entity =>
            {
                entity.HasKey(e => new { e.PrdIdNumeroCab, e.PrdPeriodo, e.PrdAnio, e.PrdIdSucursal, e.PrdIdServicio })
                    .HasName("DET_PRETICKET_DETALLE_pkey");

                entity.ToTable("DET_PRETICKET_DETALLE", "suizasoft");

                entity.HasIndex(e => e.PrdIdServicio, "IX_DET_PRETICKET_DETALLE_prd_id_servicio");

                entity.Property(e => e.PrdIdNumeroCab).HasColumnName("prd_id_numero_cab");

                entity.Property(e => e.PrdPeriodo)
                    .HasMaxLength(2)
                    .HasColumnName("prd_periodo")
                    .IsFixedLength();

                entity.Property(e => e.PrdAnio)
                    .HasMaxLength(2)
                    .HasColumnName("prd_anio")
                    .IsFixedLength();

                entity.Property(e => e.PrdIdSucursal)
                    .HasMaxLength(2)
                    .HasColumnName("prd_id_sucursal")
                    .IsFixedLength();

                entity.Property(e => e.PrdIdServicio).HasColumnName("prd_id_servicio");

                entity.Property(e => e.PrdAsignacionMedico).HasColumnName("prd_asignacion_medico");

                entity.Property(e => e.PrdCantidadServicio)
                    .HasColumnName("prd_cantidad_servicio")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PrdEnvioEnterpriseFlag).HasColumnName("prd_envio_enterprise_flag");

                entity.Property(e => e.PrdFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("prd_fecha_modificacion");

                entity.Property(e => e.PrdFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("prd_fecha_registro");

                entity.Property(e => e.PrdIdPaquete).HasColumnName("prd_id_paquete");

                entity.Property(e => e.PrdPaqueteFlag).HasColumnName("prd_paquete_flag");

                entity.Property(e => e.PrdPrecioDolar)
                    .HasPrecision(13, 3)
                    .HasColumnName("prd_precio_dolar");

                entity.Property(e => e.PrdPrecioSol)
                    .HasPrecision(13, 3)
                    .HasColumnName("prd_precio_sol");

                entity.Property(e => e.PrdSubTotal)
                    .HasPrecision(13, 3)
                    .HasColumnName("prd_sub_total");

                entity.Property(e => e.PrdUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("prd_usuario_modificacion");

                entity.Property(e => e.PrdUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("prd_usuario_registro");

                entity.Property(e => e.PrdValorDescuento)
                    .HasPrecision(13, 3)
                    .HasColumnName("prd_valor_descuento");

                entity.Property(e => e.PrdValorPrecioCantidad)
                    .HasPrecision(13, 3)
                    .HasColumnName("prd_valor_precio_cantidad");

                entity.Property(e => e.PrdValorPrecioUnitario)
                    .HasPrecision(13, 3)
                    .HasColumnName("prd_valor_precio_unitario");

                entity.Property(e => e.PrdValorUnitarioConIgv)
                    .HasPrecision(13, 3)
                    .HasColumnName("prd_valor_unitario_con_igv");

                entity.Property(e => e.PrdValorUnitarioSinIgv)
                    .HasPrecision(13, 3)
                    .HasColumnName("prd_valor_unitario_sin_igv");

                entity.HasOne(d => d.PrdIdServicioNavigation)
                    .WithMany(p => p.DetPreticketDetalles)
                    .HasForeignKey(d => d.PrdIdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orden_preticket_det_servicio_fk");
            });

            modelBuilder.Entity<DetRuteoDetalleSeguro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DET_RUTEO_DETALLE_SEGUROS", "suizasoft");

                entity.Property(e => e.RudEstado).HasColumnName("rud_estado");

                entity.Property(e => e.RudFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("rud_fecha_modificacion");

                entity.Property(e => e.RudFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("rud_fecha_registro");

                entity.Property(e => e.RudHoraFin).HasColumnName("rud_hora_fin");

                entity.Property(e => e.RudHoraInicio).HasColumnName("rud_hora_inicio");

                entity.Property(e => e.RudIdCita).HasColumnName("rud_id_cita");

                entity.Property(e => e.RudIdMedico).HasColumnName("rud_id_medico");

                entity.Property(e => e.RudIdRuteoCabecera)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rud_id_ruteo_cabecera");

                entity.Property(e => e.RudUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("rud_usuario_modificacion");

                entity.Property(e => e.RudUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("rud_usuario_registro");
            });

            modelBuilder.Entity<DetServicioMuestraLaboratorio>(entity =>
            {
                entity.HasKey(e => e.SemId)
                    .HasName("MST_SERVICIO_MUESTRA_LABORATORIO_pkey");

                entity.ToTable("DET_SERVICIO_MUESTRA_LABORATORIO", "suizasoft");

                entity.HasIndex(e => e.SemIdMuestra, "IX_DET_SERVICIO_MUESTRA_LABORATORIO_sem_id_muestra");

                entity.Property(e => e.SemId).HasColumnName("sem_id");

                entity.Property(e => e.SemEstado)
                    .HasColumnName("sem_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SemFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("sem_fecha_modificacion");

                entity.Property(e => e.SemFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("sem_fecha_registro");

                entity.Property(e => e.SemFlagPerfil)
                    .HasColumnName("sem_flag_perfil")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SemIdMuestra).HasColumnName("sem_id_muestra");

                entity.Property(e => e.SemIdServicio).HasColumnName("sem_id_servicio");

                entity.Property(e => e.SemUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("sem_usuario_modificacion");

                entity.Property(e => e.SemUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("sem_usuario_registro");

                entity.HasOne(d => d.SemIdMuestraNavigation)
                    .WithMany(p => p.DetServicioMuestraLaboratorios)
                    .HasForeignKey(d => d.SemIdMuestra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicio_muestra_lab_muestra_idmuestra_fk");
            });

            modelBuilder.Entity<DetServicioResultado>(entity =>
            {
                entity.HasKey(e => new { e.SrIdServicio, e.SrIdCatalogo })
                    .HasName("DET_SERVICIO_RESULTADOS_pkey");

                entity.ToTable("DET_SERVICIO_RESULTADOS", "suizasoft");

                entity.Property(e => e.SrIdServicio).HasColumnName("sr_id_servicio");

                entity.Property(e => e.SrIdCatalogo).HasColumnName("sr_id_catalogo");

                entity.Property(e => e.SrFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("sr_fecha_creacion");

                entity.Property(e => e.SrUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("sr_usuario_creacion");

                entity.HasOne(d => d.SrIdCatalogoNavigation)
                    .WithMany(p => p.DetServicioResultados)
                    .HasForeignKey(d => d.SrIdCatalogo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_SERVICIO_RESULTADOS_sr_id_catalogo_fkey");

                entity.HasOne(d => d.SrIdServicioNavigation)
                    .WithMany(p => p.DetServicioResultados)
                    .HasForeignKey(d => d.SrIdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_SERVICIO_RESULTADOS_sr_id_servicio_fkey");
            });

            modelBuilder.Entity<DetServicioSede>(entity =>
            {
                entity.HasKey(e => e.DssId)
                    .HasName("DET_SERVICIO_SEDE_pkey");

                entity.ToTable("DET_SERVICIO_SEDE", "suizasoft");

                entity.HasIndex(e => e.DssIdSede, "IX_DET_SERVICIO_SEDE_dss_id_sede");

                entity.HasIndex(e => e.DssIdServicio, "IX_DET_SERVICIO_SEDE_dss_id_servicio");

                entity.HasIndex(e => e.DssIdTipo, "IX_DET_SERVICIO_SEDE_dss_id_tipo");

                entity.Property(e => e.DssId).HasColumnName("dss_id");

                entity.Property(e => e.DssCupos).HasColumnName("dss_cupos");

                entity.Property(e => e.DssEstado).HasColumnName("dss_estado");

                entity.Property(e => e.DssFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dss_fecha_creacion");

                entity.Property(e => e.DssFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dss_fecha_modificacion");

                entity.Property(e => e.DssIdSede)
                    .HasColumnType("character varying")
                    .HasColumnName("dss_id_sede");

                entity.Property(e => e.DssIdServicio).HasColumnName("dss_id_servicio");

                entity.Property(e => e.DssIdTipo).HasColumnName("dss_id_tipo");

                entity.Property(e => e.DssTiempoRespuesta).HasColumnName("dss_tiempo_respuesta");

                entity.Property(e => e.DssUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dss_usuario_creacion");

                entity.Property(e => e.DssUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dss_usuario_modificacion");

                entity.HasOne(d => d.DssIdSedeNavigation)
                    .WithMany(p => p.DetServicioSedes)
                    .HasForeignKey(d => d.DssIdSede)
                    .HasConstraintName("DET_SERVICIO_SEDE_dss_id_sede_fkey");

                entity.HasOne(d => d.DssIdServicioNavigation)
                    .WithMany(p => p.DetServicioSedes)
                    .HasForeignKey(d => d.DssIdServicio)
                    .HasConstraintName("DET_SERVICIO_SEDE_dss_id_servicio_fkey");

                entity.HasOne(d => d.DssIdTipoNavigation)
                    .WithMany(p => p.DetServicioSedes)
                    .HasForeignKey(d => d.DssIdTipo)
                    .HasConstraintName("DET_SERVICIO_SEDE_dss_id_tipo_fkey");
            });

            modelBuilder.Entity<DetServicioSedeFecha>(entity =>
            {
                entity.HasKey(e => e.DssfId)
                    .HasName("DET_SERVICIO_SEDE_FECHA_pkey");

                entity.ToTable("DET_SERVICIO_SEDE_FECHA", "suizasoft");

                entity.HasIndex(e => e.DssfIdSede, "IX_DET_SERVICIO_SEDE_FECHA_dssf_id_sede");

                entity.HasIndex(e => e.DssfIdServicio, "IX_DET_SERVICIO_SEDE_FECHA_dssf_id_servicio");

                entity.HasIndex(e => e.DssfTipo, "IX_DET_SERVICIO_SEDE_FECHA_dssf_tipo");

                entity.Property(e => e.DssfId).HasColumnName("dssf_id");

                entity.Property(e => e.DssfCupos).HasColumnName("dssf_cupos");

                entity.Property(e => e.DssfFecha).HasColumnName("dssf_fecha");

                entity.Property(e => e.DssfFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dssf_fecha_creacion");

                entity.Property(e => e.DssfIdSede)
                    .HasMaxLength(2)
                    .HasColumnName("dssf_id_sede");

                entity.Property(e => e.DssfIdServicio).HasColumnName("dssf_id_servicio");

                entity.Property(e => e.DssfTiempoRespuesta).HasColumnName("dssf_tiempo_respuesta");

                entity.Property(e => e.DssfTipo).HasColumnName("dssf_tipo");

                entity.Property(e => e.DssfUsuarioCreacion)
                    .HasMaxLength(20)
                    .HasColumnName("dssf_usuario_creacion");

                entity.HasOne(d => d.DssfIdSedeNavigation)
                    .WithMany(p => p.DetServicioSedeFechas)
                    .HasForeignKey(d => d.DssfIdSede)
                    .HasConstraintName("DET_SERVICIO_SEDE_FECHA_dssf_id_sede_fkey");

                entity.HasOne(d => d.DssfIdServicioNavigation)
                    .WithMany(p => p.DetServicioSedeFechas)
                    .HasForeignKey(d => d.DssfIdServicio)
                    .HasConstraintName("DET_SERVICIO_SEDE_FECHA_dssf_id_servicio_fkey");

                entity.HasOne(d => d.DssfTipoNavigation)
                    .WithMany(p => p.DetServicioSedeFechas)
                    .HasForeignKey(d => d.DssfTipo)
                    .HasConstraintName("DET_SERVICIO_SEDE_FECHA_dssf_tipo_fkey");
            });

            modelBuilder.Entity<DetTicketEstado>(entity =>
            {
                entity.HasKey(e => e.DteId)
                    .HasName("DET_TICKET_ESTADO_pkey");

                entity.ToTable("DET_TICKET_ESTADO", "suizasoft");

                entity.HasIndex(e => e.DteIdEstado, "IX_DET_TICKET_ESTADO_dte_id_estado");

                entity.Property(e => e.DteId).HasColumnName("dte_id");

                entity.Property(e => e.DteFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dte_fecha_creacion");

                entity.Property(e => e.DteIdEstado).HasColumnName("dte_id_estado");

                entity.Property(e => e.DteTicket)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("dte_ticket");

                entity.Property(e => e.DteUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dte_usuario_creacion");

                entity.HasOne(d => d.DteIdEstadoNavigation)
                    .WithMany(p => p.DetTicketEstados)
                    .HasForeignKey(d => d.DteIdEstado)
                    .HasConstraintName("DET_TICKET_ESTADO_dte_id_estado_fkey");
            });

            modelBuilder.Entity<DetTopicoMuestra>(entity =>
            {
                entity.HasKey(e => new { e.DtmIdTopico, e.DtmIdMuestra })
                    .HasName("DET_TOPICO_MUESTRA_pkey");

                entity.ToTable("DET_TOPICO_MUESTRA", "suizasoft");

                entity.HasIndex(e => e.DtmIdMuestra, "IX_DET_TOPICO_MUESTRA_dtm_id_muestra");

                entity.Property(e => e.DtmIdTopico).HasColumnName("dtm_id_topico");

                entity.Property(e => e.DtmIdMuestra).HasColumnName("dtm_id_muestra");

                entity.Property(e => e.DtmEnvioDesde)
                    .HasMaxLength(20)
                    .HasColumnName("dtm_envio_desde");

                entity.Property(e => e.DtmEnvioPara)
                    .HasMaxLength(20)
                    .HasColumnName("dtm_envio_para");

                entity.Property(e => e.DtmEstado).HasColumnName("dtm_estado");

                entity.Property(e => e.DtmFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dtm_fecha_creacion");

                entity.Property(e => e.DtmFechaEscaneo)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dtm_fecha_escaneo");

                entity.Property(e => e.DtmIdentificadorEnvioDesde)
                    .HasMaxLength(3)
                    .HasColumnName("dtm_identificador_envio_desde");

                entity.Property(e => e.DtmIdentificadorEnvioPara)
                    .HasMaxLength(3)
                    .HasColumnName("dtm_identificador_envio_para");

                entity.Property(e => e.DtmLote)
                    .HasMaxLength(20)
                    .HasColumnName("dtm_lote");

                entity.Property(e => e.DtmUsuarioCreacion)
                    .HasMaxLength(20)
                    .HasColumnName("dtm_usuario_creacion");

                entity.Property(e => e.DtmUsuarioEscaneo)
                    .HasMaxLength(20)
                    .HasColumnName("dtm_usuario_escaneo");

                entity.HasOne(d => d.DtmIdMuestraNavigation)
                    .WithMany(p => p.DetTopicoMuestras)
                    .HasForeignKey(d => d.DtmIdMuestra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_TOPICO_MUESTRA_dtm_id_muestra_fkey");

                entity.HasOne(d => d.DtmIdTopicoNavigation)
                    .WithMany(p => p.DetTopicoMuestras)
                    .HasForeignKey(d => d.DtmIdTopico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DET_TOPICO_MUESTRA_dtm_id_topico_fkey");
            });

            modelBuilder.Entity<DetTopicoObservacion>(entity =>
            {
                entity.HasKey(e => e.DtoId)
                    .HasName("DET_TOPICO_OBSERVACION_pkey");

                entity.ToTable("DET_TOPICO_OBSERVACION", "suizasoft");

                entity.Property(e => e.DtoId).HasColumnName("dto_id");

                entity.Property(e => e.DtoEstado).HasColumnName("dto_estado");

                entity.Property(e => e.DtoFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dto_fecha_creacion");

                entity.Property(e => e.DtoObservacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dto_observacion");

                entity.Property(e => e.DtoUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("dto_usuario_creacion");

                entity.Property(e => e.DtoYearOrden)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("dto_year_orden");
            });

            modelBuilder.Entity<DetTopicoPreScaneo>(entity =>
            {
                entity.HasKey(e => e.DtsId)
                    .HasName("DET_TOPICO_PRE_SCANEO_pkey");

                entity.ToTable("DET_TOPICO_PRE_SCANEO", "suizasoft");

                entity.HasIndex(e => e.DtsIdMuestra, "IX_DET_TOPICO_PRE_SCANEO_dts_id_muestra");

                entity.Property(e => e.DtsId).HasColumnName("dts_id");

                entity.Property(e => e.DtsEnviado).HasColumnName("dts_enviado");

                entity.Property(e => e.DtsEstado).HasColumnName("dts_estado");

                entity.Property(e => e.DtsFechaEscaneo)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dts_fecha_escaneo");

                entity.Property(e => e.DtsFechaNacimiento)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dts_fecha_nacimiento");

                entity.Property(e => e.DtsFechaOrden)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dts_fecha_orden");

                entity.Property(e => e.DtsIdIngreso).HasColumnName("dts_id_ingreso");

                entity.Property(e => e.DtsIdMuestra).HasColumnName("dts_id_muestra");

                entity.Property(e => e.DtsIdentificadorSedeOrigen)
                    .HasMaxLength(3)
                    .HasColumnName("dts_identificador_sede_origen");

                entity.Property(e => e.DtsNumeroDocumento)
                    .HasMaxLength(15)
                    .HasColumnName("dts_numero_documento");

                entity.Property(e => e.DtsObservacion)
                    .HasMaxLength(200)
                    .HasColumnName("dts_observacion");

                entity.Property(e => e.DtsOrden)
                    .HasMaxLength(15)
                    .HasColumnName("dts_orden");

                entity.Property(e => e.DtsPaciente)
                    .HasMaxLength(150)
                    .HasColumnName("dts_paciente");

                entity.Property(e => e.DtsSexo)
                    .HasMaxLength(15)
                    .HasColumnName("dts_sexo");

                entity.Property(e => e.DtsUsuarioEscaneo)
                    .HasMaxLength(20)
                    .HasColumnName("dts_usuario_escaneo");

                entity.Property(e => e.DtsYearOrden)
                    .HasMaxLength(20)
                    .HasColumnName("dts_year_orden");

                entity.HasOne(d => d.DtsIdMuestraNavigation)
                    .WithMany(p => p.DetTopicoPreScaneos)
                    .HasForeignKey(d => d.DtsIdMuestra)
                    .HasConstraintName("DET_TOPICO_PRE_SCANEO_dts_id_muestra_fkey");
            });

            modelBuilder.Entity<EstComprobante>(entity =>
            {
                entity.HasKey(e => e.EcoId)
                    .HasName("EST_COMPROBANTE_pkey");

                entity.ToTable("EST_COMPROBANTE", "suizasoft");

                entity.Property(e => e.EcoId)
                    .ValueGeneratedNever()
                    .HasColumnName("eco_id");

                entity.Property(e => e.EcoDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("eco_descripcion");

                entity.Property(e => e.EcoEstado).HasColumnName("eco_estado");

                entity.Property(e => e.EcoNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("eco_nombre");
            });

            modelBuilder.Entity<EstNotaCredito>(entity =>
            {
                entity.HasKey(e => e.EncId)
                    .HasName("EST_NOTA_CREDITO_pkey");

                entity.ToTable("EST_NOTA_CREDITO", "suizasoft");

                entity.Property(e => e.EncId)
                    .ValueGeneratedNever()
                    .HasColumnName("enc_id");

                entity.Property(e => e.EncDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("enc_descripcion");

                entity.Property(e => e.EncNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("enc_nombre");
            });

            modelBuilder.Entity<EstTicket>(entity =>
            {
                entity.HasKey(e => e.EtiId)
                    .HasName("EST_TICKET_pkey");

                entity.ToTable("EST_TICKET", "suizasoft");

                entity.Property(e => e.EtiId)
                    .ValueGeneratedNever()
                    .HasColumnName("eti_id");

                entity.Property(e => e.EtiDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("eti_descripcion");

                entity.Property(e => e.EtiNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("eti_nombre");
            });

            modelBuilder.Entity<LabOrdenMuestra>(entity =>
            {
                entity.HasKey(e => new { e.OrmYearorden, e.OrmMueCodigo })
                    .HasName("LAB_ORDEN_MUESTRA_pkey");

                entity.ToTable("LAB_ORDEN_MUESTRA", "suizasoft");

                entity.HasIndex(e => e.OrmMueCodigo, "IX_LAB_ORDEN_MUESTRA_orm_mue_codigo");

                entity.Property(e => e.OrmYearorden)
                    .HasColumnType("character varying")
                    .HasColumnName("orm_yearorden");

                entity.Property(e => e.OrmMueCodigo).HasColumnName("orm_mue_codigo");

                entity.Property(e => e.OrmEstado).HasColumnName("orm_estado");

                entity.Property(e => e.OrmFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("orm_fecha_modificacion");

                entity.Property(e => e.OrmFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("orm_fecha_registro");

                entity.Property(e => e.OrmOrdenNumero)
                    .HasColumnType("character varying")
                    .HasColumnName("orm_orden_numero");

                entity.Property(e => e.OrmUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("orm_usuario_modificacion");

                entity.Property(e => e.OrmUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("orm_usuario_registro");

                entity.HasOne(d => d.OrmMueCodigoNavigation)
                    .WithMany(p => p.LabOrdenMuestras)
                    .HasForeignKey(d => d.OrmMueCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lab_orden_mue_tip_muestra_fk");

                entity.HasOne(d => d.OrmYearordenNavigation)
                    .WithMany(p => p.LabOrdenMuestras)
                    .HasPrincipalKey(p => p.OrsYearorden)
                    .HasForeignKey(d => d.OrmYearorden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lab_orden_mue_orden_serv_cab_fk");
            });

            modelBuilder.Entity<LogDocumentoElectronico>(entity =>
            {
                entity.HasKey(e => e.FeId)
                    .HasName("log_documento_electronico_pkey");

                entity.ToTable("log_documento_electronico", "suizasoft");

                entity.Property(e => e.FeId).HasColumnName("fe_id");

                entity.Property(e => e.FeErrores)
                    .HasColumnType("character varying")
                    .HasColumnName("fe_errores");

                entity.Property(e => e.FeEstadoEnvio)
                    .HasColumnType("character varying")
                    .HasColumnName("fe_estado_envio");

                entity.Property(e => e.FeFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fe_fecha_registro");

                entity.Property(e => e.FeNumerodocumento)
                    .HasColumnType("character varying")
                    .HasColumnName("fe_numerodocumento");

                entity.Property(e => e.FeTipodocumento)
                    .HasColumnType("character varying")
                    .HasColumnName("fe_tipodocumento");

                entity.Property(e => e.FeTramaEnviada).HasColumnName("fe_trama_enviada");
            });

            modelBuilder.Entity<LogDocumentoEnterprice>(entity =>
            {
                entity.HasKey(e => e.FeId)
                    .HasName("log_documento_enterprice_pkey");

                entity.ToTable("log_documento_enterprice", "suizasoft");

                entity.Property(e => e.FeId).HasColumnName("fe_id");

                entity.Property(e => e.FeErrores)
                    .HasColumnType("character varying")
                    .HasColumnName("fe_errores");

                entity.Property(e => e.FeEstadoEnvio)
                    .HasColumnType("character varying")
                    .HasColumnName("fe_estado_envio");

                entity.Property(e => e.FeFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fe_fecha_registro");

                entity.Property(e => e.FeNroservicio)
                    .HasColumnType("character varying")
                    .HasColumnName("fe_nroservicio");
            });

            modelBuilder.Entity<MiTabla>(entity =>
            {
                entity.ToTable("mi_tabla", "suizasoft");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fecha_hora");
            });

            modelBuilder.Entity<MstActividadComercial>(entity =>
            {
                entity.HasKey(e => e.AcoId)
                    .HasName("MST_ACTIVIDAD_COMERCIAL_pkey");

                entity.ToTable("MST_ACTIVIDAD_COMERCIAL", "suizasoft");

                entity.Property(e => e.AcoId).HasColumnName("aco_id");

                entity.Property(e => e.AcoActividadHist)
                    .HasColumnType("character varying")
                    .HasColumnName("aco_actividad_hist");

                entity.Property(e => e.AcoDescripccion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("aco_descripccion");
            });

            modelBuilder.Entity<MstAgenteSerie>(entity =>
            {
                entity.HasKey(e => e.AseId)
                    .HasName("MST_AGENTE_SERIE_pkey");

                entity.ToTable("MST_AGENTE_SERIE", "suizasoft");

                entity.HasIndex(e => e.AseIdTipoDocVenta, "IX_MST_AGENTE_SERIE_ase_id_tipo_doc_venta");

                entity.HasIndex(e => new { e.AseIdSucursal, e.AseIdTipoDocVenta, e.AseSerie }, "MST_AGENTE_SERIE_ase_id_sucursal_ase_id_tipo_doc_venta_ase__key")
                    .IsUnique();

                entity.Property(e => e.AseId).HasColumnName("ase_id");

                entity.Property(e => e.AseCorrelativo).HasColumnName("ase_correlativo");

                entity.Property(e => e.AseEstado).HasColumnName("ase_estado");

                entity.Property(e => e.AseFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ase_fecha_creacion");

                entity.Property(e => e.AseFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ase_fecha_modificacion");

                entity.Property(e => e.AseIdSucursal)
                    .HasMaxLength(2)
                    .HasColumnName("ase_id_sucursal");

                entity.Property(e => e.AseIdTipoDocVenta).HasColumnName("ase_id_tipo_doc_venta");

                entity.Property(e => e.AseSerie)
                    .HasColumnType("character varying")
                    .HasColumnName("ase_serie");

                entity.Property(e => e.AseUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ase_usuario_creacion");

                entity.Property(e => e.AseUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ase_usuario_modificacion");

                entity.HasOne(d => d.AseIdSucursalNavigation)
                    .WithMany(p => p.MstAgenteSeries)
                    .HasForeignKey(d => d.AseIdSucursal)
                    .HasConstraintName("MST_AGENTE_SERIE_ase_id_sucursal_fkey");

                entity.HasOne(d => d.AseIdTipoDocVentaNavigation)
                    .WithMany(p => p.MstAgenteSeries)
                    .HasForeignKey(d => d.AseIdTipoDocVenta)
                    .HasConstraintName("MST_AGENTE_SERIE_ase_id_tipo_doc_venta_fkey");
            });

            modelBuilder.Entity<MstAreaCompania>(entity =>
            {
                entity.HasKey(e => e.MacId)
                    .HasName("MST_AREA_COMPANIAS_pkey");

                entity.ToTable("MST_AREA_COMPANIAS", "suizasoft");

                entity.HasIndex(e => e.MacIdCompania, "IX_MST_AREA_COMPANIAS_mac_id_compania");

                entity.Property(e => e.MacId).HasColumnName("mac_id");

                entity.Property(e => e.MacCodigo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("mac_codigo");

                entity.Property(e => e.MacDescripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("mac_descripcion");

                entity.Property(e => e.MacEstado).HasColumnName("mac_estado");

                entity.Property(e => e.MacFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("mac_fecha_creacion");

                entity.Property(e => e.MacFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("mac_fecha_modificacion");

                entity.Property(e => e.MacIdCompania).HasColumnName("mac_id_compania");

                entity.Property(e => e.MacUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("mac_usuario_creacion");

                entity.Property(e => e.MacUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("mac_usuario_modificacion");

                entity.HasOne(d => d.MacIdCompaniaNavigation)
                    .WithMany(p => p.MstAreaCompania)
                    .HasForeignKey(d => d.MacIdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_AREA_COMPANIAS_mac_id_compania_fkey");
            });

            modelBuilder.Entity<MstAuditorium>(entity =>
            {
                entity.HasKey(e => e.AudId)
                    .HasName("MST_AUDITORIA_pkey");

                entity.ToTable("MST_AUDITORIA", "suizasoft");

                entity.Property(e => e.AudId).HasColumnName("aud_id");

                entity.Property(e => e.AudAccion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("aud_accion");

                entity.Property(e => e.AudFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("aud_fecha_creacion");

                entity.Property(e => e.AudIpUsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("aud_ip_usuario_creacion");

                entity.Property(e => e.AudTable)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("aud_table");

                entity.Property(e => e.AudUsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("aud_usuario_creacion");

                entity.Property(e => e.AudValor)
                    .HasColumnType("jsonb")
                    .HasColumnName("aud_valor");

                entity.Property(e => e.AudValorNuevo)
                    .HasColumnType("jsonb")
                    .HasColumnName("aud_valor_nuevo");
            });

            modelBuilder.Entity<MstBanner>(entity =>
            {
                entity.HasKey(e => e.BanId)
                    .HasName("MST_BANNERS_pkey");

                entity.ToTable("MST_BANNERS", "suizasoft");

                entity.Property(e => e.BanId).HasColumnName("ban_id");

                entity.Property(e => e.BanDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("ban_descripcion");

                entity.Property(e => e.BanDestino)
                    .HasColumnType("character varying")
                    .HasColumnName("ban_destino");

                entity.Property(e => e.BanEstado).HasColumnName("ban_estado");

                entity.Property(e => e.BanFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ban_fecha_creacion");

                entity.Property(e => e.BanFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ban_fecha_modificacion");

                entity.Property(e => e.BanNameItem)
                    .HasColumnType("character varying")
                    .HasColumnName("ban_name_item");

                entity.Property(e => e.BanRutaImage)
                    .HasColumnType("character varying")
                    .HasColumnName("ban_ruta_image");

                entity.Property(e => e.BanRutaLogo)
                    .HasColumnType("character varying")
                    .HasColumnName("ban_ruta_logo");

                entity.Property(e => e.BanTextoAlternativo)
                    .HasColumnType("character varying")
                    .HasColumnName("ban_texto_alternativo");

                entity.Property(e => e.BanTipo)
                    .HasColumnType("character varying")
                    .HasColumnName("ban_tipo");

                entity.Property(e => e.BanTitulo)
                    .HasColumnType("character varying")
                    .HasColumnName("ban_titulo");

                entity.Property(e => e.BanUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ban_usuario_creacion");

                entity.Property(e => e.BanUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ban_usuario_modificacion");
            });

            modelBuilder.Entity<MstBitacoraAtencionAuditorium>(entity =>
            {
                entity.HasKey(e => e.TrauId)
                    .HasName("MST_BITACORA_ATENCION_AUDITORIA_pkey");

                entity.ToTable("MST_BITACORA_ATENCION_AUDITORIA", "suizasoft");

                entity.HasIndex(e => e.TrauIdBitacoraAccion, "IX_MST_BITACORA_ATENCION_AUDITORIA_trau_id_bitacora_accion");

                entity.HasIndex(e => e.TrauIdMedico, "IX_MST_BITACORA_ATENCION_AUDITORIA_trau_id_medico");

                entity.HasIndex(e => e.TrauIdRol, "IX_MST_BITACORA_ATENCION_AUDITORIA_trau_id_rol");

                entity.HasIndex(e => e.TrauIdServicio, "IX_MST_BITACORA_ATENCION_AUDITORIA_trau_id_servicio");

                entity.HasIndex(e => new { e.TrauOrdIdNumeroCab, e.TrauOrdPeriodo, e.TrauOrdAnio, e.TrauOrdIdSucursal, e.TrauOrdItem }, "IX_MST_BITACORA_ATENCION_AUDITORIA_trau_ord_id_numero_cab_trau~");

                entity.Property(e => e.TrauId).HasColumnName("trau_id");

                entity.Property(e => e.TrauEstado).HasColumnName("trau_estado");

                entity.Property(e => e.TrauFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("trau_fecha_creacion");

                entity.Property(e => e.TrauFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("trau_fecha_modificacion");

                entity.Property(e => e.TrauIdBitacoraAccion).HasColumnName("trau_id_bitacora_accion");

                entity.Property(e => e.TrauIdMedico).HasColumnName("trau_id_medico");

                entity.Property(e => e.TrauIdRol).HasColumnName("trau_id_rol");

                entity.Property(e => e.TrauIdServicio).HasColumnName("trau_id_servicio");

                entity.Property(e => e.TrauMensaje)
                    .HasColumnType("character varying")
                    .HasColumnName("trau_mensaje");

                entity.Property(e => e.TrauOrdAnio)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("trau_ord_anio")
                    .IsFixedLength();

                entity.Property(e => e.TrauOrdIdNumeroCab).HasColumnName("trau_ord_id_numero_cab");

                entity.Property(e => e.TrauOrdIdSucursal)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("trau_ord_id_sucursal")
                    .IsFixedLength();

                entity.Property(e => e.TrauOrdItem).HasColumnName("trau_ord_item");

                entity.Property(e => e.TrauOrdPeriodo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("trau_ord_periodo")
                    .IsFixedLength();

                entity.Property(e => e.TrauUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("trau_usuario_creacion");

                entity.Property(e => e.TrauUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("trau_usuario_modificacion");

                entity.HasOne(d => d.TrauIdBitacoraAccionNavigation)
                    .WithMany(p => p.MstBitacoraAtencionAuditoria)
                    .HasForeignKey(d => d.TrauIdBitacoraAccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_BITACORA_ATENCION_AUDITORIA_trau_id_bitacora_accion_fkey");

                entity.HasOne(d => d.TrauIdMedicoNavigation)
                    .WithMany(p => p.MstBitacoraAtencionAuditoria)
                    .HasForeignKey(d => d.TrauIdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_BITACORA_ATENCION_AUDITORIA_trau_id_medico_fkey");

                entity.HasOne(d => d.TrauIdRolNavigation)
                    .WithMany(p => p.MstBitacoraAtencionAuditoria)
                    .HasForeignKey(d => d.TrauIdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_BITACORA_ATENCION_AUDITORIA_trau_id_rol_fkey");

                entity.HasOne(d => d.TrauIdServicioNavigation)
                    .WithMany(p => p.MstBitacoraAtencionAuditoria)
                    .HasForeignKey(d => d.TrauIdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_BITACORA_ATENCION_AUDITORIA_trau_id_servicio_fkey");

                entity.HasOne(d => d.TrauOrd)
                    .WithMany(p => p.MstBitacoraAtencionAuditoria)
                    .HasForeignKey(d => new { d.TrauOrdIdNumeroCab, d.TrauOrdPeriodo, d.TrauOrdAnio, d.TrauOrdIdSucursal, d.TrauOrdItem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bitacora_atencion_auditoria_orden_servicio_det_fk");
            });

            modelBuilder.Entity<MstCarGenPrestacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MST_CAR_GEN_PRESTACION", "suizasoft");

                entity.Property(e => e.GenC10NumeroDocumentoIdentidad)
                    .HasMaxLength(15)
                    .HasColumnName("gen_c10_numero_documento_identidad")
                    .IsFixedLength();

                entity.Property(e => e.GenC11NumeroHistoriaClinica)
                    .HasMaxLength(8)
                    .HasColumnName("gen_c11_numero_historia_clinica")
                    .IsFixedLength();

                entity.Property(e => e.GenC12DocAutorizacionPrestacion)
                    .HasMaxLength(2)
                    .HasColumnName("gen_c12_doc_autorizacion_prestacion")
                    .IsFixedLength();

                entity.Property(e => e.GenC13NroDocAutorizacion)
                    .HasMaxLength(20)
                    .HasColumnName("gen_c13_nro_doc_autorizacion")
                    .IsFixedLength();

                entity.Property(e => e.GenC14SegundoDocAutorizPrestacion)
                    .HasMaxLength(2)
                    .HasColumnName("gen_c14_segundo_doc_autoriz_prestacion")
                    .IsFixedLength();

                entity.Property(e => e.GenC15NumeroSegundoDocautorizacion)
                    .HasMaxLength(20)
                    .HasColumnName("gen_c15_numero_segundo_docautorizacion")
                    .IsFixedLength();

                entity.Property(e => e.GenC16TipoCoberturaPrestacion)
                    .HasMaxLength(1)
                    .HasColumnName("gen_c16_tipo_cobertura_prestacion");

                entity.Property(e => e.GenC17SubtipoCoberturaPrestacion)
                    .HasMaxLength(4)
                    .HasColumnName("gen_c17_subtipo_cobertura_prestacion")
                    .IsFixedLength();

                entity.Property(e => e.GenC18PrimerDiagnostico)
                    .HasMaxLength(5)
                    .HasColumnName("gen_c18_primer_diagnostico")
                    .IsFixedLength();

                entity.Property(e => e.GenC19SegundoDiagnostico)
                    .HasMaxLength(5)
                    .HasColumnName("gen_c19_segundo_diagnostico")
                    .IsFixedLength();

                entity.Property(e => e.GenC1RucEmpresa)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("gen_c1_ruc_empresa")
                    .IsFixedLength();

                entity.Property(e => e.GenC20TercerDiagnostico)
                    .HasMaxLength(5)
                    .HasColumnName("gen_c20_tercer_diagnostico")
                    .IsFixedLength();

                entity.Property(e => e.GenC21FechaPrestacion)
                    .HasMaxLength(8)
                    .HasColumnName("gen_c21_fecha_prestacion")
                    .IsFixedLength();

                entity.Property(e => e.GenC22HoraInicioPrestacion)
                    .HasMaxLength(6)
                    .HasColumnName("gen_c22_hora_inicio_prestacion")
                    .IsFixedLength();

                entity.Property(e => e.GenC23TipoProfResponsPrestac)
                    .HasMaxLength(2)
                    .HasColumnName("gen_c23_tipo_prof_respons_prestac")
                    .IsFixedLength();

                entity.Property(e => e.GenC24NumeroColegiatura)
                    .HasMaxLength(6)
                    .HasColumnName("gen_c24_numero_colegiatura")
                    .IsFixedLength();

                entity.Property(e => e.GenC25TipodocIdentidProfesional)
                    .HasMaxLength(1)
                    .HasColumnName("gen_c25_tipodoc_identid_profesional");

                entity.Property(e => e.GenC26NrodocIdentidProfesional)
                    .HasMaxLength(15)
                    .HasColumnName("gen_c26_nrodoc_identid_profesional")
                    .IsFixedLength();

                entity.Property(e => e.GenC27RucEntidadReferencia)
                    .HasMaxLength(11)
                    .HasColumnName("gen_c27_ruc_entidad_referencia")
                    .IsFixedLength();

                entity.Property(e => e.GenC28FechaTransferencia)
                    .HasMaxLength(8)
                    .HasColumnName("gen_c28_fecha_transferencia")
                    .IsFixedLength();

                entity.Property(e => e.GenC29HoraTransferencia)
                    .HasMaxLength(6)
                    .HasColumnName("gen_c29_hora_transferencia")
                    .IsFixedLength();

                entity.Property(e => e.GenC2CodigoIpress)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("gen_c2_codigo_ipress")
                    .IsFixedLength();

                entity.Property(e => e.GenC30TipoHospitalizacion)
                    .HasMaxLength(1)
                    .HasColumnName("gen_c30_tipo_hospitalizacion");

                entity.Property(e => e.GenC31FechaIngresoHospitalario)
                    .HasMaxLength(8)
                    .HasColumnName("gen_c31_fecha_ingreso_hospitalario")
                    .IsFixedLength();

                entity.Property(e => e.GenC32FechaEgresoHospitalario)
                    .HasMaxLength(8)
                    .HasColumnName("gen_c32_fecha_egreso_hospitalario")
                    .IsFixedLength();

                entity.Property(e => e.GenC33TipoEgresoHospitalario)
                    .HasMaxLength(2)
                    .HasColumnName("gen_c33_tipo_egreso_hospitalario")
                    .IsFixedLength();

                entity.Property(e => e.GenC34DiasEstanciaFacturable)
                    .HasMaxLength(3)
                    .HasColumnName("gen_c34_dias_estancia_facturable")
                    .IsFixedLength();

                entity.Property(e => e.GenC35GastoHonorarioProcSinigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c35_gasto_honorario_proc_sinigv");

                entity.Property(e => e.GenC36GastoProcOdontologSinigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c36_gasto_proc_odontolog_sinigv");

                entity.Property(e => e.GenC37GastoPresHotServClintopSinigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c37_gasto_pres_hot_serv_clintop_sinigv");

                entity.Property(e => e.GenC38GastoExamAuxlabSinigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c38_gasto_exam_auxlab_sinigv");

                entity.Property(e => e.GenC39GastoExamAuximagSinigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c39_gasto_exam_auximag_sinigv");

                entity.Property(e => e.GenC3TipoDocumentoPago)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("gen_c3_tipo_documento_pago")
                    .IsFixedLength();

                entity.Property(e => e.GenC40GastoFarmacInsumSinigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c40_gasto_farmac_insum_sinigv");

                entity.Property(e => e.GenC41GastoProteSinigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c41_gasto_prote_sinigv");

                entity.Property(e => e.GenC42GastoProdservmedExonigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c42_gasto_prodservmed_exonigv");

                entity.Property(e => e.GenC43OtrosGastprestsaludSinigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c43_otros_gastprestsalud_sinigv");

                entity.Property(e => e.GenC44CopagoFijoAfectigvSinigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c44_copago_fijo_afectigv_sinigv");

                entity.Property(e => e.GenC45CopagoFijoExonigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c45_copago_fijo_exonigv");

                entity.Property(e => e.GenC46CopagoVarAfectigvSinigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c46_copago_var_afectigv_sinigv");

                entity.Property(e => e.GenC47CopagoVarExonigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c47_copago_var_exonigv");

                entity.Property(e => e.GenC48TotalGastoscubSinigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("gen_c48_total_gastoscub_sinigv");

                entity.Property(e => e.GenC4NumeroDocumentoPago)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("gen_c4_numero_documento_pago")
                    .IsFixedLength();

                entity.Property(e => e.GenC5CorrelativoPrestacion)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("gen_c5_correlativo_prestacion")
                    .IsFixedLength();

                entity.Property(e => e.GenC6CodigoPrestacionInternoIpress)
                    .HasMaxLength(10)
                    .HasColumnName("gen_c6_codigo_prestacion_interno_ipress")
                    .IsFixedLength();

                entity.Property(e => e.GenC7TipoAfiliacion)
                    .HasMaxLength(1)
                    .HasColumnName("gen_c7_tipo_afiliacion");

                entity.Property(e => e.GenC8CodigoAseguradoPaciente)
                    .HasMaxLength(20)
                    .HasColumnName("gen_c8_codigo_asegurado_paciente")
                    .IsFixedLength();

                entity.Property(e => e.GenC9TipoDocumentoIdentidad)
                    .HasMaxLength(1)
                    .HasColumnName("gen_c9_tipo_documento_identidad");

                entity.Property(e => e.GenCodFina)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("gen_cod_fina")
                    .IsFixedLength();

                entity.Property(e => e.GenFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("gen_fecha_creacion");

                entity.Property(e => e.GenNumeroAtencion).HasColumnName("gen_numero_atencion");

                entity.Property(e => e.GenNumeroFactura)
                    .HasMaxLength(8)
                    .HasColumnName("gen_numero_factura")
                    .IsFixedLength();

                entity.Property(e => e.GenNumeroLote)
                    .HasMaxLength(7)
                    .HasColumnName("gen_numero_lote")
                    .IsFixedLength();

                entity.Property(e => e.GenSerie)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("gen_serie")
                    .IsFixedLength();

                entity.Property(e => e.GenUsuarioCreacion).HasColumnName("gen_usuario_creacion");
            });

            modelBuilder.Entity<MstCatalogoResultado>(entity =>
            {
                entity.HasKey(e => e.CrId)
                    .HasName("MST_CATALOGO_RESULTADOS_pkey");

                entity.ToTable("MST_CATALOGO_RESULTADOS", "suizasoft");

                entity.Property(e => e.CrId).HasColumnName("cr_id");

                entity.Property(e => e.CrEstado).HasColumnName("cr_estado");

                entity.Property(e => e.CrFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cr_fecha_creacion");

                entity.Property(e => e.CrFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cr_fecha_modificacion");

                entity.Property(e => e.CrNombre)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("cr_nombre");

                entity.Property(e => e.CrUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("cr_usuario_creacion");

                entity.Property(e => e.CrUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("cr_usuario_modificacion");
            });

            modelBuilder.Entity<MstCentroCosto>(entity =>
            {
                entity.HasKey(e => e.CecId)
                    .HasName("MST_CENTRO_COSTOS_pkey");

                entity.ToTable("MST_CENTRO_COSTOS", "suizasoft");

                entity.Property(e => e.CecId).HasColumnName("cec_id");

                entity.Property(e => e.CecEstado).HasColumnName("cec_estado");

                entity.Property(e => e.CecFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cec_fecha_creacion");

                entity.Property(e => e.CecFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cec_fecha_modificacion");

                entity.Property(e => e.CecNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("cec_nombre");

                entity.Property(e => e.CecUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("cec_usuario_creacion");

                entity.Property(e => e.CecUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("cec_usuario_modificacion");
            });

            modelBuilder.Entity<MstCie10>(entity =>
            {
                entity.HasKey(e => e.CieId)
                    .HasName("MST_CIE10_pkey");

                entity.ToTable("MST_CIE10", "suizasoft");

                entity.Property(e => e.CieId)
                    .HasMaxLength(3)
                    .HasColumnName("cie_id")
                    .IsFixedLength();

                entity.Property(e => e.CieDescripcion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("cie_descripcion");
            });

            modelBuilder.Entity<MstCitaParticular>(entity =>
            {
                entity.HasKey(e => e.CpaId)
                    .HasName("MST_CITA_PARTICULAR_pkey");

                entity.ToTable("MST_CITA_PARTICULAR", "suizasoft");

                entity.HasIndex(e => e.CpaIdDoctor, "IX_MST_CITA_PARTICULAR_cpa_id_doctor");

                entity.HasIndex(e => e.CpaIdEspecialidad, "IX_MST_CITA_PARTICULAR_cpa_id_especialidad");

                entity.HasIndex(e => e.CpaIdPaciente, "IX_MST_CITA_PARTICULAR_cpa_id_paciente");

                entity.HasIndex(e => e.CpaIdSede, "IX_MST_CITA_PARTICULAR_cpa_id_sede");

                entity.HasIndex(e => e.CpaTipoSeguro, "IX_MST_CITA_PARTICULAR_cpa_tipo_seguro");

                entity.Property(e => e.CpaId).HasColumnName("cpa_id");

                entity.Property(e => e.CpaClienteNotificado).HasColumnName("cpa_cliente_notificado");

                entity.Property(e => e.CpaEstado)
                    .HasMaxLength(1)
                    .HasColumnName("cpa_estado")
                    .HasDefaultValueSql("'C'::bpchar");

                entity.Property(e => e.CpaFechaCita).HasColumnName("cpa_fecha_cita");

                entity.Property(e => e.CpaFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cpa_fecha_creacion");

                entity.Property(e => e.CpaHoraCita).HasColumnName("cpa_hora_cita");

                entity.Property(e => e.CpaIdDoctor).HasColumnName("cpa_id_doctor");

                entity.Property(e => e.CpaIdEspecialidad).HasColumnName("cpa_id_especialidad");

                entity.Property(e => e.CpaIdPaciente).HasColumnName("cpa_id_paciente");

                entity.Property(e => e.CpaIdSede)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("cpa_id_sede");

                entity.Property(e => e.CpaIdServicio).HasColumnName("cpa_id_servicio");

                entity.Property(e => e.CpaIdTipoAtencion).HasColumnName("cpa_id_tipo_atencion");

                entity.Property(e => e.CpaMotivoAnulacion)
                    .HasMaxLength(200)
                    .HasColumnName("cpa_motivo_anulacion");

                entity.Property(e => e.CpaTicket)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("cpa_ticket");

                entity.Property(e => e.CpaTipoSeguro).HasColumnName("cpa_tipo_seguro");

                entity.Property(e => e.CpaTipoServicio).HasColumnName("cpa_tipo_servicio");

                entity.HasOne(d => d.CpaIdDoctorNavigation)
                    .WithMany(p => p.MstCitaParticulars)
                    .HasForeignKey(d => d.CpaIdDoctor)
                    .HasConstraintName("MST_CITA_PARTICULAR_cpa_id_doctor_fkey");

                entity.HasOne(d => d.CpaIdEspecialidadNavigation)
                    .WithMany(p => p.MstCitaParticulars)
                    .HasForeignKey(d => d.CpaIdEspecialidad)
                    .HasConstraintName("MST_CITA_PARTICULAR_cpa_id_especialidad_fkey");

                entity.HasOne(d => d.CpaIdPacienteNavigation)
                    .WithMany(p => p.MstCitaParticulars)
                    .HasForeignKey(d => d.CpaIdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_CITA_PARTICULAR_cpa_id_paciente_fkey");

                entity.HasOne(d => d.CpaIdSedeNavigation)
                    .WithMany(p => p.MstCitaParticulars)
                    .HasForeignKey(d => d.CpaIdSede)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_CITA_PARTICULAR_cpa_id_sede_fkey");

                entity.HasOne(d => d.CpaIdServicioNavigation)
                    .WithMany(p => p.MstCitaParticulars)
                    .HasForeignKey(d => d.CpaIdServicio)
                    .HasConstraintName("MST_CITA_PARTICULAR_cpa_id_servicio_fkey");

                entity.HasOne(d => d.CpaTipoSeguroNavigation)
                    .WithMany(p => p.MstCitaParticulars)
                    .HasForeignKey(d => d.CpaTipoSeguro)
                    .HasConstraintName("MST_CITA_PARTICULAR_cpa_tipo_seguro_fkey");

                entity.HasOne(d => d.CpaTipoServicioNavigation)
                    .WithMany(p => p.MstCitaParticulars)
                    .HasForeignKey(d => d.CpaTipoServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_CITA_PARTICULAR_cpa_tipo_servicio_fkey");
            });

            modelBuilder.Entity<MstCitasSeguro>(entity =>
            {
                entity.HasKey(e => e.CisId)
                    .HasName("MST_CITAS_SEGUROS_pkey");

                entity.ToTable("MST_CITAS_SEGUROS", "suizasoft");

                entity.Property(e => e.CisId).HasColumnName("cis_id");

                entity.Property(e => e.CisDireccion)
                    .HasColumnType("character varying")
                    .HasColumnName("cis_direccion");

                entity.Property(e => e.CisEstadoCita).HasColumnName("cis_estado_cita");

                entity.Property(e => e.CisFechaCita)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cis_fecha_cita");

                entity.Property(e => e.CisFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cis_fecha_modificacion");

                entity.Property(e => e.CisFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cis_fecha_registro");

                entity.Property(e => e.CisIdPaciente).HasColumnName("cis_id_paciente");

                entity.Property(e => e.CisIdSucursal).HasColumnName("cis_id_sucursal");

                entity.Property(e => e.CisIdTicket).HasColumnName("cis_id_ticket");

                entity.Property(e => e.CisIdUbigeo).HasColumnName("cis_id_ubigeo");

                entity.Property(e => e.CisLugarCita)
                    .HasColumnType("character varying")
                    .HasColumnName("cis_lugar_cita");

                entity.Property(e => e.CisMonto)
                    .HasPrecision(13, 2)
                    .HasColumnName("cis_monto");

                entity.Property(e => e.CisNumeroDocumento)
                    .HasColumnType("character varying")
                    .HasColumnName("cis_numero_documento");

                entity.Property(e => e.CisObservacion)
                    .HasColumnType("character varying")
                    .HasColumnName("cis_observacion");

                entity.Property(e => e.CisReferencia)
                    .HasColumnType("character varying")
                    .HasColumnName("cis_referencia");

                entity.Property(e => e.CisSexo).HasColumnName("cis_sexo");

                entity.Property(e => e.CisTelefono1)
                    .HasColumnType("character varying")
                    .HasColumnName("cis_telefono1");

                entity.Property(e => e.CisTelefono2)
                    .HasColumnType("character varying")
                    .HasColumnName("cis_telefono2");

                entity.Property(e => e.CisTipoDocumento).HasColumnName("cis_tipo_documento");

                entity.Property(e => e.CisTipoServicio).HasColumnName("cis_tipo_servicio");

                entity.Property(e => e.CisUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("cis_usuario_modificacion");

                entity.Property(e => e.CisUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("cis_usuario_registro");
            });

            modelBuilder.Entity<MstClasificacionLaboratorio>(entity =>
            {
                entity.HasKey(e => e.ClaId)
                    .HasName("MST_CLASIFICACION_LABORATORIO_pkey");

                entity.ToTable("MST_CLASIFICACION_LABORATORIO", "suizasoft");

                entity.Property(e => e.ClaId).HasColumnName("cla_id");

                entity.Property(e => e.ClaCodigoNivel1)
                    .HasColumnType("character varying")
                    .HasColumnName("cla_codigo_nivel1");

                entity.Property(e => e.ClaCodigoNivel2)
                    .HasColumnType("character varying")
                    .HasColumnName("cla_codigo_nivel2");

                entity.Property(e => e.ClaCodigoNivel3)
                    .HasColumnType("character varying")
                    .HasColumnName("cla_codigo_nivel3");

                entity.Property(e => e.ClaDescripcionNivel1)
                    .HasColumnType("character varying")
                    .HasColumnName("cla_descripcion_nivel1");

                entity.Property(e => e.ClaDescripcionNivel2)
                    .HasColumnType("character varying")
                    .HasColumnName("cla_descripcion_nivel2");

                entity.Property(e => e.ClaDescripcionNivel3)
                    .HasColumnType("character varying")
                    .HasColumnName("cla_descripcion_nivel3");

                entity.Property(e => e.ClaEstado).HasColumnName("cla_estado");
            });

            modelBuilder.Entity<MstCompanium>(entity =>
            {
                entity.HasKey(e => e.ComId)
                    .HasName("MST_COMPANIA_pkey");

                entity.ToTable("MST_COMPANIA", "suizasoft");

                entity.HasIndex(e => e.ComIdActividadCom, "IX_MST_COMPANIA_com_id_actividad_com");

                entity.HasIndex(e => e.ComIdDocumentoFiscal, "IX_MST_COMPANIA_com_id_documento_fiscal");

                entity.HasIndex(e => e.ComIdFormaPago, "IX_MST_COMPANIA_com_id_forma_pago");

                entity.HasIndex(e => e.ComIdPeriodoCredito, "IX_MST_COMPANIA_com_id_periodo_credito");

                entity.HasIndex(e => e.ComIdPeriodoFact, "IX_MST_COMPANIA_com_id_periodo_fact");

                entity.HasIndex(e => e.ComIdPromotor, "IX_MST_COMPANIA_com_id_promotor");

                entity.HasIndex(e => e.ComIdTipoPago, "IX_MST_COMPANIA_com_id_tipo_pago");

                entity.HasIndex(e => e.ComIdTipoVenta, "IX_MST_COMPANIA_com_id_tipo_venta");

                entity.HasIndex(e => e.ComIdUbigeo, "IX_MST_COMPANIA_com_id_ubigeo");

                entity.HasIndex(e => e.ComTipoDocumento, "IX_MST_COMPANIA_com_tipo_documento");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.ComAccesoWeb).HasColumnName("com_acceso_web");

                entity.Property(e => e.ComAccesos).HasColumnName("com_accesos");

                entity.Property(e => e.ComApellidoMaterno)
                    .HasColumnType("character varying")
                    .HasColumnName("com_apellido_materno");

                entity.Property(e => e.ComApellidoPaterno)
                    .HasColumnType("character varying")
                    .HasColumnName("com_apellido_paterno");

                entity.Property(e => e.ComCorreo)
                    .HasColumnType("character varying")
                    .HasColumnName("com_correo");

                entity.Property(e => e.ComCorreoResultado)
                    .HasColumnType("character varying")
                    .HasColumnName("com_correo_resultado");

                entity.Property(e => e.ComDireccionFiscal)
                    .HasColumnType("character varying")
                    .HasColumnName("com_direccion_fiscal");

                entity.Property(e => e.ComEnvioSap).HasColumnName("com_envio_sap");

                entity.Property(e => e.ComErrorSap)
                    .HasColumnType("character varying")
                    .HasColumnName("com_error_sap");

                entity.Property(e => e.ComEstado).HasColumnName("com_estado");

                entity.Property(e => e.ComEstadoSap)
                    .HasColumnType("character varying")
                    .HasColumnName("com_estado_sap")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.ComFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("com_fecha_creacion");

                entity.Property(e => e.ComFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("com_fecha_modificacion");

                entity.Property(e => e.ComIdActividadCom).HasColumnName("com_id_actividad_com");

                entity.Property(e => e.ComIdDocumentoFiscal).HasColumnName("com_id_documento_fiscal");

                entity.Property(e => e.ComIdFormaPago).HasColumnName("com_id_forma_pago");

                entity.Property(e => e.ComIdPeriodoCredito).HasColumnName("com_id_periodo_credito");

                entity.Property(e => e.ComIdPeriodoFact).HasColumnName("com_id_periodo_fact");

                entity.Property(e => e.ComIdPromotor).HasColumnName("com_id_promotor");

                entity.Property(e => e.ComIdTipoPago).HasColumnName("com_id_tipo_pago");

                entity.Property(e => e.ComIdTipoVenta).HasColumnName("com_id_tipo_venta");

                entity.Property(e => e.ComIdUbigeo).HasColumnName("com_id_ubigeo");

                entity.Property(e => e.ComLineaCredito)
                    .HasColumnType("character varying")
                    .HasColumnName("com_linea_credito");

                entity.Property(e => e.ComNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("com_nombre");

                entity.Property(e => e.ComNombreComercial)
                    .HasColumnType("character varying")
                    .HasColumnName("com_nombre_comercial");

                entity.Property(e => e.ComNumeroDocumento)
                    .HasColumnType("character varying")
                    .HasColumnName("com_numero_documento");

                entity.Property(e => e.ComPasswordWeb)
                    .HasColumnType("character varying")
                    .HasColumnName("com_password_web");

                entity.Property(e => e.ComRazonSocial)
                    .HasColumnType("character varying")
                    .HasColumnName("com_razon_social");

                entity.Property(e => e.ComReferencia).HasColumnName("com_referencia");

                entity.Property(e => e.ComReferenciaDireccion)
                    .HasColumnType("character varying")
                    .HasColumnName("com_referencia_direccion");

                entity.Property(e => e.ComRoles).HasColumnName("com_roles");

                entity.Property(e => e.ComTelefono)
                    .HasColumnType("character varying")
                    .HasColumnName("com_telefono");

                entity.Property(e => e.ComTelefonoResultado)
                    .HasColumnType("character varying")
                    .HasColumnName("com_telefono_resultado");

                entity.Property(e => e.ComTipoDocumento).HasColumnName("com_tipo_documento");

                entity.Property(e => e.ComTipoPersona)
                    .HasColumnType("character varying")
                    .HasColumnName("com_tipo_persona");

                entity.Property(e => e.ComUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("com_usuario_creacion");

                entity.Property(e => e.ComUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("com_usuario_modificacion");

                entity.Property(e => e.ComUsuarioWeb)
                    .HasColumnType("character varying")
                    .HasColumnName("com_usuario_web");

                entity.HasOne(d => d.ComIdActividadComNavigation)
                    .WithMany(p => p.MstCompania)
                    .HasForeignKey(d => d.ComIdActividadCom)
                    .HasConstraintName("MST_COMPANIA_com_id_actividad_com_fkey");

                entity.HasOne(d => d.ComIdDocumentoFiscalNavigation)
                    .WithMany(p => p.MstCompania)
                    .HasForeignKey(d => d.ComIdDocumentoFiscal)
                    .HasConstraintName("MST_COMPANIA_com_id_documento_fiscal_fkey");

                entity.HasOne(d => d.ComIdFormaPagoNavigation)
                    .WithMany(p => p.MstCompania)
                    .HasForeignKey(d => d.ComIdFormaPago)
                    .HasConstraintName("MST_COMPANIA_com_id_forma_pago_fkey");

                entity.HasOne(d => d.ComIdPeriodoCreditoNavigation)
                    .WithMany(p => p.MstCompania)
                    .HasForeignKey(d => d.ComIdPeriodoCredito)
                    .HasConstraintName("MST_COMPANIA_com_id_periodo_credito_fkey");

                entity.HasOne(d => d.ComIdPeriodoFactNavigation)
                    .WithMany(p => p.MstCompania)
                    .HasForeignKey(d => d.ComIdPeriodoFact)
                    .HasConstraintName("MST_COMPANIA_com_id_periodo_fact_fkey");

                entity.HasOne(d => d.ComIdPromotorNavigation)
                    .WithMany(p => p.MstCompania)
                    .HasForeignKey(d => d.ComIdPromotor)
                    .HasConstraintName("MST_COMPANIA_com_id_promotor_fkey");

                entity.HasOne(d => d.ComIdTipoPagoNavigation)
                    .WithMany(p => p.MstCompania)
                    .HasForeignKey(d => d.ComIdTipoPago)
                    .HasConstraintName("MST_COMPANIA_com_id_tipo_pago_fkey");

                entity.HasOne(d => d.ComIdTipoVentaNavigation)
                    .WithMany(p => p.MstCompania)
                    .HasForeignKey(d => d.ComIdTipoVenta)
                    .HasConstraintName("MST_COMPANIA_com_id_tipo_venta_fkey");

                entity.HasOne(d => d.ComIdUbigeoNavigation)
                    .WithMany(p => p.MstCompania)
                    .HasForeignKey(d => d.ComIdUbigeo)
                    .HasConstraintName("MST_COMPANIA_com_id_ubigeo_fkey");

                entity.HasOne(d => d.ComTipoDocumentoNavigation)
                    .WithMany(p => p.MstCompania)
                    .HasForeignKey(d => d.ComTipoDocumento)
                    .HasConstraintName("MST_COMPANIA_com_tipo_documento_fkey");
            });

            modelBuilder.Entity<MstConfiguracionPaqueteSeguro>(entity =>
            {
                entity.HasKey(e => e.CopId)
                    .HasName("MST_CONFIGURACION_PAQUETE_SEGUROS_pkey");

                entity.ToTable("MST_CONFIGURACION_PAQUETE_SEGUROS", "suizasoft");

                entity.Property(e => e.CopId).HasColumnName("cop_id");

                entity.Property(e => e.CopEdadMaxima).HasColumnName("cop_edad_maxima");

                entity.Property(e => e.CopEdadMinima).HasColumnName("cop_edad_minima");

                entity.Property(e => e.CopEstado)
                    .HasColumnName("cop_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CopFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cop_fecha_modificacion");

                entity.Property(e => e.CopFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cop_fecha_registro");

                entity.Property(e => e.CopIdCompania).HasColumnName("cop_id_compania");

                entity.Property(e => e.CopIdPaquete).HasColumnName("cop_id_paquete");

                entity.Property(e => e.CopMontoMaximo)
                    .HasPrecision(13, 2)
                    .HasColumnName("cop_monto_maximo");

                entity.Property(e => e.CopMontoMinimo)
                    .HasPrecision(13, 2)
                    .HasColumnName("cop_monto_minimo");

                entity.Property(e => e.CopSexo).HasColumnName("cop_sexo");

                entity.Property(e => e.CopUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("cop_usuario_modificacion");

                entity.Property(e => e.CopUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("cop_usuario_registro");
            });

            modelBuilder.Entity<MstConvenio>(entity =>
            {
                entity.HasKey(e => e.ConvId)
                    .HasName("MST_CONVENIO_pkey");

                entity.ToTable("MST_CONVENIO", "suizasoft");

                entity.Property(e => e.ConvId)
                    .ValueGeneratedNever()
                    .HasColumnName("conv_id");

                entity.Property(e => e.ConvCodigoAnterior)
                    .HasColumnType("character varying")
                    .HasColumnName("conv_codigo_anterior");

                entity.Property(e => e.ConvDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("conv_descripcion");

                entity.Property(e => e.ConvEstado).HasColumnName("conv_estado");
            });

            modelBuilder.Entity<MstDetalleServicio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MST_DETALLE_SERVICIOS", "suizasoft");

                entity.Property(e => e.DetC10FechaProcservComplem)
                    .HasMaxLength(8)
                    .HasColumnName("det_c10_fecha_procserv_complem")
                    .IsFixedLength();

                entity.Property(e => e.DetC11TipoProfResponPrestac)
                    .HasMaxLength(2)
                    .HasColumnName("det_c11_tipo_prof_respon_prestac")
                    .IsFixedLength();

                entity.Property(e => e.DetC12NumeroColegiatura)
                    .HasMaxLength(6)
                    .HasColumnName("det_c12_numero_colegiatura")
                    .IsFixedLength();

                entity.Property(e => e.DetC13TipodocIdentidadProfesional)
                    .HasMaxLength(1)
                    .HasColumnName("det_c13_tipodoc_identidad_profesional");

                entity.Property(e => e.DetC14NrodocIdentidadProfesional)
                    .HasMaxLength(15)
                    .HasColumnName("det_c14_nrodoc_identidad_profesional")
                    .IsFixedLength();

                entity.Property(e => e.DetC15NroVecesProcedServcomplem)
                    .HasMaxLength(5)
                    .HasColumnName("det_c15_nro_veces_proced_servcomplem")
                    .IsFixedLength();

                entity.Property(e => e.DetC16MontoUnitarioSinimpuestos)
                    .HasPrecision(12, 2)
                    .HasColumnName("det_c16_monto_unitario_sinimpuestos");

                entity.Property(e => e.DetC17CopagoVarProcedservComplem)
                    .HasPrecision(12, 2)
                    .HasColumnName("det_c17_copago_var_procedserv_complem");

                entity.Property(e => e.DetC18CopagoFijoProcservComplem)
                    .HasPrecision(12, 2)
                    .HasColumnName("det_c18_copago_fijo_procserv_complem");

                entity.Property(e => e.DetC19MontoPresentProcservComplem)
                    .HasPrecision(12, 2)
                    .HasColumnName("det_c19_monto_present_procserv_complem");

                entity.Property(e => e.DetC1RucEmpresa)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("det_c1_ruc_empresa")
                    .IsFixedLength();

                entity.Property(e => e.DetC20MontoNocubiertoProcservComplem)
                    .HasPrecision(12, 2)
                    .HasColumnName("det_c20_monto_nocubierto_procserv_complem");

                entity.Property(e => e.DetC21DiagnosticoAsociado)
                    .HasMaxLength(5)
                    .HasColumnName("det_c21_diagnostico_asociado")
                    .IsFixedLength();

                entity.Property(e => e.DetC22ServicioExentoImpuesto)
                    .HasMaxLength(1)
                    .HasColumnName("det_c22_servicio_exento_impuesto");

                entity.Property(e => e.DetC23CodigoRubro)
                    .HasMaxLength(2)
                    .HasColumnName("det_c23_codigo_rubro")
                    .IsFixedLength();

                entity.Property(e => e.DetC2CodigoIpress)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("det_c2_codigo_ipress")
                    .IsFixedLength();

                entity.Property(e => e.DetC3TipoDocumentoPago)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("det_c3_tipo_documento_pago")
                    .IsFixedLength();

                entity.Property(e => e.DetC4NumeroDocumentoPago)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("det_c4_numero_documento_pago")
                    .IsFixedLength();

                entity.Property(e => e.DetC5CorrelativoPrestac)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("det_c5_correlativo_prestac")
                    .IsFixedLength();

                entity.Property(e => e.DetC6CorrelativoServprocPrestac)
                    .HasMaxLength(4)
                    .HasColumnName("det_c6_correlativo_servproc_prestac")
                    .IsFixedLength();

                entity.Property(e => e.DetC7TipoClasifProcServicio)
                    .HasMaxLength(2)
                    .HasColumnName("det_c7_tipo_clasif_proc_servicio")
                    .IsFixedLength();

                entity.Property(e => e.DetC8CodigoClasifProcServicio)
                    .HasMaxLength(10)
                    .HasColumnName("det_c8_codigo_clasif_proc_servicio")
                    .IsFixedLength();

                entity.Property(e => e.DetC9DescripcionServicio)
                    .HasMaxLength(70)
                    .HasColumnName("det_c9_descripcion_servicio")
                    .IsFixedLength();

                entity.Property(e => e.DetCodFina)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("det_cod_fina")
                    .IsFixedLength();

                entity.Property(e => e.DetFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("det_fecha_creacion");

                entity.Property(e => e.DetNroFactura)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("det_nro_factura")
                    .IsFixedLength();

                entity.Property(e => e.DetNumeroAtencion).HasColumnName("det_numero_atencion");

                entity.Property(e => e.DetNumeroLote)
                    .HasMaxLength(7)
                    .HasColumnName("det_numero_lote")
                    .IsFixedLength();

                entity.Property(e => e.DetSerie)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("det_serie")
                    .IsFixedLength();

                entity.Property(e => e.DetUsuarioCreacion).HasColumnName("det_usuario_creacion");
            });

            modelBuilder.Entity<MstDiaSemana>(entity =>
            {
                entity.HasKey(e => e.MdsId)
                    .HasName("MST_DIA_SEMANA_pkey");

                entity.ToTable("MST_DIA_SEMANA", "suizasoft");

                entity.Property(e => e.MdsId).HasColumnName("mds_id");

                entity.Property(e => e.MdsAbreviatura)
                    .HasMaxLength(15)
                    .HasColumnName("mds_abreviatura");

                entity.Property(e => e.MdsFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("mds_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MdsNombre)
                    .HasMaxLength(15)
                    .HasColumnName("mds_nombre");

                entity.Property(e => e.MdsSimbolo)
                    .HasMaxLength(1)
                    .HasColumnName("mds_simbolo");
            });

            modelBuilder.Entity<MstDiagnostico>(entity =>
            {
                entity.HasKey(e => e.DigId)
                    .HasName("MST_DIAGNOSTICO_pkey");

                entity.ToTable("MST_DIAGNOSTICO", "suizasoft");

                entity.HasIndex(e => e.DigCie, "IX_MST_DIAGNOSTICO_dig_cie");

                entity.Property(e => e.DigId)
                    .HasMaxLength(5)
                    .HasColumnName("dig_id")
                    .IsFixedLength();

                entity.Property(e => e.DigCie)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("dig_cie")
                    .IsFixedLength();

                entity.Property(e => e.DigDescripcion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("dig_descripcion");

                entity.HasOne(d => d.DigCieNavigation)
                    .WithMany(p => p.MstDiagnosticos)
                    .HasForeignKey(d => d.DigCie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_DIAGNOSTICO_dig_cie_fkey");
            });

            modelBuilder.Entity<MstDocumentoFacturador>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MST_DOCUMENTO_FACTURADOR", "suizasoft");

                entity.Property(e => e.DofC10CodigoProducto)
                    .HasMaxLength(5)
                    .HasColumnName("dof_c10_codigo_producto")
                    .IsFixedLength();

                entity.Property(e => e.DofC11CantidadPrestacionesSalud)
                    .HasMaxLength(5)
                    .HasColumnName("dof_c11_cantidad_prestaciones_salud")
                    .IsFixedLength();

                entity.Property(e => e.DofC12MecanismoPago)
                    .HasMaxLength(2)
                    .HasColumnName("dof_c12_mecanismo_pago")
                    .IsFixedLength();

                entity.Property(e => e.DofC13SubtipoMecanismoPago)
                    .HasMaxLength(3)
                    .HasColumnName("dof_c13_subtipo_mecanismo_pago")
                    .IsFixedLength();

                entity.Property(e => e.DofC14MontoPrepactado)
                    .HasPrecision(12, 2)
                    .HasColumnName("dof_c14_monto_prepactado");

                entity.Property(e => e.DofC15FechaInicioPeriodoPrepactado)
                    .HasMaxLength(8)
                    .HasColumnName("dof_c15_fecha_inicio_periodo_prepactado")
                    .IsFixedLength();

                entity.Property(e => e.DofC16TipoMoneda)
                    .HasMaxLength(1)
                    .HasColumnName("dof_c16_tipo_moneda");

                entity.Property(e => e.DofC17MontoExoneradoIgv)
                    .HasPrecision(12, 2)
                    .HasColumnName("dof_c17_monto_exonerado_igv");

                entity.Property(e => e.DofC18TotalCopagoAfectoIgvSinigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("dof_c18_total_copago_afecto_igv_sinigv");

                entity.Property(e => e.DofC19TotalCopagoFijoExoneradoIgv)
                    .HasPrecision(12, 2)
                    .HasColumnName("dof_c19_total_copago_fijo_exonerado_igv");

                entity.Property(e => e.DofC1FechaEnvio)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("dof_c1_fecha_envio")
                    .IsFixedLength();

                entity.Property(e => e.DofC20TotalCopagoVariableAfectoIgvSinigv)
                    .HasPrecision(12, 2)
                    .HasColumnName("dof_c20_total_copago_variable_afecto_igv_sinigv");

                entity.Property(e => e.DofC21TotalCopagoVariableExoneradoIgv)
                    .HasPrecision(12, 2)
                    .HasColumnName("dof_c21_total_copago_variable_exonerado_igv");

                entity.Property(e => e.DofC22BaseImponible)
                    .HasPrecision(12, 2)
                    .HasColumnName("dof_c22_base_imponible");

                entity.Property(e => e.DofC23IgvMontoFacturado)
                    .HasPrecision(12, 2)
                    .HasColumnName("dof_c23_igv_monto_facturado");

                entity.Property(e => e.DofC24MontoTotalFacturado)
                    .HasPrecision(12, 2)
                    .HasColumnName("dof_c24_monto_total_facturado");

                entity.Property(e => e.DofC25TipoIdentificacionNota)
                    .HasMaxLength(1)
                    .HasColumnName("dof_c25_tipo_identificacion_nota");

                entity.Property(e => e.DofC26NumeroNota)
                    .HasMaxLength(12)
                    .HasColumnName("dof_c26_numero_nota")
                    .IsFixedLength();

                entity.Property(e => e.DofC27MontoNota)
                    .HasMaxLength(12)
                    .HasColumnName("dof_c27_monto_nota")
                    .IsFixedLength();

                entity.Property(e => e.DofC28FechaNota)
                    .HasMaxLength(8)
                    .HasColumnName("dof_c28_fecha_nota")
                    .IsFixedLength();

                entity.Property(e => e.DofC29MotivoNota)
                    .HasMaxLength(1)
                    .HasColumnName("dof_c29_motivo_nota");

                entity.Property(e => e.DofC2HoraEnvio)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("dof_c2_hora_envio")
                    .IsFixedLength();

                entity.Property(e => e.DofC30FechaPrimerEnvioDocfac)
                    .HasMaxLength(8)
                    .HasColumnName("dof_c30_fecha_primer_envio_docfac")
                    .IsFixedLength();

                entity.Property(e => e.DofC31IndicadorFacturaGlobal)
                    .HasMaxLength(1)
                    .HasColumnName("dof_c31_indicador_factura_global");

                entity.Property(e => e.DofC3NumeroLote)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasColumnName("dof_c3_numero_lote")
                    .IsFixedLength();

                entity.Property(e => e.DofC4CodFina)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("dof_c4_cod_fina")
                    .IsFixedLength();

                entity.Property(e => e.DofC5RucEmpresa)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("dof_c5_ruc_empresa")
                    .IsFixedLength();

                entity.Property(e => e.DofC6CodigoIpress)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("dof_c6_codigo_ipress")
                    .IsFixedLength();

                entity.Property(e => e.DofC7TipoDocumentoPago)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("dof_c7_tipo_documento_pago")
                    .IsFixedLength();

                entity.Property(e => e.DofC8NumeroDocumentoPago)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("dof_c8_numero_documento_pago")
                    .IsFixedLength();

                entity.Property(e => e.DofC9FechaEmision)
                    .HasMaxLength(8)
                    .HasColumnName("dof_c9_fecha_emision")
                    .IsFixedLength();

                entity.Property(e => e.DofCodFina)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("dof_cod_fina")
                    .IsFixedLength();

                entity.Property(e => e.DofCorrelativo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("dof_correlativo")
                    .IsFixedLength();

                entity.Property(e => e.DofFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dof_fecha_creacion");

                entity.Property(e => e.DofNumeroAtencion).HasColumnName("dof_numero_atencion");

                entity.Property(e => e.DofNumeroLote)
                    .HasMaxLength(7)
                    .HasColumnName("dof_numero_lote")
                    .IsFixedLength();

                entity.Property(e => e.DofSerie)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("dof_serie")
                    .IsFixedLength();

                entity.Property(e => e.DofUsuarioCreacion).HasColumnName("dof_usuario_creacion");
            });

            modelBuilder.Entity<MstDocumentoFiscal>(entity =>
            {
                entity.HasKey(e => e.DfiId)
                    .HasName("MST_DOCUMENTO_FISCAL_pkey");

                entity.ToTable("MST_DOCUMENTO_FISCAL", "suizasoft");

                entity.Property(e => e.DfiId)
                    .ValueGeneratedNever()
                    .HasColumnName("dfi_id");

                entity.Property(e => e.DfiDescripcion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("dfi_descripcion");
            });

            modelBuilder.Entity<MstEstadoCivil>(entity =>
            {
                entity.HasKey(e => e.EciId)
                    .HasName("MST_ESTADO_CIVIL_pkey");

                entity.ToTable("MST_ESTADO_CIVIL", "suizasoft");

                entity.Property(e => e.EciId).HasColumnName("eci_id");

                entity.Property(e => e.EciDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("eci_descripcion");
            });

            modelBuilder.Entity<MstFactorRh>(entity =>
            {
                entity.HasKey(e => e.FrhId)
                    .HasName("MST_FACTOR_RH_pkey");

                entity.ToTable("MST_FACTOR_RH", "suizasoft");

                entity.HasIndex(e => e.FrhNombre, "factor_rh_nombre_unique")
                    .IsUnique();

                entity.Property(e => e.FrhId).HasColumnName("frh_id");

                entity.Property(e => e.FrhEstado).HasColumnName("frh_estado");

                entity.Property(e => e.FrhNombre)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("frh_nombre");
            });

            modelBuilder.Entity<MstFacturaCabecera>(entity =>
            {
                entity.HasKey(e => e.FacId)
                    .HasName("MST_FACTURA_CABERERA_pkey");

                entity.ToTable("MST_FACTURA_CABECERA", "suizasoft");

                entity.HasIndex(e => e.FacIdCompania, "IX_MST_FACTURA_CABECERA_fac_id_compania");

                entity.HasIndex(e => e.FacIdDocumento, "IX_MST_FACTURA_CABECERA_fac_id_documento");

                entity.HasIndex(e => e.FacIdEstado, "IX_MST_FACTURA_CABECERA_fac_id_estado");

                entity.HasIndex(e => e.FacIdFormaPago, "IX_MST_FACTURA_CABECERA_fac_id_forma_pago");

                entity.HasIndex(e => e.FacIdModalidad, "IX_MST_FACTURA_CABECERA_fac_id_modalidad");

                entity.HasIndex(e => e.FacIdModulo, "IX_MST_FACTURA_CABECERA_fac_id_modulo");

                entity.HasIndex(e => e.FacIdMoneda, "IX_MST_FACTURA_CABECERA_fac_id_moneda");

                entity.HasIndex(e => e.FacIdPeriodoCredDias, "IX_MST_FACTURA_CABECERA_fac_id_periodo_cred_dias");

                entity.HasIndex(e => e.FacIdTipoDocVenta, "IX_MST_FACTURA_CABECERA_fac_id_tipo_doc_venta");

                entity.HasIndex(e => e.FacIdTipoOperacionNcc, "IX_MST_FACTURA_CABECERA_fac_id_tipo_operacion_ncc");

                entity.HasIndex(e => new { e.FacSucursal, e.FacIdTipoDocVenta, e.FacSerie, e.FacCorrelativo }, "MST_FACTURA_CABERERA_fac_sucursal_fac_id_tipo_doc_venta_fac_key")
                    .IsUnique();

                entity.Property(e => e.FacId).HasColumnName("fac_id");

                entity.Property(e => e.FacAnio)
                    .HasMaxLength(2)
                    .HasColumnName("fac_anio");

                entity.Property(e => e.FacClaveWeb)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_clave_web");

                entity.Property(e => e.FacCorrelativo).HasColumnName("fac_correlativo");

                entity.Property(e => e.FacCorreo)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_correo");

                entity.Property(e => e.FacDomicilioFiscal)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_domicilio_fiscal");

                entity.Property(e => e.FacFeFechaEnvio)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fac_fe_fecha_envio");

                entity.Property(e => e.FacFeFlagEnvio)
                    .HasColumnName("fac_fe_flag_envio")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FacFeIdError).HasColumnName("fac_fe_id_error");

                entity.Property(e => e.FacFechaAnulacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fac_fecha_anulacion");

                entity.Property(e => e.FacFechaCancelacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fac_fecha_cancelacion");

                entity.Property(e => e.FacFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fac_fecha_creacion");

                entity.Property(e => e.FacFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fac_fecha_modificacion");

                entity.Property(e => e.FacFechaVencimiento)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fac_fecha_vencimiento");

                entity.Property(e => e.FacFlagEnvioCorreoCliente).HasColumnName("fac_flag_envio_correo_cliente");

                entity.Property(e => e.FacIdCompania).HasColumnName("fac_id_compania");

                entity.Property(e => e.FacIdDocumento).HasColumnName("fac_id_documento");

                entity.Property(e => e.FacIdEstado).HasColumnName("fac_id_estado");

                entity.Property(e => e.FacIdFormaPago).HasColumnName("fac_id_forma_pago");

                entity.Property(e => e.FacIdModalidad).HasColumnName("fac_id_modalidad");

                entity.Property(e => e.FacIdModulo).HasColumnName("fac_id_modulo");

                entity.Property(e => e.FacIdMoneda).HasColumnName("fac_id_moneda");

                entity.Property(e => e.FacIdPeriodoCredDias)
                    .HasColumnName("fac_id_periodo_cred_dias")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FacIdTipoDocVenta).HasColumnName("fac_id_tipo_doc_venta");

                entity.Property(e => e.FacIdTipoOperacionNcc).HasColumnName("fac_id_tipo_operacion_ncc");

                entity.Property(e => e.FacMotivoAnulacion)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_motivo_anulacion");

                entity.Property(e => e.FacNombrePaciente)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_nombre_paciente");

                entity.Property(e => e.FacNumeroDocumento)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_numero_documento");

                entity.Property(e => e.FacObservacion)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_observacion");

                entity.Property(e => e.FacPeriodo)
                    .HasMaxLength(2)
                    .HasColumnName("fac_periodo");

                entity.Property(e => e.FacRazonSocial)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_razon_social");

                entity.Property(e => e.FacSapError)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_sap_error");

                entity.Property(e => e.FacSapFechaEnvio)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fac_sap_fecha_envio");

                entity.Property(e => e.FacSapFlagAnulacion).HasColumnName("fac_sap_flag_anulacion");

                entity.Property(e => e.FacSapFlagEnvio)
                    .HasColumnName("fac_sap_flag_envio")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FacSapIdError).HasColumnName("fac_sap_id_error");

                entity.Property(e => e.FacSapPagoEnvio).HasColumnName("fac_sap_pago_envio");

                entity.Property(e => e.FacSerie)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_serie");

                entity.Property(e => e.FacSerieCorrelativo)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_serie_correlativo");

                entity.Property(e => e.FacSucursal)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_sucursal");

                entity.Property(e => e.FacTipoCambio)
                    .HasPrecision(13, 2)
                    .HasColumnName("fac_tipo_cambio");

                entity.Property(e => e.FacTipoFact)
                    .HasMaxLength(1)
                    .HasColumnName("fac_tipo_fact");

                entity.Property(e => e.FacTotalLetras)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_total_letras");

                entity.Property(e => e.FacUsuarioAnulacion)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_usuario_anulacion");

                entity.Property(e => e.FacUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_usuario_creacion");

                entity.Property(e => e.FacUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_usuario_modificacion");

                entity.Property(e => e.FacUsuarioWeb)
                    .HasColumnType("character varying")
                    .HasColumnName("fac_usuario_web");

                entity.Property(e => e.FacValorIgvDol)
                    .HasPrecision(13, 2)
                    .HasColumnName("fac_valor_igv_dol");

                entity.Property(e => e.FacValorIgvSol)
                    .HasPrecision(13, 2)
                    .HasColumnName("fac_valor_igv_sol");

                entity.Property(e => e.FacValorSubtotalDol)
                    .HasPrecision(13, 2)
                    .HasColumnName("fac_valor_subtotal_dol");

                entity.Property(e => e.FacValorSubtotalSol)
                    .HasPrecision(13, 2)
                    .HasColumnName("fac_valor_subtotal_sol");

                entity.Property(e => e.FacValorTotalDol)
                    .HasPrecision(13, 2)
                    .HasColumnName("fac_valor_total_dol");

                entity.Property(e => e.FacValorTotalSol)
                    .HasPrecision(13, 2)
                    .HasColumnName("fac_valor_total_sol");

                entity.HasOne(d => d.FacIdCompaniaNavigation)
                    .WithMany(p => p.MstFacturaCabeceras)
                    .HasForeignKey(d => d.FacIdCompania)
                    .HasConstraintName("MST_FACTURA_CABECERA_fac_id_compania_fkey");

                entity.HasOne(d => d.FacIdDocumentoNavigation)
                    .WithMany(p => p.MstFacturaCabeceras)
                    .HasForeignKey(d => d.FacIdDocumento)
                    .HasConstraintName("MST_FACTURA_CABERERA_fac_id_documento_fkey");

                entity.HasOne(d => d.FacIdEstadoNavigation)
                    .WithMany(p => p.MstFacturaCabeceras)
                    .HasForeignKey(d => d.FacIdEstado)
                    .HasConstraintName("MST_FACTURA_CABECERA_fac_id_estado_fkey");

                entity.HasOne(d => d.FacIdFormaPagoNavigation)
                    .WithMany(p => p.MstFacturaCabeceras)
                    .HasForeignKey(d => d.FacIdFormaPago)
                    .HasConstraintName("MST_FACTURA_CABECERA_fac_id_forma_pago_fkey");

                entity.HasOne(d => d.FacIdModalidadNavigation)
                    .WithMany(p => p.MstFacturaCabeceras)
                    .HasForeignKey(d => d.FacIdModalidad)
                    .HasConstraintName("MST_FACTURA_CABECERA_fac_id_modalidad_fkey");

                entity.HasOne(d => d.FacIdModuloNavigation)
                    .WithMany(p => p.MstFacturaCabeceras)
                    .HasForeignKey(d => d.FacIdModulo)
                    .HasConstraintName("MST_FACTURA_CABECERA_fac_id_modulo_fkey");

                entity.HasOne(d => d.FacIdMonedaNavigation)
                    .WithMany(p => p.MstFacturaCabeceras)
                    .HasForeignKey(d => d.FacIdMoneda)
                    .HasConstraintName("MST_FACTURA_CABERERA_fac_id_moneda_fkey");

                entity.HasOne(d => d.FacIdPeriodoCredDiasNavigation)
                    .WithMany(p => p.MstFacturaCabeceras)
                    .HasForeignKey(d => d.FacIdPeriodoCredDias)
                    .HasConstraintName("MST_FACTURA_CABECERA_fac_id_periodo_cred_dias_fkey");

                entity.HasOne(d => d.FacIdTipoDocVentaNavigation)
                    .WithMany(p => p.MstFacturaCabeceras)
                    .HasForeignKey(d => d.FacIdTipoDocVenta)
                    .HasConstraintName("MST_FACTURA_CABERERA_fac_id_tipo_doc_venta_fkey");

                entity.HasOne(d => d.FacIdTipoOperacionNccNavigation)
                    .WithMany(p => p.MstFacturaCabeceras)
                    .HasForeignKey(d => d.FacIdTipoOperacionNcc)
                    .HasConstraintName("MST_FACTURA_CABECERA_fac_id_tipo_operacion_ncc_fkey");

                entity.HasOne(d => d.FacSucursalNavigation)
                    .WithMany(p => p.MstFacturaCabeceras)
                    .HasForeignKey(d => d.FacSucursal)
                    .HasConstraintName("MST_FACTURA_CABECERA_fac_sucursal_fkey");
            });

            modelBuilder.Entity<MstFeriado>(entity =>
            {
                entity.HasKey(e => e.FerId)
                    .HasName("MST_FERIADOS_pkey");

                entity.ToTable("MST_FERIADOS", "suizasoft");

                entity.HasIndex(e => e.FerIdSucursal, "IX_MST_FERIADOS_fer_id_sucursal");

                entity.Property(e => e.FerId).HasColumnName("fer_id");

                entity.Property(e => e.FerDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("fer_descripcion");

                entity.Property(e => e.FerEstado).HasColumnName("fer_estado");

                entity.Property(e => e.FerFecha).HasColumnName("fer_fecha");

                entity.Property(e => e.FerFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fer_fecha_creacion");

                entity.Property(e => e.FerFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fer_fecha_modificacion");

                entity.Property(e => e.FerHoraFin).HasColumnName("fer_hora_fin");

                entity.Property(e => e.FerHoraInicio).HasColumnName("fer_hora_inicio");

                entity.Property(e => e.FerIdSucursal)
                    .HasColumnType("character varying")
                    .HasColumnName("fer_id_sucursal");

                entity.Property(e => e.FerTipo)
                    .HasColumnType("character varying")
                    .HasColumnName("fer_tipo");

                entity.Property(e => e.FerUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("fer_usuario_creacion");

                entity.Property(e => e.FerUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("fer_usuario_modificacion");

                entity.HasOne(d => d.FerIdSucursalNavigation)
                    .WithMany(p => p.MstFeriados)
                    .HasForeignKey(d => d.FerIdSucursal)
                    .HasConstraintName("MST_FERIADOS_fer_id_sucursal_fkey");
            });

            modelBuilder.Entity<MstFormaPago>(entity =>
            {
                entity.HasKey(e => e.FpaId)
                    .HasName("MST_FORMA_PAGO_pkey");

                entity.ToTable("MST_FORMA_PAGO", "suizasoft");

                entity.Property(e => e.FpaId)
                    .ValueGeneratedNever()
                    .HasColumnName("fpa_id");

                entity.Property(e => e.FpaCodigoAnterior)
                    .HasColumnType("character varying")
                    .HasColumnName("fpa_codigo_anterior");

                entity.Property(e => e.FpaDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("fpa_descripcion");

                entity.Property(e => e.FpaEstado).HasColumnName("fpa_estado");

                entity.Property(e => e.FpaGrupoSap)
                    .HasColumnType("character varying")
                    .HasColumnName("fpa_grupo_sap");
            });

            modelBuilder.Entity<MstFormaterium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MST_FORMATERIA", "suizasoft");

                entity.HasIndex(e => e.MfoCodigo, "MST_FORMATERIA_mfo_codigo_key")
                    .IsUnique();

                entity.Property(e => e.MfoActivo)
                    .HasColumnName("mfo_activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.MfoCodigo)
                    .HasMaxLength(30)
                    .HasColumnName("mfo_codigo");

                entity.Property(e => e.MfoFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("mfo_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MfoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("mfo_id");

                entity.Property(e => e.MfoNombre)
                    .HasMaxLength(100)
                    .HasColumnName("mfo_nombre");

                entity.Property(e => e.MfoUrl)
                    .HasMaxLength(300)
                    .HasColumnName("mfo_url");
            });

            modelBuilder.Entity<MstGrupoSanguineo>(entity =>
            {
                entity.HasKey(e => e.GrsngId)
                    .HasName("MST_GRUPO_SANGUINEO_pkey");

                entity.ToTable("MST_GRUPO_SANGUINEO", "suizasoft");

                entity.HasIndex(e => e.GrsngNombre, "gru_sanguineo_nombre_unique")
                    .IsUnique();

                entity.Property(e => e.GrsngId).HasColumnName("grsng_id");

                entity.Property(e => e.GrsngEstado).HasColumnName("grsng_estado");

                entity.Property(e => e.GrsngNombre)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("grsng_nombre");
            });

            modelBuilder.Entity<MstGrupoSeguro>(entity =>
            {
                entity.HasKey(e => e.GruId)
                    .HasName("MST_GRUPO_SEGUROS_pkey");

                entity.ToTable("MST_GRUPO_SEGUROS", "suizasoft");

                entity.Property(e => e.GruId).HasColumnName("gru_id");

                entity.Property(e => e.GruEstado)
                    .HasColumnName("gru_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.GruFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("gru_fecha_modificacion");

                entity.Property(e => e.GruFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("gru_fecha_registro");

                entity.Property(e => e.GruNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("gru_nombre");

                entity.Property(e => e.GruObservacion)
                    .HasColumnType("character varying")
                    .HasColumnName("gru_observacion");

                entity.Property(e => e.GruRuc)
                    .HasColumnType("character varying")
                    .HasColumnName("gru_ruc");

                entity.Property(e => e.GruUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("gru_usuario_modificacion");

                entity.Property(e => e.GruUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("gru_usuario_registro");
            });

            modelBuilder.Entity<MstGrupoServicioOmd>(entity =>
            {
                entity.HasKey(e => e.GsoId)
                    .HasName("MST_GRUPO_SERVICIO_OMD_pkey");

                entity.ToTable("MST_GRUPO_SERVICIO_OMD", "suizasoft");

                entity.Property(e => e.GsoId).HasColumnName("gso_id");

                entity.Property(e => e.GsoCodigoFox)
                    .HasMaxLength(6)
                    .HasColumnName("gso_codigo_fox");

                entity.Property(e => e.GsoEstado)
                    .HasColumnName("gso_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.GsoFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("gso_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.GsoFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("gso_fecha_modificacion");

                entity.Property(e => e.GsoGruId).HasColumnName("gso_gru_id");

                entity.Property(e => e.GsoIndex).HasColumnName("gso_index");

                entity.Property(e => e.GsoVistaServicio).HasColumnName("gso_vista_servicio");
            });

            modelBuilder.Entity<MstJefePromotor>(entity =>
            {
                entity.HasKey(e => e.JprId)
                    .HasName("MST_JEFE_PROMOTOR_pkey");

                entity.ToTable("MST_JEFE_PROMOTOR", "suizasoft");

                entity.Property(e => e.JprId).HasColumnName("jpr_id");

                entity.Property(e => e.JprCorreo)
                    .HasColumnType("character varying")
                    .HasColumnName("jpr_correo");

                entity.Property(e => e.JprEstado).HasColumnName("jpr_estado");

                entity.Property(e => e.JprFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("jpr_fecha_creacion");

                entity.Property(e => e.JprFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("jpr_fecha_modificacion");

                entity.Property(e => e.JprNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("jpr_nombre");

                entity.Property(e => e.JprUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("jpr_usuario_creacion");

                entity.Property(e => e.JprUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("jpr_usuario_modificacion");
            });

            modelBuilder.Entity<MstLabBiopsium>(entity =>
            {
                entity.HasKey(e => e.LabId)
                    .HasName("MST_LAB_BIOPSIA_pkey");

                entity.ToTable("MST_LAB_BIOPSIA", "suizasoft");

                entity.HasIndex(e => new { e.LabIdTicket, e.LabPeriodoTicket, e.LabAnioTicket, e.LabSucursalTicket }, "MST_LAB_BIOPSIA_unique")
                    .IsUnique();

                entity.Property(e => e.LabId).HasColumnName("lab_id");

                entity.Property(e => e.LabAnioTicket)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lab_anio_ticket")
                    .IsFixedLength();

                entity.Property(e => e.LabDescripcionMacroscopica)
                    .HasColumnType("character varying")
                    .HasColumnName("lab_descripcion_macroscopica");

                entity.Property(e => e.LabDescripcionMicroscopica)
                    .HasColumnType("character varying")
                    .HasColumnName("lab_descripcion_microscopica");

                entity.Property(e => e.LabFechaAnulacion)
                    .HasColumnType("character varying")
                    .HasColumnName("lab_fecha_anulacion");

                entity.Property(e => e.LabFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lab_fecha_modificacion");

                entity.Property(e => e.LabFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lab_fecha_registro");

                entity.Property(e => e.LabHallazgo).HasColumnName("lab_hallazgo");

                entity.Property(e => e.LabIdTicket).HasColumnName("lab_id_ticket");

                entity.Property(e => e.LabMotivoAnulacion)
                    .HasColumnType("character varying")
                    .HasColumnName("lab_motivo_anulacion");

                entity.Property(e => e.LabMuestra)
                    .HasColumnType("character varying")
                    .HasColumnName("lab_muestra");

                entity.Property(e => e.LabPeriodoTicket)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lab_periodo_ticket")
                    .IsFixedLength();

                entity.Property(e => e.LabRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("lab_registro");

                entity.Property(e => e.LabRutaImagen1)
                    .HasColumnType("character varying")
                    .HasColumnName("lab_ruta_imagen1");

                entity.Property(e => e.LabRutaImagen2)
                    .HasColumnType("character varying")
                    .HasColumnName("lab_ruta_imagen2");

                entity.Property(e => e.LabRutaImagen3)
                    .HasColumnType("character varying")
                    .HasColumnName("lab_ruta_imagen3");

                entity.Property(e => e.LabSucursalTicket)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lab_sucursal_ticket")
                    .IsFixedLength();

                entity.Property(e => e.LabUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("lab_usuario_modificacion");

                entity.Property(e => e.LabUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("lab_usuario_registro");

                entity.Property(e => e.PerEstado)
                    .HasColumnName("per_estado")
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<MstLabGrupoEtnico>(entity =>
            {
                entity.HasKey(e => e.GreId)
                    .HasName("MST_LAB_GRUPO_ETNICO_pkey");

                entity.ToTable("MST_LAB_GRUPO_ETNICO", "suizasoft");

                entity.Property(e => e.GreId)
                    .ValueGeneratedNever()
                    .HasColumnName("gre_id");

                entity.Property(e => e.GreEstado).HasColumnName("gre_estado");

                entity.Property(e => e.GreNombre)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("gre_nombre");
            });

            modelBuilder.Entity<MstLabLoteLaboratorioCabecera>(entity =>
            {
                entity.HasKey(e => e.LosId)
                    .HasName("MST_LAB_LOTE_LABORATORIO_pkey");

                entity.ToTable("MST_LAB_LOTE_LABORATORIO_CABECERA", "suizasoft");

                entity.HasIndex(e => e.LosIdCompania, "IX_MST_LAB_LOTE_LABORATORIO_CABECERA_los_id_compania");

                entity.Property(e => e.LosId).HasColumnName("los_id");

                entity.Property(e => e.LosEstado).HasColumnName("los_estado");

                entity.Property(e => e.LosFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("los_fecha_registro");

                entity.Property(e => e.LosIdCompania).HasColumnName("los_id_compania");

                entity.Property(e => e.LosUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("los_usuario_registro");

                entity.HasOne(d => d.LosIdCompaniaNavigation)
                    .WithMany(p => p.MstLabLoteLaboratorioCabeceras)
                    .HasForeignKey(d => d.LosIdCompania)
                    .HasConstraintName("MST_LOTE_CABECERA_COMPANIA_id_fkey");
            });

            modelBuilder.Entity<MstLabMuestraRechazadaCabecera>(entity =>
            {
                entity.HasKey(e => e.MurIdMueRechazada)
                    .HasName("MST_MUESTRA_RECHAZADA_CABECERA");

                entity.ToTable("MST_LAB_MUESTRA_RECHAZADA_CABECERA", "suizasoft");

                entity.HasIndex(e => e.MurIdCompania, "IX_MST_LAB_MUESTRA_RECHAZADA_CABECERA_mur_id_compania");

                entity.HasIndex(e => e.MurYearorden, "IX_MST_LAB_MUESTRA_RECHAZADA_CABECERA_mur_yearorden");

                entity.Property(e => e.MurIdMueRechazada).HasColumnName("mur_id_mue_rechazada");

                entity.Property(e => e.MurAnio)
                    .HasColumnType("character varying")
                    .HasColumnName("mur_anio");

                entity.Property(e => e.MurEstado).HasColumnName("mur_estado");

                entity.Property(e => e.MurFechaAnulacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("mur_fecha_anulacion");

                entity.Property(e => e.MurFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("mur_fecha_modificacion");

                entity.Property(e => e.MurFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("mur_fecha_registro");

                entity.Property(e => e.MurFlagCerrado).HasColumnName("mur_flag_cerrado");

                entity.Property(e => e.MurIdCompania).HasColumnName("mur_id_compania");

                entity.Property(e => e.MurIdSucursal)
                    .HasColumnType("character varying")
                    .HasColumnName("mur_id_sucursal");

                entity.Property(e => e.MurMotivoAnulacion)
                    .HasColumnType("character varying")
                    .HasColumnName("mur_motivo_anulacion");

                entity.Property(e => e.MurPaciente)
                    .HasColumnType("character varying")
                    .HasColumnName("mur_paciente");

                entity.Property(e => e.MurPeriodo)
                    .HasColumnType("character varying")
                    .HasColumnName("mur_periodo");

                entity.Property(e => e.MurTicketIdCabecera).HasColumnName("mur_ticket_id_cabecera");

                entity.Property(e => e.MurTicketIdSucursal)
                    .HasColumnType("character varying")
                    .HasColumnName("mur_ticket_id_sucursal");

                entity.Property(e => e.MurUsuarioAnulacion)
                    .HasColumnType("character varying")
                    .HasColumnName("mur_usuario_anulacion");

                entity.Property(e => e.MurUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("mur_usuario_modificacion");

                entity.Property(e => e.MurUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("mur_usuario_registro");

                entity.Property(e => e.MurYearorden)
                    .HasColumnType("character varying")
                    .HasColumnName("mur_yearorden");

                entity.HasOne(d => d.MurIdCompaniaNavigation)
                    .WithMany(p => p.MstLabMuestraRechazadaCabeceras)
                    .HasForeignKey(d => d.MurIdCompania)
                    .HasConstraintName("MUESTRA_RECHAZADA_CAB_MST_COMPANIA_id_compania_fkey");

                entity.HasOne(d => d.MurYearordenNavigation)
                    .WithMany(p => p.MstLabMuestraRechazadaCabeceras)
                    .HasPrincipalKey(p => p.OrsYearorden)
                    .HasForeignKey(d => d.MurYearorden)
                    .HasConstraintName("MST_MUESTRA_RECHAZADA_orden_servicio_cab_yearorder_fkey");
            });

            modelBuilder.Entity<MstLabOrdenAntibiogramaCabecera>(entity =>
            {
                entity.HasKey(e => new { e.LoaYearorden, e.LoaIdServicio, e.LoaIdExaCodigo, e.LoaPanelCodigo })
                    .HasName("MST_LAB_ORDEN_ANTIBIOGRAMA_CABECERA_pkey");

                entity.ToTable("MST_LAB_ORDEN_ANTIBIOGRAMA_CABECERA", "suizasoft");

                entity.Property(e => e.LoaYearorden)
                    .HasMaxLength(20)
                    .HasColumnName("loa_yearorden");

                entity.Property(e => e.LoaIdServicio)
                    .HasMaxLength(20)
                    .HasColumnName("loa_id_servicio");

                entity.Property(e => e.LoaIdExaCodigo)
                    .HasMaxLength(10)
                    .HasColumnName("loa_id_exa_codigo");

                entity.Property(e => e.LoaPanelCodigo).HasColumnName("loa_panel_codigo");

                entity.Property(e => e.LoaCultivoNivel1)
                    .HasMaxLength(10)
                    .HasColumnName("loa_cultivo_nivel1");

                entity.Property(e => e.LoaCultivoNivel1Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("loa_cultivo_nivel1_descripcion");

                entity.Property(e => e.LoaCultivoNivel2)
                    .HasMaxLength(10)
                    .HasColumnName("loa_cultivo_nivel2");

                entity.Property(e => e.LoaCultivoNivel2Bacteria)
                    .HasMaxLength(50)
                    .HasColumnName("loa_cultivo_nivel2_bacteria");

                entity.Property(e => e.LoaCultivoNivel2Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("loa_cultivo_nivel2_descripcion");

                entity.Property(e => e.LoaCultivoNivel2Resultado)
                    .HasMaxLength(50)
                    .HasColumnName("loa_cultivo_nivel2_resultado");

                entity.Property(e => e.LoaCultivoNivel3)
                    .HasMaxLength(10)
                    .HasColumnName("loa_cultivo_nivel3");

                entity.Property(e => e.LoaCultivoNivel3Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("loa_cultivo_nivel3_descripcion");

                entity.Property(e => e.LoaEstado).HasColumnName("loa_estado");

                entity.Property(e => e.LoaFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("loa_fecha_modificacion");

                entity.Property(e => e.LoaFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("loa_fecha_registro");

                entity.Property(e => e.LoaLisCodigo).HasColumnName("loa_lis_codigo");

                entity.Property(e => e.LoaPanelDescripcion)
                    .HasMaxLength(100)
                    .HasColumnName("loa_panel_descripcion");

                entity.Property(e => e.LoaUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("loa_usuario_modificacion");

                entity.Property(e => e.LoaUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("loa_usuario_registro");
            });

            modelBuilder.Entity<MstLabOrdenAntibiogramaDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MST_LAB_ORDEN_ANTIBIOGRAMA_DETALLE", "suizasoft");

                entity.Property(e => e.LadAntibioCodigo)
                    .HasMaxLength(10)
                    .HasColumnName("lad_antibio_codigo");

                entity.Property(e => e.LadAntibioDescripcion)
                    .HasMaxLength(100)
                    .HasColumnName("lad_antibio_descripcion");

                entity.Property(e => e.LadAntibioResiste)
                    .HasMaxLength(20)
                    .HasColumnName("lad_antibio_resiste");

                entity.Property(e => e.LadAntibioSensibi)
                    .HasMaxLength(20)
                    .HasColumnName("lad_antibio_sensibi");

                entity.Property(e => e.LadEstado).HasColumnName("lad_estado");

                entity.Property(e => e.LadFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lad_fecha_modificacion");

                entity.Property(e => e.LadFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lad_fecha_registro");

                entity.Property(e => e.LadIdExaCodigo)
                    .HasMaxLength(10)
                    .HasColumnName("lad_id_exa_codigo");

                entity.Property(e => e.LadIdServicio)
                    .HasMaxLength(20)
                    .HasColumnName("lad_id_servicio");

                entity.Property(e => e.LadLisCodigo).HasColumnName("lad_lis_codigo");

                entity.Property(e => e.LadMicroCodigo)
                    .HasMaxLength(10)
                    .HasColumnName("lad_micro_codigo");

                entity.Property(e => e.LadMicroDescripcion)
                    .HasMaxLength(100)
                    .HasColumnName("lad_micro_descripcion");

                entity.Property(e => e.LadPanelCodigo).HasColumnName("lad_panel_codigo");

                entity.Property(e => e.LadSubtant)
                    .HasMaxLength(100)
                    .HasColumnName("lad_subtant");

                entity.Property(e => e.LadUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("lad_usuario_modificacion");

                entity.Property(e => e.LadUsuarioRegistro)
                    .HasMaxLength(100)
                    .HasColumnName("lad_usuario_registro");

                entity.Property(e => e.LadYearorden)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("lad_yearorden");
            });

            modelBuilder.Entity<MstLabOrdenEscaneo>(entity =>
            {
                entity.HasKey(e => e.LoeId)
                    .HasName("MST_LAB_ORDEN_ESCANEO_pkey");

                entity.ToTable("MST_LAB_ORDEN_ESCANEO", "suizasoft");

                entity.HasIndex(e => e.LoeIdSucursalEscaneo, "IX_MST_LAB_ORDEN_ESCANEO_loe_id_sucursal_escaneo");

                entity.HasIndex(e => new { e.LoeTicketIdCabecera, e.LoeTicketPeriodo, e.LoeTicketAnio, e.LoeTicketIdSucursal }, "IX_MST_LAB_ORDEN_ESCANEO_loe_ticket_id_cabecera_loe_ticket_per~");

                entity.Property(e => e.LoeId).HasColumnName("loe_id");

                entity.Property(e => e.LoeEstado).HasColumnName("loe_estado");

                entity.Property(e => e.LoeFechaAnulacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("loe_fecha_anulacion");

                entity.Property(e => e.LoeFechaDesescaneo)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("loe_fecha_desescaneo");

                entity.Property(e => e.LoeFechaEscaneo)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("loe_fecha_escaneo");

                entity.Property(e => e.LoeFlagPerfil)
                    .HasColumnName("loe_flag_perfil")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.LoeIdMuestra).HasColumnName("loe_id_muestra");

                entity.Property(e => e.LoeIdServicio).HasColumnName("loe_id_servicio");

                entity.Property(e => e.LoeIdSucursalEscaneo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("loe_id_sucursal_escaneo")
                    .IsFixedLength();

                entity.Property(e => e.LoeTicketAnio)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("loe_ticket_anio")
                    .IsFixedLength();

                entity.Property(e => e.LoeTicketIdCabecera).HasColumnName("loe_ticket_id_cabecera");

                entity.Property(e => e.LoeTicketIdSucursal)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("loe_ticket_id_sucursal")
                    .IsFixedLength();

                entity.Property(e => e.LoeTicketPeriodo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("loe_ticket_periodo")
                    .IsFixedLength();

                entity.Property(e => e.LoeUsuarioAnulacion)
                    .HasColumnType("character varying")
                    .HasColumnName("loe_usuario_anulacion");

                entity.Property(e => e.LoeUsuarioDesescaneo)
                    .HasColumnType("character varying")
                    .HasColumnName("loe_usuario_desescaneo");

                entity.Property(e => e.LoeUsuarioEscaneo)
                    .HasColumnType("character varying")
                    .HasColumnName("loe_usuario_escaneo");

                entity.HasOne(d => d.LoeIdSucursalEscaneoNavigation)
                    .WithMany(p => p.MstLabOrdenEscaneos)
                    .HasForeignKey(d => d.LoeIdSucursalEscaneo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lab_orden_escaneo_sucursal_fk");

                entity.HasOne(d => d.LoeTicket)
                    .WithMany(p => p.MstLabOrdenEscaneos)
                    .HasForeignKey(d => new { d.LoeTicketIdCabecera, d.LoeTicketPeriodo, d.LoeTicketAnio, d.LoeTicketIdSucursal })
                    .HasConstraintName("lab_orden_escaneo_orden_cab_fk");
            });

            modelBuilder.Entity<MstLabOrdenImpresion>(entity =>
            {
                entity.HasKey(e => e.LoiId)
                    .HasName("MST_LAB_ORDEN_IMPRESION_pkey");

                entity.ToTable("MST_LAB_ORDEN_IMPRESION", "suizasoft");

                entity.HasIndex(e => new { e.LoiTicketIdCabecera, e.LoiTicketPeriodo, e.LoiTicketAnio, e.LoiTicketIdSucursal }, "IX_MST_LAB_ORDEN_IMPRESION_loi_ticket_id_cabecera_loi_ticket_p~");

                entity.Property(e => e.LoiId).HasColumnName("loi_id");

                entity.Property(e => e.LoiEstado).HasColumnName("loi_estado");

                entity.Property(e => e.LoiFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("loi_fecha_creacion");

                entity.Property(e => e.LoiFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("loi_fecha_modificacion");

                entity.Property(e => e.LoiTicketAnio)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("loi_ticket_anio")
                    .IsFixedLength();

                entity.Property(e => e.LoiTicketIdCabecera).HasColumnName("loi_ticket_id_cabecera");

                entity.Property(e => e.LoiTicketIdSucursal)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("loi_ticket_id_sucursal")
                    .IsFixedLength();

                entity.Property(e => e.LoiTicketPeriodo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("loi_ticket_periodo")
                    .IsFixedLength();

                entity.Property(e => e.LoiUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("loi_usuario_creacion");

                entity.Property(e => e.LoiUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("loi_usuario_modificacion");

                entity.HasOne(d => d.LoiTicket)
                    .WithMany(p => p.MstLabOrdenImpresions)
                    .HasForeignKey(d => new { d.LoiTicketIdCabecera, d.LoiTicketPeriodo, d.LoiTicketAnio, d.LoiTicketIdSucursal })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lab_orden_escaneo_orden_cab_fk");
            });

            modelBuilder.Entity<MstLabOrdenMuestraPerfil>(entity =>
            {
                entity.HasKey(e => new { e.OmpYearorden, e.OmpMueCodigo, e.OmpIdPerfil })
                    .HasName("MST_LAB_ORDEN_MUESTRA_PERFIL_pkey");

                entity.ToTable("MST_LAB_ORDEN_MUESTRA_PERFIL", "suizasoft");

                entity.Property(e => e.OmpYearorden)
                    .HasColumnType("character varying")
                    .HasColumnName("omp_yearorden");

                entity.Property(e => e.OmpMueCodigo).HasColumnName("omp_mue_codigo");

                entity.Property(e => e.OmpIdPerfil).HasColumnName("omp_id_perfil");

                entity.Property(e => e.OmpEstado).HasColumnName("omp_estado");

                entity.Property(e => e.OmpFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("omp_fecha_registro");

                entity.Property(e => e.OmpFlagEscaneo)
                    .HasColumnName("omp_flag_escaneo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OmpFlagPerfil)
                    .HasColumnName("omp_flag_perfil")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OmpOrdenNumero)
                    .HasColumnType("character varying")
                    .HasColumnName("omp_orden_numero");

                entity.Property(e => e.OmpUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("omp_usuario_registro");
            });

            modelBuilder.Entity<MstLabOrdenMuestraServicio>(entity =>
            {
                entity.HasKey(e => new { e.OmsYearorden, e.OmsMueCodigo, e.OmsIdServicio, e.OmsFlagPerfil })
                    .HasName("MST_LAB_ORDEN_MUESTRA_SERVICIO_pkey");

                entity.ToTable("MST_LAB_ORDEN_MUESTRA_SERVICIO", "suizasoft");

                entity.Property(e => e.OmsYearorden)
                    .HasColumnType("character varying")
                    .HasColumnName("oms_yearorden");

                entity.Property(e => e.OmsMueCodigo).HasColumnName("oms_mue_codigo");

                entity.Property(e => e.OmsIdServicio).HasColumnName("oms_id_servicio");

                entity.Property(e => e.OmsFlagPerfil).HasColumnName("oms_flag_perfil");

                entity.Property(e => e.OmsEscaneoDetalle)
                    .HasColumnType("jsonb")
                    .HasColumnName("oms_escaneo_detalle");

                entity.Property(e => e.OmsEstado).HasColumnName("oms_estado");

                entity.Property(e => e.OmsFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("oms_fecha_registro");

                entity.Property(e => e.OmsFlagEscaneo)
                    .HasColumnName("oms_flag_escaneo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OmsOrdenNumero)
                    .HasColumnType("character varying")
                    .HasColumnName("oms_orden_numero");

                entity.Property(e => e.OmsUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("oms_usuario_registro");
            });

            modelBuilder.Entity<MstLabOrdenResultado>(entity =>
            {
                entity.HasKey(e => new { e.LorYearorden, e.LorOrdenNumero, e.LorIdExaCodigo, e.LorIdServicioPerfil })
                    .HasName("MST_LAB_ORDEN_RESULTADO_pkey");

                entity.ToTable("MST_LAB_ORDEN_RESULTADO", "suizasoft");

                entity.Property(e => e.LorYearorden)
                    .HasMaxLength(20)
                    .HasColumnName("lor_yearorden");

                entity.Property(e => e.LorOrdenNumero)
                    .HasMaxLength(15)
                    .HasColumnName("lor_orden_numero");

                entity.Property(e => e.LorIdExaCodigo).HasColumnName("lor_id_exa_codigo");

                entity.Property(e => e.LorIdServicioPerfil).HasColumnName("lor_id_servicio_perfil");

                entity.Property(e => e.LorAntibiograma).HasColumnName("lor_antibiograma");

                entity.Property(e => e.LorCantDecimal)
                    .HasMaxLength(10)
                    .HasColumnName("lor_cant_decimal");

                entity.Property(e => e.LorComentarioFijo)
                    .HasMaxLength(1500)
                    .HasColumnName("lor_comentario_fijo");

                entity.Property(e => e.LorComentarioFijoIngles)
                    .HasColumnType("character varying")
                    .HasColumnName("lor_comentario_fijo_ingles");

                entity.Property(e => e.LorCt1)
                    .HasMaxLength(150)
                    .HasColumnName("lor_ct1");

                entity.Property(e => e.LorCt2)
                    .HasMaxLength(150)
                    .HasColumnName("lor_ct2");

                entity.Property(e => e.LorEquipoCodigo).HasColumnName("lor_equipo_codigo");

                entity.Property(e => e.LorEquipoDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("lor_equipo_descripcion");

                entity.Property(e => e.LorEstado).HasColumnName("lor_estado");

                entity.Property(e => e.LorExaNombre)
                    .HasMaxLength(100)
                    .HasColumnName("lor_exa_nombre");

                entity.Property(e => e.LorExaNombreIngles)
                    .HasColumnType("character varying")
                    .HasColumnName("lor_exa_nombre_ingles");

                entity.Property(e => e.LorFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lor_fecha_modificacion");

                entity.Property(e => e.LorFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lor_fecha_registro");

                entity.Property(e => e.LorFechaValidacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lor_fecha_validacion");

                entity.Property(e => e.LorFlagAntibiograma).HasColumnName("lor_flag_antibiograma");

                entity.Property(e => e.LorFlagCerrado).HasColumnName("lor_flag_cerrado");

                entity.Property(e => e.LorFlagConfidencial).HasColumnName("lor_flag_confidencial");

                entity.Property(e => e.LorFlagDesvalidacion).HasColumnName("lor_flag_desvalidacion");

                entity.Property(e => e.LorFlagFueraRango).HasColumnName("lor_flag_fuera_rango");

                entity.Property(e => e.LorFlagImpreso).HasColumnName("lor_flag_impreso");

                entity.Property(e => e.LorFlagPerfil).HasColumnName("lor_flag_perfil");

                entity.Property(e => e.LorFlagReporte).HasColumnName("lor_flag_reporte");

                entity.Property(e => e.LorIdTexto).HasColumnName("lor_id_texto");

                entity.Property(e => e.LorItem).HasColumnName("lor_item");

                entity.Property(e => e.LorLisCodigo).HasColumnName("lor_lis_codigo");

                entity.Property(e => e.LorMetodoCodigo).HasColumnName("lor_metodo_codigo");

                entity.Property(e => e.LorMetodoDescriptivo)
                    .HasMaxLength(100)
                    .HasColumnName("lor_metodo_descriptivo");

                entity.Property(e => e.LorMuestraCodigo).HasColumnName("lor_muestra_codigo");

                entity.Property(e => e.LorNombrePerfil)
                    .HasMaxLength(100)
                    .HasColumnName("lor_nombre_perfil")
                    .IsFixedLength();

                entity.Property(e => e.LorReferenciaMax)
                    .HasPrecision(8, 4)
                    .HasColumnName("lor_referencia_max");

                entity.Property(e => e.LorReferenciaMin)
                    .HasPrecision(8, 4)
                    .HasColumnName("lor_referencia_min");

                entity.Property(e => e.LorResultComentario)
                    .HasMaxLength(1500)
                    .HasColumnName("lor_result_comentario");

                entity.Property(e => e.LorResultTipoDato)
                    .HasMaxLength(1)
                    .HasColumnName("lor_result_tipo_dato")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.LorResultado)
                    .HasMaxLength(150)
                    .HasColumnName("lor_resultado");

                entity.Property(e => e.LorResultadoOrigen)
                    .HasMaxLength(150)
                    .HasColumnName("lor_resultado_origen");

                entity.Property(e => e.LorRutaAws)
                    .HasMaxLength(200)
                    .HasColumnName("lor_ruta_aws");

                entity.Property(e => e.LorSeccionCodigo).HasColumnName("lor_seccion_codigo");

                entity.Property(e => e.LorSeccionDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("lor_seccion_descripcion");

                entity.Property(e => e.LorSubTituloLaboratorio)
                    .HasColumnType("character varying")
                    .HasColumnName("lor_sub_titulo_laboratorio");

                entity.Property(e => e.LorSubtitulo)
                    .HasMaxLength(100)
                    .HasColumnName("lor_subtitulo");

                entity.Property(e => e.LorUnidadNombre)
                    .HasMaxLength(20)
                    .HasColumnName("lor_unidad_nombre");

                entity.Property(e => e.LorUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("lor_usuario_modificacion");

                entity.Property(e => e.LorUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("lor_usuario_registro");

                entity.Property(e => e.LorUsuarioValidacion)
                    .HasMaxLength(30)
                    .HasColumnName("lor_usuario_validacion");

                entity.Property(e => e.LorValorReferencial)
                    .HasMaxLength(300)
                    .HasColumnName("lor_valor_referencial");
            });

            modelBuilder.Entity<MstLabOrdenResultadoHistorial>(entity =>
            {
                entity.HasKey(e => new { e.LohYearorden, e.LohIdServicio, e.LohIdExaCodigo, e.LohFechaDesvalidacion })
                    .HasName("MST_LAB_ORDEN_RESULTADO_HIS_pkey");

                entity.ToTable("MST_LAB_ORDEN_RESULTADO_HISTORIAL", "suizasoft");

                entity.Property(e => e.LohYearorden)
                    .HasMaxLength(20)
                    .HasColumnName("loh_yearorden");

                entity.Property(e => e.LohIdServicio).HasColumnName("loh_id_servicio");

                entity.Property(e => e.LohIdExaCodigo).HasColumnName("loh_id_exa_codigo");

                entity.Property(e => e.LohFechaDesvalidacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("loh_fecha_desvalidacion");

                entity.Property(e => e.LohCantDecimal)
                    .HasMaxLength(10)
                    .HasColumnName("loh_cant_decimal");

                entity.Property(e => e.LohChaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("loh_cha_registro");

                entity.Property(e => e.LohComentarioFijo)
                    .HasMaxLength(1500)
                    .HasColumnName("loh_comentario_fijo");

                entity.Property(e => e.LohCt1)
                    .HasMaxLength(150)
                    .HasColumnName("loh_ct1");

                entity.Property(e => e.LohCt2)
                    .HasMaxLength(150)
                    .HasColumnName("loh_ct2");

                entity.Property(e => e.LohEquipoCodigo).HasColumnName("loh_equipo_codigo");

                entity.Property(e => e.LohEquipoDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("loh_equipo_descripcion");

                entity.Property(e => e.LohEstado).HasColumnName("loh_estado");

                entity.Property(e => e.LohEsultTipoDato)
                    .HasMaxLength(1)
                    .HasColumnName("loh_esult_tipo_dato")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.LohExaNombre)
                    .HasMaxLength(100)
                    .HasColumnName("loh_exa_nombre");

                entity.Property(e => e.LohFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("loh_fecha_modificacion");

                entity.Property(e => e.LohFechaValidacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("loh_fecha_validacion");

                entity.Property(e => e.LohFlagAntibiograma).HasColumnName("loh_flag_antibiograma");

                entity.Property(e => e.LohFlagCerrado).HasColumnName("loh_flag_cerrado");

                entity.Property(e => e.LohFlagConfidencial).HasColumnName("loh_flag_confidencial");

                entity.Property(e => e.LohFlagDesvalidacion)
                    .HasColumnType("character varying")
                    .HasColumnName("loh_flag_desvalidacion");

                entity.Property(e => e.LohFlagFueraRango).HasColumnName("loh_flag_fuera_rango");

                entity.Property(e => e.LohFlagImpreso).HasColumnName("loh_flag_impreso");

                entity.Property(e => e.LohFlagReporte).HasColumnName("loh_flag_reporte");

                entity.Property(e => e.LohIdTexto).HasColumnName("loh_id_texto");

                entity.Property(e => e.LohLagPerfil).HasColumnName("loh_lag_perfil");

                entity.Property(e => e.LohLisCodigo).HasColumnName("loh_lis_codigo");

                entity.Property(e => e.LohMetodoCodigo).HasColumnName("loh_metodo_codigo");

                entity.Property(e => e.LohMetodoDescriptivo)
                    .HasMaxLength(100)
                    .HasColumnName("loh_metodo_descriptivo");

                entity.Property(e => e.LohMuestraCodigo).HasColumnName("loh_muestra_codigo");

                entity.Property(e => e.LohNombrePerfil)
                    .HasMaxLength(100)
                    .HasColumnName("loh_nombre_perfil")
                    .IsFixedLength();

                entity.Property(e => e.LohReferenciaMax)
                    .HasPrecision(8, 4)
                    .HasColumnName("loh_referencia_max");

                entity.Property(e => e.LohReferenciaMin)
                    .HasPrecision(8, 4)
                    .HasColumnName("loh_referencia_min");

                entity.Property(e => e.LohResultComentario)
                    .HasMaxLength(1500)
                    .HasColumnName("loh_result_comentario");

                entity.Property(e => e.LohResultado)
                    .HasMaxLength(150)
                    .HasColumnName("loh_resultado");

                entity.Property(e => e.LohResultadoOrigen)
                    .HasMaxLength(150)
                    .HasColumnName("loh_resultado_origen");

                entity.Property(e => e.LohRutaAws)
                    .HasMaxLength(200)
                    .HasColumnName("loh_ruta_aws");

                entity.Property(e => e.LohSeccionCodigo).HasColumnName("loh_seccion_codigo");

                entity.Property(e => e.LohSeccionDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("loh_seccion_descripcion");

                entity.Property(e => e.LohSubtitulo)
                    .HasMaxLength(100)
                    .HasColumnName("loh_subtitulo");

                entity.Property(e => e.LohUnidadNombre)
                    .HasMaxLength(20)
                    .HasColumnName("loh_unidad_nombre");

                entity.Property(e => e.LohUsuarioDesvalidacion)
                    .HasMaxLength(30)
                    .HasColumnName("loh_usuario_desvalidacion");

                entity.Property(e => e.LohUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("loh_usuario_modificacion");

                entity.Property(e => e.LohUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("loh_usuario_registro");

                entity.Property(e => e.LohUsuarioValidacion)
                    .HasMaxLength(30)
                    .HasColumnName("loh_usuario_validacion");

                entity.Property(e => e.LohValorReferencial)
                    .HasMaxLength(300)
                    .HasColumnName("loh_valor_referencial");
            });

            modelBuilder.Entity<MstLabPerfil>(entity =>
            {
                entity.HasKey(e => e.PerId)
                    .HasName("MST_LAB_PERFIL_pkey");

                entity.ToTable("MST_LAB_PERFIL", "suizasoft");

                entity.HasIndex(e => e.PerAreaNegocio, "IX_MST_LAB_PERFIL_per_area_negocio");

                entity.HasIndex(e => e.PerCentroCostoNegocio, "IX_MST_LAB_PERFIL_per_centro_costo_negocio");

                entity.HasIndex(e => e.PerLineaNegocio, "IX_MST_LAB_PERFIL_per_linea_negocio");

                entity.HasIndex(e => e.PerUnidadNegocio, "IX_MST_LAB_PERFIL_per_unidad_negocio");

                entity.Property(e => e.PerId).HasColumnName("per_id");

                entity.Property(e => e.PerAreaNegocio).HasColumnName("per_area_negocio");

                entity.Property(e => e.PerBiopsia).HasColumnName("per_biopsia");

                entity.Property(e => e.PerCentroCostoNegocio).HasColumnName("per_centro_costo_negocio");

                entity.Property(e => e.PerCodigoAlfanumerico)
                    .HasMaxLength(8)
                    .HasColumnName("per_codigo_alfanumerico");

                entity.Property(e => e.PerCondicionesPreanaliticas)
                    .HasColumnType("character varying")
                    .HasColumnName("per_condiciones_preanaliticas");

                entity.Property(e => e.PerCondicionesPreanaliticasRef)
                    .HasColumnType("character varying")
                    .HasColumnName("per_condiciones_preanaliticas_ref");

                entity.Property(e => e.PerConfidencial).HasColumnName("per_confidencial");

                entity.Property(e => e.PerDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("per_descripcion");

                entity.Property(e => e.PerDescripcionEspanol)
                    .HasColumnType("character varying")
                    .HasColumnName("per_descripcion_espanol");

                entity.Property(e => e.PerEquipo).HasColumnName("per_equipo");

                entity.Property(e => e.PerEstado)
                    .HasColumnName("per_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PerFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("per_fecha_modificacion");

                entity.Property(e => e.PerFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("per_fecha_registro");

                entity.Property(e => e.PerFlagTiempo)
                    .HasMaxLength(1)
                    .HasColumnName("per_flag_tiempo");

                entity.Property(e => e.PerFox)
                    .HasColumnType("character varying")
                    .HasColumnName("per_fox");

                entity.Property(e => e.PerIdTiempoProceso).HasColumnName("per_id_tiempo_proceso");

                entity.Property(e => e.PerLineaNegocio).HasColumnName("per_linea_negocio");

                entity.Property(e => e.PerMetodo).HasColumnName("per_metodo");

                entity.Property(e => e.PerNumSerAnterior)
                    .HasColumnType("character varying")
                    .HasColumnName("per_num_ser_anterior");

                entity.Property(e => e.PerObsevacion)
                    .HasColumnType("character varying")
                    .HasColumnName("per_obsevacion");

                entity.Property(e => e.PerProcesamiento).HasColumnName("per_procesamiento");

                entity.Property(e => e.PerSuizaParnert).HasColumnName("per_suiza_parnert");

                entity.Property(e => e.PerTempOptimaEnvio).HasColumnName("per_temp_optima_envio");

                entity.Property(e => e.PerTipoTubo).HasColumnName("per_tipo_tubo");

                entity.Property(e => e.PerUnidadNegocio).HasColumnName("per_unidad_negocio");

                entity.Property(e => e.PerUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("per_usuario_modificacion");

                entity.Property(e => e.PerUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("per_usuario_registro");

                entity.HasOne(d => d.PerAreaNegocioNavigation)
                    .WithMany(p => p.MstLabPerfils)
                    .HasForeignKey(d => d.PerAreaNegocio)
                    .HasConstraintName("MST_PERFIL_MST_AREA_NEGOCIO_idarea_fkey");

                entity.HasOne(d => d.PerCentroCostoNegocioNavigation)
                    .WithMany(p => p.MstLabPerfils)
                    .HasForeignKey(d => d.PerCentroCostoNegocio)
                    .HasConstraintName("perfil_centro_costo_negocio_fk");

                entity.HasOne(d => d.PerEquipoNavigation)
                    .WithMany(p => p.MstLabPerfils)
                    .HasForeignKey(d => d.PerEquipo)
                    .HasConstraintName("perfil_equipo_fk");

                entity.HasOne(d => d.PerLineaNegocioNavigation)
                    .WithMany(p => p.MstLabPerfils)
                    .HasForeignKey(d => d.PerLineaNegocio)
                    .HasConstraintName("perfil_linea_negocio_fk");

                entity.HasOne(d => d.PerMetodoNavigation)
                    .WithMany(p => p.MstLabPerfils)
                    .HasForeignKey(d => d.PerMetodo)
                    .HasConstraintName("perfil_metodo_fk");

                entity.HasOne(d => d.PerProcesamientoNavigation)
                    .WithMany(p => p.MstLabPerfils)
                    .HasForeignKey(d => d.PerProcesamiento)
                    .HasConstraintName("perfil_procesamiento_fk");

                entity.HasOne(d => d.PerTempOptimaEnvioNavigation)
                    .WithMany(p => p.MstLabPerfils)
                    .HasForeignKey(d => d.PerTempOptimaEnvio)
                    .HasConstraintName("perfil_temperatura_fk");

                entity.HasOne(d => d.PerTipoTuboNavigation)
                    .WithMany(p => p.MstLabPerfils)
                    .HasForeignKey(d => d.PerTipoTubo)
                    .HasConstraintName("perfil_ttubo_fk");

                entity.HasOne(d => d.PerUnidadNegocioNavigation)
                    .WithMany(p => p.MstLabPerfils)
                    .HasForeignKey(d => d.PerUnidadNegocio)
                    .HasConstraintName("perfil_unidad_negocio_fk");
            });

            modelBuilder.Entity<MstLabPerfilServicio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MST_LAB_PERFIL_SERVICIO", "suizasoft");

                entity.HasIndex(e => e.PesIdPerfil, "IX_MST_LAB_PERFIL_SERVICIO_pes_id_perfil");

                entity.HasIndex(e => e.PesIdServicio, "IX_MST_LAB_PERFIL_SERVICIO_pes_id_servicio");

                entity.HasIndex(e => e.PesLisId, "IX_MST_LAB_PERFIL_SERVICIO_pes_lis_id");

                entity.Property(e => e.PesEstado).HasColumnName("pes_estado");

                entity.Property(e => e.PesExaCodigoAnterior)
                    .HasColumnType("character varying")
                    .HasColumnName("pes_exa_codigo_anterior");

                entity.Property(e => e.PesFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pes_fecha_modificacion");

                entity.Property(e => e.PesFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pes_fecha_registro");

                entity.Property(e => e.PesFlagPerfil)
                    .HasColumnName("pes_flag_perfil")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.PesIdPerfil).HasColumnName("pes_id_perfil");

                entity.Property(e => e.PesIdServicio).HasColumnName("pes_id_servicio");

                entity.Property(e => e.PesIndex).HasColumnName("pes_index");

                entity.Property(e => e.PesLisId).HasColumnName("pes_lis_id");

                entity.Property(e => e.PesUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("pes_usuario_modificacion");

                entity.Property(e => e.PesUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("pes_usuario_registro");

                entity.HasOne(d => d.PesIdPerfilNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.PesIdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_PERFIL_SERVICIO_servicio_id_fkey");

                entity.HasOne(d => d.PesIdServicioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.PesIdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_PERFIL_SERVICIO_servicio_id_perfil_fkey");

                entity.HasOne(d => d.PesLis)
                    .WithMany()
                    .HasForeignKey(d => d.PesLisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_PERFIL_SERVICIO_lis_id_fkey");
            });

            modelBuilder.Entity<MstLabServicioValoresRef>(entity =>
            {
                entity.HasKey(e => e.SevId)
                    .HasName("MST_LAB_SERVICIO_VALORES_REF_pkey");

                entity.ToTable("MST_LAB_SERVICIO_VALORES_REF", "suizasoft");

                entity.Property(e => e.SevId).HasColumnName("sev_id");

                entity.Property(e => e.SevEstado).HasColumnName("sev_estado");

                entity.Property(e => e.SevFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("sev_fecha_creacion");

                entity.Property(e => e.SevFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("sev_fecha_modificacion");

                entity.Property(e => e.SevIdFisiologico).HasColumnName("sev_id_fisiologico");

                entity.Property(e => e.SevIdGrupoEtnico).HasColumnName("sev_id_grupo_etnico");

                entity.Property(e => e.SevIdServicio).HasColumnName("sev_id_servicio");

                entity.Property(e => e.SevLiteral)
                    .HasColumnType("character varying")
                    .HasColumnName("sev_literal");

                entity.Property(e => e.SevMetodo)
                    .HasColumnType("character varying")
                    .HasColumnName("sev_metodo");

                entity.Property(e => e.SevNormalInferior)
                    .HasPrecision(7, 3)
                    .HasColumnName("sev_normal_inferior");

                entity.Property(e => e.SevNormalSuperior)
                    .HasPrecision(7, 3)
                    .HasColumnName("sev_normal_superior");

                entity.Property(e => e.SevPeriodoFinal).HasColumnName("sev_periodo_final");

                entity.Property(e => e.SevPeriodoInicial).HasColumnName("sev_periodo_inicial");

                entity.Property(e => e.SevUnidadEdadMaxima).HasColumnName("sev_unidad_edad_maxima");

                entity.Property(e => e.SevUnidadEdadMinima).HasColumnName("sev_unidad_edad_minima");

                entity.Property(e => e.SevUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("sev_usuario_creacion");

                entity.Property(e => e.SevUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("sev_usuario_modificacion");

                entity.HasOne(d => d.SevIdFisiologicoNavigation)
                    .WithMany(p => p.MstLabServicioValoresRefs)
                    .HasForeignKey(d => d.SevIdFisiologico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_LAB_SERVICIO_VALORES_REF_sev_id_fisiologico_fkey");

                entity.HasOne(d => d.SevIdGrupoEtnicoNavigation)
                    .WithMany(p => p.MstLabServicioValoresRefs)
                    .HasForeignKey(d => d.SevIdGrupoEtnico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_LAB_SERVICIO_VALORES_REF_sev_id_grupo_etnico_fkey");

                entity.HasOne(d => d.SevIdServicioNavigation)
                    .WithMany(p => p.MstLabServicioValoresRefs)
                    .HasForeignKey(d => d.SevIdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_LAB_SERVICIO_VALORES_REF_sev_id_servicio_fkey");

                entity.HasOne(d => d.SevUnidadEdadMaximaNavigation)
                    .WithMany(p => p.MstLabServicioValoresRefSevUnidadEdadMaximaNavigations)
                    .HasForeignKey(d => d.SevUnidadEdadMaxima)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_LAB_SERVICIO_VALORES_REF_sev_unidad_edad_maxima_fkey");

                entity.HasOne(d => d.SevUnidadEdadMinimaNavigation)
                    .WithMany(p => p.MstLabServicioValoresRefSevUnidadEdadMinimaNavigations)
                    .HasForeignKey(d => d.SevUnidadEdadMinima)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_LAB_SERVICIO_VALORES_REF_sev_unidad_edad_minima_fkey");
            });

            modelBuilder.Entity<MstLabUnidadEdad>(entity =>
            {
                entity.HasKey(e => e.UneId)
                    .HasName("MST_LAB_UNIDAD_EDAD_pkey");

                entity.ToTable("MST_LAB_UNIDAD_EDAD", "suizasoft");

                entity.Property(e => e.UneId)
                    .ValueGeneratedNever()
                    .HasColumnName("une_id");

                entity.Property(e => e.UneEstado).HasColumnName("une_estado");

                entity.Property(e => e.UneNombre).HasColumnName("une_nombre");
            });

            modelBuilder.Entity<MstLabUnidadServicio>(entity =>
            {
                entity.HasKey(e => e.UnsId)
                    .HasName("MST_LAB_UNIDAD_SERVICIO_pkey");

                entity.ToTable("MST_LAB_UNIDAD_SERVICIO", "suizasoft");

                entity.Property(e => e.UnsId)
                    .ValueGeneratedNever()
                    .HasColumnName("uns_id");

                entity.Property(e => e.UnsEstado).HasColumnName("uns_estado");

                entity.Property(e => e.UnsNombre).HasColumnName("uns_nombre");
            });

            modelBuilder.Entity<MstLisProveedor>(entity =>
            {
                entity.HasKey(e => e.LisId)
                    .HasName("MST_LIS_PROVEEDOR_pkey");

                entity.ToTable("MST_LIS_PROVEEDOR", "suizasoft");

                entity.Property(e => e.LisId)
                    .ValueGeneratedNever()
                    .HasColumnName("lis_id");

                entity.Property(e => e.LisEstado).HasColumnName("lis_estado");

                entity.Property(e => e.LisFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lis_fecha_modificacion");

                entity.Property(e => e.LisFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lis_fecha_registro");

                entity.Property(e => e.LisNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("lis_nombre");

                entity.Property(e => e.LisUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("lis_usuario_modificacion");

                entity.Property(e => e.LisUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("lis_usuario_registro");
            });

            modelBuilder.Entity<MstLoteCompanium>(entity =>
            {
                entity.HasKey(e => e.LteId)
                    .HasName("MST_LOTE_COMPANIA_pkey");

                entity.ToTable("MST_LOTE_COMPANIA", "suizasoft");

                entity.Property(e => e.LteId).HasColumnName("lte_id");

                entity.Property(e => e.LteFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lte_fecha_creacion");

                entity.Property(e => e.LteFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lte_fecha_modificacion");

                entity.Property(e => e.LteFechaProceso)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lte_fecha_proceso");

                entity.Property(e => e.LteIdCompania).HasColumnName("lte_id_compania");

                entity.Property(e => e.LteNro)
                    .HasMaxLength(10)
                    .HasColumnName("lte_nro");

                entity.Property(e => e.LteUsuarioCreador)
                    .HasMaxLength(20)
                    .HasColumnName("lte_usuario_creador");

                entity.Property(e => e.LteUsuarioModificador)
                    .HasMaxLength(20)
                    .HasColumnName("lte_usuario_modificador");
            });

            modelBuilder.Entity<MstMedico>(entity =>
            {
                entity.HasKey(e => e.MedId)
                    .HasName("MST_MEDICO_pkey");

                entity.ToTable("MST_MEDICO", "suizasoft");

                entity.HasIndex(e => e.MedIdColegioTipo, "IX_MST_MEDICO_med_id_colegio_tipo");

                entity.HasIndex(e => e.MedIdPromotor, "IX_MST_MEDICO_med_id_promotor");

                entity.HasIndex(e => e.MedIdSexo, "IX_MST_MEDICO_med_id_sexo");

                entity.HasIndex(e => e.MedIdTipo, "IX_MST_MEDICO_med_id_tipo");

                entity.HasIndex(e => e.MedIdTipoDocumento, "IX_MST_MEDICO_med_id_tipo_documento");

                entity.HasIndex(e => e.MedIdUbigeo, "IX_MST_MEDICO_med_id_ubigeo");

                entity.HasIndex(e => e.MedIdUbigeoConsultorio, "IX_MST_MEDICO_med_id_ubigeo_consultorio");

                entity.Property(e => e.MedId).HasColumnName("med_id");

                entity.Property(e => e.MedAccesoWeb).HasColumnName("med_acceso_web");

                entity.Property(e => e.MedApellidoMaterno)
                    .HasColumnType("character varying")
                    .HasColumnName("med_apellido_materno");

                entity.Property(e => e.MedApellidoPaterno)
                    .HasColumnType("character varying")
                    .HasColumnName("med_apellido_paterno");

                entity.Property(e => e.MedColegioCodigo)
                    .HasColumnType("character varying")
                    .HasColumnName("med_colegio_codigo");

                entity.Property(e => e.MedConsultorioDireccion)
                    .HasColumnType("character varying")
                    .HasColumnName("med_consultorio_direccion");

                entity.Property(e => e.MedConsultorioReferencia)
                    .HasColumnType("character varying")
                    .HasColumnName("med_consultorio_referencia");

                entity.Property(e => e.MedCorreo)
                    .HasColumnType("character varying")
                    .HasColumnName("med_correo");

                entity.Property(e => e.MedDireccion)
                    .HasColumnType("character varying")
                    .HasColumnName("med_direccion");

                entity.Property(e => e.MedDireccionReferencia)
                    .HasColumnType("character varying")
                    .HasColumnName("med_direccion_referencia");

                entity.Property(e => e.MedDoctoralia)
                    .HasColumnType("character varying")
                    .HasColumnName("med_doctoralia");

                entity.Property(e => e.MedEstado).HasColumnName("med_estado");

                entity.Property(e => e.MedFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("med_fecha_creacion");

                entity.Property(e => e.MedFechaInscripcion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("med_fecha_inscripcion");

                entity.Property(e => e.MedFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("med_fecha_modificacion");

                entity.Property(e => e.MedFechaNacimiento).HasColumnName("med_fecha_nacimiento");

                entity.Property(e => e.MedIdColegioTipo).HasColumnName("med_id_colegio_tipo");

                entity.Property(e => e.MedIdPromotor).HasColumnName("med_id_promotor");

                entity.Property(e => e.MedIdSexo).HasColumnName("med_id_sexo");

                entity.Property(e => e.MedIdTipo).HasColumnName("med_id_tipo");

                entity.Property(e => e.MedIdTipoDocumento).HasColumnName("med_id_tipo_documento");

                entity.Property(e => e.MedIdUbigeo).HasColumnName("med_id_ubigeo");

                entity.Property(e => e.MedIdUbigeoConsultorio).HasColumnName("med_id_ubigeo_consultorio");

                entity.Property(e => e.MedImageRuta)
                    .HasColumnType("character varying")
                    .HasColumnName("med_image_ruta");

                entity.Property(e => e.MedLinkedin)
                    .HasColumnType("character varying")
                    .HasColumnName("med_linkedin");

                entity.Property(e => e.MedNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("med_nombre");

                entity.Property(e => e.MedNombreCompleto)
                    .HasColumnType("character varying")
                    .HasColumnName("med_nombre_completo");

                entity.Property(e => e.MedNumeroDocumento)
                    .HasColumnType("character varying")
                    .HasColumnName("med_numero_documento");

                entity.Property(e => e.MedPasswordWeb)
                    .HasColumnType("character varying")
                    .HasColumnName("med_password_web");

                entity.Property(e => e.MedRna)
                    .HasColumnType("character varying")
                    .HasColumnName("med_rna");

                entity.Property(e => e.MedRne)
                    .HasColumnType("character varying")
                    .HasColumnName("med_rne");

                entity.Property(e => e.MedTelefonoCasa)
                    .HasColumnType("character varying")
                    .HasColumnName("med_telefono_casa");

                entity.Property(e => e.MedTelefonoMovil)
                    .HasColumnType("character varying")
                    .HasColumnName("med_telefono_movil");

                entity.Property(e => e.MedTwitter)
                    .HasColumnType("character varying")
                    .HasColumnName("med_twitter");

                entity.Property(e => e.MedUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("med_usuario_creacion");

                entity.Property(e => e.MedUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("med_usuario_modificacion");

                entity.Property(e => e.MedUsuarioWeb)
                    .HasColumnType("character varying")
                    .HasColumnName("med_usuario_web");

                entity.HasOne(d => d.MedIdColegioTipoNavigation)
                    .WithMany(p => p.MstMedicos)
                    .HasForeignKey(d => d.MedIdColegioTipo)
                    .HasConstraintName("MST_MEDICO_med_id_colegio_tipo_fkey");

                entity.HasOne(d => d.MedIdPromotorNavigation)
                    .WithMany(p => p.MstMedicos)
                    .HasForeignKey(d => d.MedIdPromotor)
                    .HasConstraintName("MST_MEDICO_med_id_promotor_fkey");

                entity.HasOne(d => d.MedIdSexoNavigation)
                    .WithMany(p => p.MstMedicos)
                    .HasForeignKey(d => d.MedIdSexo)
                    .HasConstraintName("MST_MEDICO_med_id_sexo_fkey");

                entity.HasOne(d => d.MedIdTipoNavigation)
                    .WithMany(p => p.MstMedicos)
                    .HasForeignKey(d => d.MedIdTipo)
                    .HasConstraintName("MST_MEDICO_med_id_tipo_fkey");

                entity.HasOne(d => d.MedIdTipoDocumentoNavigation)
                    .WithMany(p => p.MstMedicos)
                    .HasForeignKey(d => d.MedIdTipoDocumento)
                    .HasConstraintName("MST_MEDICO_med_id_tipo_documento_fkey");

                entity.HasOne(d => d.MedIdUbigeoNavigation)
                    .WithMany(p => p.MstMedicoMedIdUbigeoNavigations)
                    .HasForeignKey(d => d.MedIdUbigeo)
                    .HasConstraintName("MST_MEDICO_med_id_ubigeo_fkey");

                entity.HasOne(d => d.MedIdUbigeoConsultorioNavigation)
                    .WithMany(p => p.MstMedicoMedIdUbigeoConsultorioNavigations)
                    .HasForeignKey(d => d.MedIdUbigeoConsultorio)
                    .HasConstraintName("MST_MEDICO_med_id_ubigeo_consultorio_fkey");
            });

            modelBuilder.Entity<MstModalidad>(entity =>
            {
                entity.HasKey(e => e.ModId)
                    .HasName("MST_MODALIDAD_pkey");

                entity.ToTable("MST_MODALIDAD", "suizasoft");

                entity.Property(e => e.ModId).HasColumnName("mod_id");

                entity.Property(e => e.ModComision).HasColumnName("mod_comision");

                entity.Property(e => e.ModComisionPreventiva).HasColumnName("mod_comision_preventiva");

                entity.Property(e => e.ModDescripcion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("mod_descripcion");

                entity.Property(e => e.ModEstado).HasColumnName("mod_estado");
            });

            modelBuilder.Entity<MstMonedum>(entity =>
            {
                entity.HasKey(e => e.MonId)
                    .HasName("MST_MONEDA1_pkey");

                entity.ToTable("MST_MONEDA", "suizasoft");

                entity.Property(e => e.MonId)
                    .ValueGeneratedNever()
                    .HasColumnName("mon_id");

                entity.Property(e => e.MonAbreviatura)
                    .HasMaxLength(1)
                    .HasColumnName("mon_abreviatura");

                entity.Property(e => e.MonDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("mon_descripcion");
            });

            modelBuilder.Entity<MstNotaCreditoCabecera>(entity =>
            {
                entity.HasKey(e => e.NccId)
                    .HasName("MST_NOTA_CREDITO_CABECERA_pkey");

                entity.ToTable("MST_NOTA_CREDITO_CABECERA", "suizasoft");

                entity.HasIndex(e => e.NccIdComprobante, "IX_MST_NOTA_CREDITO_CABECERA_ncc_id_comprobante");

                entity.HasIndex(e => e.NccIdEstado, "IX_MST_NOTA_CREDITO_CABECERA_ncc_id_estado");

                entity.HasIndex(e => e.NccIdModalidadFac, "IX_MST_NOTA_CREDITO_CABECERA_ncc_id_modalidad_fac");

                entity.HasIndex(e => e.NccIdMoneda, "IX_MST_NOTA_CREDITO_CABECERA_ncc_id_moneda");

                entity.HasIndex(e => e.NccIdTipDocVentaFac, "IX_MST_NOTA_CREDITO_CABECERA_ncc_id_tip_doc_venta_fac");

                entity.HasIndex(e => e.NccIdTipoDocVentaNc, "IX_MST_NOTA_CREDITO_CABECERA_ncc_id_tipo_doc_venta_nc");

                entity.HasIndex(e => e.NccIdTipoDocumentoFac, "IX_MST_NOTA_CREDITO_CABECERA_ncc_id_tipo_documento_fac");

                entity.HasIndex(e => e.NccIdTipoOperacion, "IX_MST_NOTA_CREDITO_CABECERA_ncc_id_tipo_operacion");

                entity.Property(e => e.NccId).HasColumnName("ncc_id");

                entity.Property(e => e.NccAnioNc)
                    .HasMaxLength(2)
                    .HasColumnName("ncc_anio_nc");

                entity.Property(e => e.NccCorrelativoFac).HasColumnName("ncc_correlativo_fac");

                entity.Property(e => e.NccCorrelativoNc).HasColumnName("ncc_correlativo_nc");

                entity.Property(e => e.NccEstadoAnulacionNc).HasColumnName("ncc_estado_anulacion_nc");

                entity.Property(e => e.NccFeFechaEnvio)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ncc_fe_fecha_envio");

                entity.Property(e => e.NccFeFlagEnvio).HasColumnName("ncc_fe_flag_envio");

                entity.Property(e => e.NccFeTipoNota).HasColumnName("ncc_fe_tipo_nota");

                entity.Property(e => e.NccFechaAnulacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ncc_fecha_anulacion");

                entity.Property(e => e.NccFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ncc_fecha_creacion");

                entity.Property(e => e.NccFechaFacturacionFac)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ncc_fecha_facturacion_fac");

                entity.Property(e => e.NccFlagUsado).HasColumnName("ncc_flag_usado");

                entity.Property(e => e.NccIdComprobante).HasColumnName("ncc_id_comprobante");

                entity.Property(e => e.NccIdEstado).HasColumnName("ncc_id_estado");

                entity.Property(e => e.NccIdModalidadFac).HasColumnName("ncc_id_modalidad_fac");

                entity.Property(e => e.NccIdMoneda).HasColumnName("ncc_id_moneda");

                entity.Property(e => e.NccIdTipDocVentaFac).HasColumnName("ncc_id_tip_doc_venta_fac");

                entity.Property(e => e.NccIdTipoDocVentaNc).HasColumnName("ncc_id_tipo_doc_venta_nc");

                entity.Property(e => e.NccIdTipoDocumentoFac).HasColumnName("ncc_id_tipo_documento_fac");

                entity.Property(e => e.NccIdTipoOperacion).HasColumnName("ncc_id_tipo_operacion");

                entity.Property(e => e.NccIgvDol)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncc_igv_dol");

                entity.Property(e => e.NccIgvSol)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncc_igv_sol");

                entity.Property(e => e.NccMontoFac)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncc_monto_fac");

                entity.Property(e => e.NccMotivoAnulacionNc)
                    .HasColumnType("character varying")
                    .HasColumnName("ncc_motivo_anulacion_nc");

                entity.Property(e => e.NccNumeroDocumentoFac)
                    .HasColumnType("character varying")
                    .HasColumnName("ncc_numero_documento_fac");

                entity.Property(e => e.NccObservacionNc)
                    .HasColumnType("character varying")
                    .HasColumnName("ncc_observacion_nc");

                entity.Property(e => e.NccPeriodoNc)
                    .HasMaxLength(2)
                    .HasColumnName("ncc_periodo_nc");

                entity.Property(e => e.NccRazonSocial)
                    .HasColumnType("character varying")
                    .HasColumnName("ncc_razon_social");

                entity.Property(e => e.NccSaldoSobrante)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncc_saldo_sobrante");

                entity.Property(e => e.NccSapEnvio).HasColumnName("ncc_sap_envio");

                entity.Property(e => e.NccSapEnvioFecha)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ncc_sap_envio_fecha");

                entity.Property(e => e.NccSerieFac)
                    .HasColumnType("character varying")
                    .HasColumnName("ncc_serie_fac");

                entity.Property(e => e.NccSerieNc)
                    .HasColumnType("character varying")
                    .HasColumnName("ncc_serie_nc");

                entity.Property(e => e.NccSubtotalDol)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncc_subtotal_dol");

                entity.Property(e => e.NccSubtotalSol)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncc_subtotal_sol");

                entity.Property(e => e.NccSucursalFac)
                    .HasColumnType("character varying")
                    .HasColumnName("ncc_sucursal_fac");

                entity.Property(e => e.NccSucursalNc)
                    .HasColumnType("character varying")
                    .HasColumnName("ncc_sucursal_nc");

                entity.Property(e => e.NccTasaIgv).HasColumnName("ncc_tasa_igv");

                entity.Property(e => e.NccTipoCambio)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncc_tipo_cambio");

                entity.Property(e => e.NccTotalDol)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncc_total_dol");

                entity.Property(e => e.NccTotalLetras)
                    .HasColumnType("character varying")
                    .HasColumnName("ncc_total_letras");

                entity.Property(e => e.NccTotalSol)
                    .HasPrecision(13, 2)
                    .HasColumnName("ncc_total_sol");

                entity.Property(e => e.NccUsuarioAnulacion)
                    .HasMaxLength(13)
                    .HasColumnName("ncc_usuario_anulacion");

                entity.Property(e => e.NccUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ncc_usuario_creacion");

                entity.HasOne(d => d.NccIdComprobanteNavigation)
                    .WithMany(p => p.MstNotaCreditoCabeceras)
                    .HasForeignKey(d => d.NccIdComprobante)
                    .HasConstraintName("MST_NOTA_CREDITO_CABECERA_ncc_id_comprobante_fkey");

                entity.HasOne(d => d.NccIdEstadoNavigation)
                    .WithMany(p => p.MstNotaCreditoCabeceras)
                    .HasForeignKey(d => d.NccIdEstado)
                    .HasConstraintName("MST_NOTA_CREDITO_CABECERA_ncc_id_estado_fkey");

                entity.HasOne(d => d.NccIdModalidadFacNavigation)
                    .WithMany(p => p.MstNotaCreditoCabeceras)
                    .HasForeignKey(d => d.NccIdModalidadFac)
                    .HasConstraintName("MST_NOTA_CREDITO_CABECERA_ncc_id_modalidad_fact_fkey");

                entity.HasOne(d => d.NccIdMonedaNavigation)
                    .WithMany(p => p.MstNotaCreditoCabeceras)
                    .HasForeignKey(d => d.NccIdMoneda)
                    .HasConstraintName("MST_NOTA_CREDITO_CABECERA_ncc_id_moneda_fkey");

                entity.HasOne(d => d.NccIdTipDocVentaFacNavigation)
                    .WithMany(p => p.MstNotaCreditoCabeceraNccIdTipDocVentaFacNavigations)
                    .HasForeignKey(d => d.NccIdTipDocVentaFac)
                    .HasConstraintName("MST_NOTA_CREDITO_CABECERA_ncc_id_fact_tip_doc_venta_fkey");

                entity.HasOne(d => d.NccIdTipoDocVentaNcNavigation)
                    .WithMany(p => p.MstNotaCreditoCabeceraNccIdTipoDocVentaNcNavigations)
                    .HasForeignKey(d => d.NccIdTipoDocVentaNc)
                    .HasConstraintName("MST_NOTA_CREDITO_CABECERA_ncc_id_tipo_doc_venta_fkey");

                entity.HasOne(d => d.NccIdTipoDocumentoFacNavigation)
                    .WithMany(p => p.MstNotaCreditoCabeceras)
                    .HasForeignKey(d => d.NccIdTipoDocumentoFac)
                    .HasConstraintName("MST_NOTA_CREDITO_CABECERA_ncc_id_tipo_documento_fac_fkey");

                entity.HasOne(d => d.NccIdTipoOperacionNavigation)
                    .WithMany(p => p.MstNotaCreditoCabeceras)
                    .HasForeignKey(d => d.NccIdTipoOperacion)
                    .HasConstraintName("MST_NOTA_CREDITO_CABECERA_ncc_id_tipo_operacion_fkey");
            });

            modelBuilder.Entity<MstOrdenMedicaDigital>(entity =>
            {
                entity.HasKey(e => new { e.OmdId, e.OmdPeriodo, e.OmdAnio, e.OmdSucId })
                    .HasName("MST_ORDEN_MEDICA_DIGITAL_pkey");

                entity.ToTable("MST_ORDEN_MEDICA_DIGITAL", "suizasoft");

                entity.Property(e => e.OmdId).HasColumnName("omd_id");

                entity.Property(e => e.OmdPeriodo)
                    .HasMaxLength(2)
                    .HasColumnName("omd_periodo")
                    .IsFixedLength();

                entity.Property(e => e.OmdAnio)
                    .HasMaxLength(2)
                    .HasColumnName("omd_anio")
                    .IsFixedLength();

                entity.Property(e => e.OmdSucId)
                    .HasMaxLength(2)
                    .HasColumnName("omd_suc_id")
                    .IsFixedLength();

                entity.Property(e => e.OmdCama)
                    .HasMaxLength(10)
                    .HasColumnName("omd_cama");

                entity.Property(e => e.OmdCantidadPruebas).HasColumnName("omd_cantidad_pruebas");

                entity.Property(e => e.OmdCodigoOnconaval)
                    .HasMaxLength(15)
                    .HasColumnName("omd_codigo_onconaval");

                entity.Property(e => e.OmdConsultorio)
                    .HasMaxLength(10)
                    .HasColumnName("omd_consultorio");

                entity.Property(e => e.OmdEstado)
                    .HasColumnName("omd_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.OmdFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("omd_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.OmdFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("omd_fecha_modificacion");

                entity.Property(e => e.OmdMedId).HasColumnName("omd_med_id");

                entity.Property(e => e.OmdNroHistoria)
                    .HasMaxLength(50)
                    .HasColumnName("omd_nro_historia");

                entity.Property(e => e.OmdObservaciones)
                    .HasMaxLength(3000)
                    .HasColumnName("omd_observaciones");

                entity.Property(e => e.OmdOrsTicket)
                    .HasMaxLength(11)
                    .HasColumnName("omd_ors_ticket");

                entity.Property(e => e.OmdPacCip)
                    .HasMaxLength(15)
                    .HasColumnName("omd_pac_cip");

                entity.Property(e => e.OmdPacEdad).HasColumnName("omd_pac_edad");

                entity.Property(e => e.OmdPacId).HasColumnName("omd_pac_id");

                entity.Property(e => e.OmdParId).HasColumnName("omd_par_id");

                entity.Property(e => e.OmdTaaId).HasColumnName("omd_taa_id");

                entity.Property(e => e.OmdTprId).HasColumnName("omd_tpr_id");

                entity.Property(e => e.OmdVigenciaId).HasColumnName("omd_vigencia_id");
            });

            modelBuilder.Entity<MstOrdenServicioCabecera>(entity =>
            {
                entity.HasKey(e => new { e.OrsId, e.OrsPeriodo, e.OrsAnio, e.OrsIdSucursal })
                    .HasName("MST_ORDEN_SERVICIO_CABECERA_pkey");

                entity.ToTable("MST_ORDEN_SERVICIO_CABECERA", "suizasoft");

                entity.HasIndex(e => e.OrsYearorden, "AK_MST_ORDEN_SERVICIO_CABECERA_ors_yearorden")
                    .IsUnique();

                entity.HasIndex(e => e.OrsIdCompania, "IX_MST_ORDEN_SERVICIO_CABECERA_ors_id_compania");

                entity.HasIndex(e => e.OrsIdEstado, "IX_MST_ORDEN_SERVICIO_CABECERA_ors_id_estado");

                entity.HasIndex(e => e.OrsIdMedico, "IX_MST_ORDEN_SERVICIO_CABECERA_ors_id_medico");

                entity.HasIndex(e => e.OrsIdModalidad, "IX_MST_ORDEN_SERVICIO_CABECERA_ors_id_modalidad");

                entity.HasIndex(e => e.OrsIdMoneda, "IX_MST_ORDEN_SERVICIO_CABECERA_ors_id_moneda");

                entity.HasIndex(e => e.OrsIdPaciente, "IX_MST_ORDEN_SERVICIO_CABECERA_ors_id_paciente");

                entity.HasIndex(e => e.OrsIdProcedencia, "IX_MST_ORDEN_SERVICIO_CABECERA_ors_id_procedencia");

                entity.HasIndex(e => e.OrsIdServicioAreaComp, "IX_MST_ORDEN_SERVICIO_CABECERA_ors_id_servicio_area_comp");

                entity.HasIndex(e => e.OrsIdSucursal, "IX_MST_ORDEN_SERVICIO_CABECERA_ors_id_sucursal");

                entity.HasIndex(e => e.OrsIdTipoDocumentoAcompaniante, "IX_MST_ORDEN_SERVICIO_CABECERA_ors_id_tipo_documento_acompania~");

                entity.HasIndex(e => e.OrsIdTipoSeguro, "IX_MST_ORDEN_SERVICIO_CABECERA_ors_id_tipo_seguro");

                entity.HasIndex(e => e.OrsYearorden, "yearorden_unique")
                    .IsUnique();

                entity.Property(e => e.OrsId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ors_id");

                entity.Property(e => e.OrsPeriodo)
                    .HasMaxLength(2)
                    .HasColumnName("ors_periodo")
                    .IsFixedLength();

                entity.Property(e => e.OrsAnio)
                    .HasMaxLength(2)
                    .HasColumnName("ors_anio")
                    .IsFixedLength();

                entity.Property(e => e.OrsIdSucursal)
                    .HasMaxLength(2)
                    .HasColumnName("ors_id_sucursal")
                    .IsFixedLength();

                entity.Property(e => e.OrsCodigoHistoriaIncor)
                    .HasMaxLength(40)
                    .HasColumnName("ors_codigo_historia_incor");

                entity.Property(e => e.OrsConfirmacionEnvio).HasColumnName("ors_confirmacion_envio");

                entity.Property(e => e.OrsDescuentoTotal)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_descuento_total");

                entity.Property(e => e.OrsEnvioAccesoPaciente).HasColumnName("ors_envio_acceso_paciente");

                entity.Property(e => e.OrsEnvioMedicoReferencia).HasColumnName("ors_envio_medico_referencia");

                entity.Property(e => e.OrsEstadoFactura)
                    .HasMaxLength(1)
                    .HasColumnName("ors_estado_factura");

                entity.Property(e => e.OrsFechaAnulacion).HasColumnName("ors_fecha_anulacion");

                entity.Property(e => e.OrsFechaAtencion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ors_fecha_atencion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.OrsFechaConfirmacionEnvio).HasColumnName("ors_fecha_confirmacion_envio");

                entity.Property(e => e.OrsFechaEnvioPaciente).HasColumnName("ors_fecha_envio_paciente");

                entity.Property(e => e.OrsFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ors_fecha_modificacion");

                entity.Property(e => e.OrsFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ors_fecha_registro");

                entity.Property(e => e.OrsFlagAcompaniante)
                    .HasColumnName("ors_flag_acompaniante")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrsFlagPaquete).HasColumnName("ors_flag_paquete");

                entity.Property(e => e.OrsFlagSctr)
                    .HasColumnName("ors_flag_sctr")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrsFlagTriaje)
                    .HasColumnName("ors_flag_triaje")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrsFranquicia)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_franquicia");

                entity.Property(e => e.OrsHistorialClinico)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_historial_clinico");

                entity.Property(e => e.OrsIdCompania).HasColumnName("ors_id_compania");

                entity.Property(e => e.OrsIdCompaniaAsociada).HasColumnName("ors_id_compania_asociada");

                entity.Property(e => e.OrsIdEmpresaCompania).HasColumnName("ors_id_empresa_compania");

                entity.Property(e => e.OrsIdEstado).HasColumnName("ors_id_estado");

                entity.Property(e => e.OrsIdEstadoAtencion)
                    .HasColumnName("ors_id_estado_atencion")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OrsIdEstadoAuditoria)
                    .HasColumnName("ors_id_estado_auditoria")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OrsIdMedico).HasColumnName("ors_id_medico");

                entity.Property(e => e.OrsIdModalidad).HasColumnName("ors_id_modalidad");

                entity.Property(e => e.OrsIdMoneda).HasColumnName("ors_id_moneda");

                entity.Property(e => e.OrsIdPaciente).HasColumnName("ors_id_paciente");

                entity.Property(e => e.OrsIdPaquete).HasColumnName("ors_id_paquete");

                entity.Property(e => e.OrsIdParentescoAcompaniante).HasColumnName("ors_id_parentesco_acompaniante");

                entity.Property(e => e.OrsIdParentescoTitularSeguro).HasColumnName("ors_id_parentesco_titular_seguro");

                entity.Property(e => e.OrsIdProcedencia).HasColumnName("ors_id_procedencia");

                entity.Property(e => e.OrsIdServicioAreaComp).HasColumnName("ors_id_servicio_area_comp");

                entity.Property(e => e.OrsIdTarifa).HasColumnName("ors_id_tarifa");

                entity.Property(e => e.OrsIdTipPrioridad).HasColumnName("ors_id_tip_prioridad");

                entity.Property(e => e.OrsIdTipoDocumentoAcompaniante).HasColumnName("ors_id_tipo_documento_acompaniante");

                entity.Property(e => e.OrsIdTipoSeguro).HasColumnName("ors_id_tipo_seguro");

                entity.Property(e => e.OrsImporteTotal)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_importe_total");

                entity.Property(e => e.OrsIpAnulacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_ip_anulacion");

                entity.Property(e => e.OrsIpIngreso)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_ip_ingreso");

                entity.Property(e => e.OrsIpModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_ip_modificacion");

                entity.Property(e => e.OrsMotivoAnulacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_motivo_anulacion");

                entity.Property(e => e.OrsNombreCompletoAcompaniante)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_nombre_completo_acompaniante");

                entity.Property(e => e.OrsNombresPaciente)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_nombres_paciente");

                entity.Property(e => e.OrsNumeroDocumentoAcompaniante)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_numero_documento_acompaniante");

                entity.Property(e => e.OrsNumeroFactura)
                    .HasMaxLength(7)
                    .HasColumnName("ors_numero_factura")
                    .IsFixedLength();

                entity.Property(e => e.OrsNumeroGuiaIncor)
                    .HasMaxLength(40)
                    .HasColumnName("ors_numero_guia_incor");

                entity.Property(e => e.OrsNumeroOrden)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_numero_orden");

                entity.Property(e => e.OrsObservacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_observacion");

                entity.Property(e => e.OrsOrdenNumero)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_orden_numero");

                entity.Property(e => e.OrsRutaOrdenMedica)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_ruta_orden_medica");

                entity.Property(e => e.OrsSaldo)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_saldo");

                entity.Property(e => e.OrsSerieFactura)
                    .HasMaxLength(3)
                    .HasColumnName("ors_serie_factura")
                    .IsFixedLength();

                entity.Property(e => e.OrsSubTotal)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_sub_total");

                entity.Property(e => e.OrsTipoCambio)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_tipo_cambio");

                entity.Property(e => e.OrsTotal)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_total");

                entity.Property(e => e.OrsTotalAcuenta)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_total_acuenta");

                entity.Property(e => e.OrsTotalDebe)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_total_debe");

                entity.Property(e => e.OrsTotalGravado)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_total_gravado");

                entity.Property(e => e.OrsTotalHaber)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_total_haber");

                entity.Property(e => e.OrsTotalIgv)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_total_igv");

                entity.Property(e => e.OrsTotalSolesLetra)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_total_soles_letra");

                entity.Property(e => e.OrsTotalVenta)
                    .HasPrecision(13, 3)
                    .HasColumnName("ors_total_venta");

                entity.Property(e => e.OrsUrlFotoPaciente)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_url_foto_paciente");

                entity.Property(e => e.OrsUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_usuario_modificacion");

                entity.Property(e => e.OrsUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("ors_usuario_registro");

                entity.Property(e => e.OrsYearorden)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("ors_yearorden");

                entity.HasOne(d => d.OrsIdCompaniaNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdCompania)
                    .HasConstraintName("orden_servicio_cab_compania_fk");

                entity.HasOne(d => d.OrsIdEstadoNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdEstado)
                    .HasConstraintName("MST_ORDEN_SERVICIO_CABECERA_ors_id_estado_fkey");

                entity.HasOne(d => d.OrsIdMedicoNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdMedico)
                    .HasConstraintName("orden_servicio_cab_medico_fk");

                entity.HasOne(d => d.OrsIdModalidadNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdModalidad)
                    .HasConstraintName("orden_servicio_cab_modalidad_fk");

                entity.HasOne(d => d.OrsIdMonedaNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdMoneda)
                    .HasConstraintName("orden_servicio_cab_moneda_fk");

                entity.HasOne(d => d.OrsIdPacienteNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdPaciente)
                    .HasConstraintName("orden_servicio_cab_pac_fk");

                entity.HasOne(d => d.OrsIdProcedenciaNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdProcedencia)
                    .HasConstraintName("mst_orden_servicio_cabecera_fk");

                entity.HasOne(d => d.OrsIdServicioAreaCompNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdServicioAreaComp)
                    .HasConstraintName("orden_servicio_cab_compania_asociada_fk");

                entity.HasOne(d => d.OrsIdSucursalNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orden_servicio_cab_sucursal_fk");

                entity.HasOne(d => d.OrsIdTipPrioridadNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdTipPrioridad)
                    .HasConstraintName("orden_servicio_cab_tip_prioridad_fk");

                entity.HasOne(d => d.OrsIdTipoDocumentoAcompanianteNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdTipoDocumentoAcompaniante)
                    .HasConstraintName("orden_servicio_tdocumento_acompaniante_fk");

                entity.HasOne(d => d.OrsIdTipoSeguroNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdTipoSeguro)
                    .HasConstraintName("orden_servicio_cab_tipo_seguro_fk");
            });

            modelBuilder.Entity<MstPaciente>(entity =>
            {
                entity.HasKey(e => e.PacId)
                    .HasName("MST_PACIENTE_pkey");

                entity.ToTable("MST_PACIENTE", "suizasoft");

                entity.HasIndex(e => e.PacIdDocAlt, "IX_MST_PACIENTE_pac_id_doc_alt");

                entity.HasIndex(e => e.PacIdEstadoCivil, "IX_MST_PACIENTE_pac_id_estado_civil");

                entity.HasIndex(e => e.PacIdFactorRh, "IX_MST_PACIENTE_pac_id_factor_rh");

                entity.HasIndex(e => e.PacIdGrupoEtnico, "IX_MST_PACIENTE_pac_id_grupo_etnico");

                entity.HasIndex(e => e.PacIdGrupoSanguineo, "IX_MST_PACIENTE_pac_id_grupo_sanguineo");

                entity.HasIndex(e => e.PacIdSexo, "IX_MST_PACIENTE_pac_id_sexo");

                entity.HasIndex(e => e.PacIdTipoDocumento, "IX_MST_PACIENTE_pac_id_tipo_documento");

                entity.HasIndex(e => e.PacIdUbigeo, "IX_MST_PACIENTE_pac_id_ubigeo");

                entity.HasIndex(e => new { e.PacNumeroDocumento, e.PacIdTipoDocumento }, "MST_PACIENTE_pac_numero_documento_pac_id_tipo_documento_key")
                    .IsUnique();

                entity.Property(e => e.PacId).HasColumnName("pac_id");

                entity.Property(e => e.PacAccesoWeb).HasColumnName("pac_acceso_web");

                entity.Property(e => e.PacApellidoCasado)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_apellido_casado");

                entity.Property(e => e.PacApellidoMaterno)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_apellido_materno");

                entity.Property(e => e.PacApellidoPaterno)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_apellido_paterno");

                entity.Property(e => e.PacCodigoHistoriaClinica)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_codigo_historia_clinica");

                entity.Property(e => e.PacCodigoValidacion)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_codigo_validacion");

                entity.Property(e => e.PacCorreoValidado).HasColumnName("pac_correo_validado");

                entity.Property(e => e.PacDireccion1)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_direccion1");

                entity.Property(e => e.PacDireccion2)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_direccion2");

                entity.Property(e => e.PacEdad).HasColumnName("pac_edad");

                entity.Property(e => e.PacEmail)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_email");

                entity.Property(e => e.PacEstado)
                    .HasColumnName("pac_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PacFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pac_fecha_creacion");

                entity.Property(e => e.PacFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pac_fecha_modificacion");

                entity.Property(e => e.PacFechaNacimiento).HasColumnName("pac_fecha_nacimiento");

                entity.Property(e => e.PacIdDocAlt).HasColumnName("pac_id_doc_alt");

                entity.Property(e => e.PacIdEstadoCivil).HasColumnName("pac_id_estado_civil");

                entity.Property(e => e.PacIdFactorRh).HasColumnName("pac_id_factor_rh");

                entity.Property(e => e.PacIdGrupoEtnico).HasColumnName("pac_id_grupo_etnico");

                entity.Property(e => e.PacIdGrupoSanguineo).HasColumnName("pac_id_grupo_sanguineo");

                entity.Property(e => e.PacIdSexo).HasColumnName("pac_id_sexo");

                entity.Property(e => e.PacIdTipoDocumento).HasColumnName("pac_id_tipo_documento");

                entity.Property(e => e.PacIdUbigeo).HasColumnName("pac_id_ubigeo");

                entity.Property(e => e.PacImageRuta)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_image_ruta");

                entity.Property(e => e.PacNacionalidad)
                    .HasMaxLength(25)
                    .HasColumnName("pac_nacionalidad");

                entity.Property(e => e.PacNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_nombre");

                entity.Property(e => e.PacNumeroDocAlt)
                    .HasMaxLength(25)
                    .HasColumnName("pac_numero_doc_alt");

                entity.Property(e => e.PacNumeroDocumento)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("pac_numero_documento");

                entity.Property(e => e.PacPasswordWeb)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_password_web");

                entity.Property(e => e.PacResultadoWhatsapp).HasColumnName("pac_resultado_whatsapp");

                entity.Property(e => e.PacTelefonoCasa)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_telefono_casa");

                entity.Property(e => e.PacTelefonoMovil)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_telefono_movil");

                entity.Property(e => e.PacUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_usuario_creacion");

                entity.Property(e => e.PacUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_usuario_modificacion");

                entity.Property(e => e.PacUsuarioWeb)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_usuario_web");

                entity.HasOne(d => d.PacIdDocAltNavigation)
                    .WithMany(p => p.MstPacientePacIdDocAltNavigations)
                    .HasForeignKey(d => d.PacIdDocAlt)
                    .HasConstraintName("paciente_tdoc_alt_fk");

                entity.HasOne(d => d.PacIdEstadoCivilNavigation)
                    .WithMany(p => p.MstPacientes)
                    .HasForeignKey(d => d.PacIdEstadoCivil)
                    .HasConstraintName("paciente_estadocivil_fk");

                entity.HasOne(d => d.PacIdFactorRhNavigation)
                    .WithMany(p => p.MstPacientes)
                    .HasForeignKey(d => d.PacIdFactorRh)
                    .HasConstraintName("mst_paciente_factor_rh_fk");

                entity.HasOne(d => d.PacIdGrupoEtnicoNavigation)
                    .WithMany(p => p.MstPacientes)
                    .HasForeignKey(d => d.PacIdGrupoEtnico)
                    .HasConstraintName("mst_paciente_grupo_etnico_fk");

                entity.HasOne(d => d.PacIdGrupoSanguineoNavigation)
                    .WithMany(p => p.MstPacientes)
                    .HasForeignKey(d => d.PacIdGrupoSanguineo)
                    .HasConstraintName("mst_paciente_grupo_sanguineo_fk");

                entity.HasOne(d => d.PacIdSexoNavigation)
                    .WithMany(p => p.MstPacientes)
                    .HasForeignKey(d => d.PacIdSexo)
                    .HasConstraintName("paciente_sexo_fk");

                entity.HasOne(d => d.PacIdTipoDocumentoNavigation)
                    .WithMany(p => p.MstPacientePacIdTipoDocumentoNavigations)
                    .HasForeignKey(d => d.PacIdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("paciente_tdocumento_fk");

                entity.HasOne(d => d.PacIdUbigeoNavigation)
                    .WithMany(p => p.MstPacientes)
                    .HasForeignKey(d => d.PacIdUbigeo)
                    .HasConstraintName("MST_PACIENTE_pac_id_ubigeo_fkey");
            });

            modelBuilder.Entity<MstPaqueteCabecera>(entity =>
            {
                entity.HasKey(e => e.PaqId)
                    .HasName("MST_PAQUETE_CABECERA_pkey");

                entity.ToTable("MST_PAQUETE_CABECERA", "suizasoft");

                entity.HasIndex(e => e.PaqIdModaidad, "IX_MST_PAQUETE_CABECERA_paq_id_modaidad");

                entity.HasIndex(e => e.PaqMoneda, "IX_MST_PAQUETE_CABECERA_paq_moneda");

                entity.HasIndex(e => e.PaqTipoeval, "IX_MST_PAQUETE_CABECERA_paq_tipoeval");

                entity.Property(e => e.PaqId).HasColumnName("paq_id");

                entity.Property(e => e.PacNumpano)
                    .HasColumnType("character varying")
                    .HasColumnName("pac_numpano")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PaqDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("paq_descripcion");

                entity.Property(e => e.PaqEstado).HasColumnName("paq_estado");

                entity.Property(e => e.PaqFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("paq_fecha_modificacion");

                entity.Property(e => e.PaqFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("paq_fecha_registro");

                entity.Property(e => e.PaqFechafin)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("paq_fechafin");

                entity.Property(e => e.PaqFechainicio)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("paq_fechainicio");

                entity.Property(e => e.PaqIdModaidad).HasColumnName("paq_id_modaidad");

                entity.Property(e => e.PaqMoneda).HasColumnName("paq_moneda");

                entity.Property(e => e.PaqNumeroEspecialidad)
                    .HasColumnType("character varying")
                    .HasColumnName("paq_numero_especialidad");

                entity.Property(e => e.PaqNuminfp)
                    .HasColumnType("character varying")
                    .HasColumnName("paq_numinfp");

                entity.Property(e => e.PaqNumpaqfox)
                    .HasColumnType("character varying")
                    .HasColumnName("paq_numpaqfox");

                entity.Property(e => e.PaqNumpqc)
                    .HasColumnType("character varying")
                    .HasColumnName("paq_numpqc")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PaqObservacion)
                    .HasColumnType("character varying")
                    .HasColumnName("paq_observacion");

                entity.Property(e => e.PaqPrecioTotalConIgv)
                    .HasPrecision(13, 2)
                    .HasColumnName("paq_precio_total_con_igv");

                entity.Property(e => e.PaqPrecioTotalSinIgv)
                    .HasPrecision(13, 2)
                    .HasColumnName("paq_precio_total_sin_igv");

                entity.Property(e => e.PaqTipoPaquete).HasColumnName("paq_tipo_paquete");

                entity.Property(e => e.PaqTipoeval).HasColumnName("paq_tipoeval");

                entity.Property(e => e.PaqUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("paq_usuario_modificacion");

                entity.Property(e => e.PaqUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("paq_usuario_registro");

                entity.HasOne(d => d.PaqIdModaidadNavigation)
                    .WithMany(p => p.MstPaqueteCabeceras)
                    .HasForeignKey(d => d.PaqIdModaidad)
                    .HasConstraintName("paquetecabecera_modalidad_fk");

                entity.HasOne(d => d.PaqMonedaNavigation)
                    .WithMany(p => p.MstPaqueteCabeceras)
                    .HasForeignKey(d => d.PaqMoneda)
                    .HasConstraintName("paquetecabecera_moneda_fk");

                entity.HasOne(d => d.PaqTipoevalNavigation)
                    .WithMany(p => p.MstPaqueteCabeceras)
                    .HasForeignKey(d => d.PaqTipoeval)
                    .HasConstraintName("paquetecabecera_tipoevaluacion_fk");
            });

            modelBuilder.Entity<MstParametroSistema>(entity =>
            {
                entity.HasKey(e => new { e.PsNumpars, e.PsItempars })
                    .HasName("MST_PARAMETRO_SISTEMA_pkey");

                entity.ToTable("MST_PARAMETRO_SISTEMA", "suizasoft");

                entity.Property(e => e.PsNumpars)
                    .HasMaxLength(4)
                    .HasColumnName("ps_numpars")
                    .IsFixedLength();

                entity.Property(e => e.PsItempars)
                    .HasMaxLength(13)
                    .HasColumnName("ps_itempars");

                entity.Property(e => e.PsDesgeneral)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("ps_desgeneral");

                entity.Property(e => e.PsDespars)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("ps_despars");

                entity.Property(e => e.PsDespars2)
                    .HasMaxLength(2000)
                    .HasColumnName("ps_despars2");

                entity.Property(e => e.PsDespars3)
                    .HasMaxLength(20)
                    .HasColumnName("ps_despars3");

                entity.Property(e => e.PsDespars4)
                    .HasMaxLength(20)
                    .HasColumnName("ps_despars4");

                entity.Property(e => e.PsDespars5)
                    .HasMaxLength(100)
                    .HasColumnName("ps_despars5");

                entity.Property(e => e.PsDespars6)
                    .HasMaxLength(200)
                    .HasColumnName("ps_despars6");

                entity.Property(e => e.PsDespars7)
                    .HasMaxLength(200)
                    .HasColumnName("ps_despars7");

                entity.Property(e => e.PsDespars8)
                    .HasMaxLength(200)
                    .HasColumnName("ps_despars8");

                entity.Property(e => e.PsFecha1)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ps_fecha1");

                entity.Property(e => e.PsFechaMod)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ps_fecha_mod");

                entity.Property(e => e.PsFecing)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ps_fecing")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PsValor1)
                    .HasPrecision(10, 2)
                    .HasColumnName("ps_valor1");

                entity.Property(e => e.PsValor2)
                    .HasPrecision(10, 2)
                    .HasColumnName("ps_valor2");

                entity.Property(e => e.PsValor3)
                    .HasPrecision(10, 3)
                    .HasColumnName("ps_valor3");

                entity.Property(e => e.PsValor4)
                    .HasPrecision(10, 2)
                    .HasColumnName("ps_valor4");

                entity.Property(e => e.PsValorpars)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ps_valorpars");
            });

            modelBuilder.Entity<MstPaternidad>(entity =>
            {
                entity.HasKey(e => e.PatId)
                    .HasName("MST_PATERNIDAD_pkey");

                entity.ToTable("MST_PATERNIDAD", "suizasoft");

                entity.Property(e => e.PatId)
                    .ValueGeneratedNever()
                    .HasColumnName("pat_id");

                entity.Property(e => e.PatDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("pat_descripcion");

                entity.Property(e => e.PatEstado).HasColumnName("pat_estado");
            });

            modelBuilder.Entity<MstPeriodoCredito>(entity =>
            {
                entity.HasKey(e => e.PcrId)
                    .HasName("MST_PERIODO_CREDITO_pkey");

                entity.ToTable("MST_PERIODO_CREDITO", "suizasoft");

                entity.Property(e => e.PcrId)
                    .ValueGeneratedNever()
                    .HasColumnName("pcr_id");

                entity.Property(e => e.PcrDescripcion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("pcr_descripcion");
            });

            modelBuilder.Entity<MstPeriodoFacturacion>(entity =>
            {
                entity.HasKey(e => e.PfaId)
                    .HasName("MST_PERIODO_FACTURACION_pkey");

                entity.ToTable("MST_PERIODO_FACTURACION", "suizasoft");

                entity.Property(e => e.PfaId)
                    .ValueGeneratedNever()
                    .HasColumnName("pfa_id");

                entity.Property(e => e.PfaCodigoAnterior)
                    .HasColumnType("character varying")
                    .HasColumnName("pfa_codigo_anterior");

                entity.Property(e => e.PfaDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("pfa_descripcion");

                entity.Property(e => e.PfaEstado).HasColumnName("pfa_estado");
            });

            modelBuilder.Entity<MstPreticketCabecera>(entity =>
            {
                entity.HasKey(e => new { e.PrcId, e.PrcPeriodo, e.PrcAnio, e.PrcIdSucursal })
                    .HasName("MST_PRETICKET_CABECERA_pkey");

                entity.ToTable("MST_PRETICKET_CABECERA", "suizasoft");

                entity.HasIndex(e => e.PrcIdCompania, "IX_MST_PRETICKET_CABECERA_prc_id_compania");

                entity.HasIndex(e => e.PrcIdCompaniaAsociada, "IX_MST_PRETICKET_CABECERA_prc_id_compania_asociada");

                entity.HasIndex(e => e.PrcIdEstado, "IX_MST_PRETICKET_CABECERA_prc_id_estado");

                entity.HasIndex(e => e.PrcIdMedico, "IX_MST_PRETICKET_CABECERA_prc_id_medico");

                entity.HasIndex(e => e.PrcIdModalidad, "IX_MST_PRETICKET_CABECERA_prc_id_modalidad");

                entity.HasIndex(e => e.PrcIdMoneda, "IX_MST_PRETICKET_CABECERA_prc_id_moneda");

                entity.HasIndex(e => e.PrcIdPaciente, "IX_MST_PRETICKET_CABECERA_prc_id_paciente");

                entity.HasIndex(e => e.PrcIdSucursal, "IX_MST_PRETICKET_CABECERA_prc_id_sucursal");

                entity.Property(e => e.PrcId).HasColumnName("prc_id");

                entity.Property(e => e.PrcPeriodo)
                    .HasMaxLength(2)
                    .HasColumnName("prc_periodo")
                    .IsFixedLength();

                entity.Property(e => e.PrcAnio)
                    .HasMaxLength(2)
                    .HasColumnName("prc_anio")
                    .IsFixedLength();

                entity.Property(e => e.PrcIdSucursal)
                    .HasMaxLength(2)
                    .HasColumnName("prc_id_sucursal")
                    .IsFixedLength();

                entity.Property(e => e.PrcArea)
                    .HasColumnType("character varying")
                    .HasColumnName("prc_area");

                entity.Property(e => e.PrcCargo)
                    .HasColumnType("character varying")
                    .HasColumnName("prc_cargo");

                entity.Property(e => e.PrcDescuentoTotal)
                    .HasPrecision(13, 3)
                    .HasColumnName("prc_descuento_total");

                entity.Property(e => e.PrcFechaAnulacion).HasColumnName("prc_fecha_anulacion");

                entity.Property(e => e.PrcFechaAtencion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("prc_fecha_atencion");

                entity.Property(e => e.PrcFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("prc_fecha_modificacion");

                entity.Property(e => e.PrcFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("prc_fecha_registro");

                entity.Property(e => e.PrcFlagPaquete).HasColumnName("prc_flag_paquete");

                entity.Property(e => e.PrcFranquicia)
                    .HasPrecision(13, 3)
                    .HasColumnName("prc_franquicia");

                entity.Property(e => e.PrcIdCompania).HasColumnName("prc_id_compania");

                entity.Property(e => e.PrcIdCompaniaAsociada).HasColumnName("prc_id_compania_asociada");

                entity.Property(e => e.PrcIdEmpresaCompania).HasColumnName("prc_id_empresa_compania");

                entity.Property(e => e.PrcIdEstado).HasColumnName("prc_id_estado");

                entity.Property(e => e.PrcIdMedico).HasColumnName("prc_id_medico");

                entity.Property(e => e.PrcIdModalidad).HasColumnName("prc_id_modalidad");

                entity.Property(e => e.PrcIdMoneda).HasColumnName("prc_id_moneda");

                entity.Property(e => e.PrcIdPaciente).HasColumnName("prc_id_paciente");

                entity.Property(e => e.PrcIdPaquete).HasColumnName("prc_id_paquete");

                entity.Property(e => e.PrcIdTarifa).HasColumnName("prc_id_tarifa");

                entity.Property(e => e.PrcImporteTotal)
                    .HasPrecision(13, 3)
                    .HasColumnName("prc_importe_total");

                entity.Property(e => e.PrcIpAnulacion)
                    .HasColumnType("character varying")
                    .HasColumnName("prc_ip_anulacion");

                entity.Property(e => e.PrcIpIngreso)
                    .HasColumnType("character varying")
                    .HasColumnName("prc_ip_ingreso");

                entity.Property(e => e.PrcIpModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("prc_ip_modificacion");

                entity.Property(e => e.PrcMotivoAnulacion)
                    .HasColumnType("character varying")
                    .HasColumnName("prc_motivo_anulacion");

                entity.Property(e => e.PrcObservacion)
                    .HasColumnType("character varying")
                    .HasColumnName("prc_observacion");

                entity.Property(e => e.PrcOrdenNumero)
                    .HasColumnType("character varying")
                    .HasColumnName("prc_orden_numero");

                entity.Property(e => e.PrcSaldo)
                    .HasPrecision(13, 3)
                    .HasColumnName("prc_saldo");

                entity.Property(e => e.PrcSede)
                    .HasColumnType("character varying")
                    .HasColumnName("prc_sede");

                entity.Property(e => e.PrcTipoCambio)
                    .HasPrecision(13, 3)
                    .HasColumnName("prc_tipo_cambio");

                entity.Property(e => e.PrcTotal)
                    .HasPrecision(13, 3)
                    .HasColumnName("prc_total");

                entity.Property(e => e.PrcTotalAcuenta)
                    .HasPrecision(13, 3)
                    .HasColumnName("prc_total_acuenta");

                entity.Property(e => e.PrcTotalDebe)
                    .HasPrecision(13, 3)
                    .HasColumnName("prc_total_debe");

                entity.Property(e => e.PrcTotalGravado)
                    .HasPrecision(13, 3)
                    .HasColumnName("prc_total_gravado");

                entity.Property(e => e.PrcTotalHaber)
                    .HasPrecision(13, 3)
                    .HasColumnName("prc_total_haber");

                entity.Property(e => e.PrcTotalIgv)
                    .HasPrecision(13, 3)
                    .HasColumnName("prc_total_igv");

                entity.Property(e => e.PrcTotalSolesLetra)
                    .HasPrecision(13, 3)
                    .HasColumnName("prc_total_soles_letra");

                entity.Property(e => e.PrcTotalVenta)
                    .HasPrecision(13, 3)
                    .HasColumnName("prc_total_venta");

                entity.Property(e => e.PrcUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("prc_usuario_modificacion");

                entity.Property(e => e.PrcUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("prc_usuario_registro");

                entity.Property(e => e.PrsSubTotal)
                    .HasPrecision(13, 3)
                    .HasColumnName("prs_sub_total");

                entity.HasOne(d => d.PrcIdCompaniaNavigation)
                    .WithMany(p => p.MstPreticketCabeceraPrcIdCompaniaNavigations)
                    .HasForeignKey(d => d.PrcIdCompania)
                    .HasConstraintName("orden_preticket_cab_compania_fk");

                entity.HasOne(d => d.PrcIdCompaniaAsociadaNavigation)
                    .WithMany(p => p.MstPreticketCabeceraPrcIdCompaniaAsociadaNavigations)
                    .HasForeignKey(d => d.PrcIdCompaniaAsociada)
                    .HasConstraintName("orden_preticket_cab_compania_asociada_fk");

                entity.HasOne(d => d.PrcIdEstadoNavigation)
                    .WithMany(p => p.MstPreticketCabeceras)
                    .HasForeignKey(d => d.PrcIdEstado)
                    .HasConstraintName("orden_preticket_cab_prc_id_estado_fkey");

                entity.HasOne(d => d.PrcIdMedicoNavigation)
                    .WithMany(p => p.MstPreticketCabeceras)
                    .HasForeignKey(d => d.PrcIdMedico)
                    .HasConstraintName("orden_preticket_cab_medico_fk");

                entity.HasOne(d => d.PrcIdModalidadNavigation)
                    .WithMany(p => p.MstPreticketCabeceras)
                    .HasForeignKey(d => d.PrcIdModalidad)
                    .HasConstraintName("orden_preticket_cab_modalidad_fk");

                entity.HasOne(d => d.PrcIdMonedaNavigation)
                    .WithMany(p => p.MstPreticketCabeceras)
                    .HasForeignKey(d => d.PrcIdMoneda)
                    .HasConstraintName("orden_preticket_cab_moneda_fk");

                entity.HasOne(d => d.PrcIdPacienteNavigation)
                    .WithMany(p => p.MstPreticketCabeceras)
                    .HasForeignKey(d => d.PrcIdPaciente)
                    .HasConstraintName("orden_preticket_cab_pac_fk");

                entity.HasOne(d => d.PrcIdSucursalNavigation)
                    .WithMany(p => p.MstPreticketCabeceras)
                    .HasForeignKey(d => d.PrcIdSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orden_preticket_cab_sucursal_fk");
            });

            modelBuilder.Entity<MstProductoSeguro>(entity =>
            {
                entity.HasKey(e => e.PrsId)
                    .HasName("MST_PRODUCTO_SEGUROS_pkey");

                entity.ToTable("MST_PRODUCTO_SEGUROS", "suizasoft");

                entity.Property(e => e.PrsId).HasColumnName("prs_id");

                entity.Property(e => e.PrsEstado)
                    .HasColumnName("prs_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PrsFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("prs_fecha_modificacion");

                entity.Property(e => e.PrsIdCompania)
                    .HasColumnType("character varying")
                    .HasColumnName("prs_id_compania");

                entity.Property(e => e.PrsIdGrupo).HasColumnName("prs_id_grupo");

                entity.Property(e => e.PrsNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("prs_nombre");

                entity.Property(e => e.PrsRuc)
                    .HasColumnType("character varying")
                    .HasColumnName("prs_ruc");

                entity.Property(e => e.PrsUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("prs_usuario_modificacion");

                entity.Property(e => e.PrsUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("prs_usuario_registro");

                entity.Property(e => e.PrsfechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("prsfecha_registro");
            });

            modelBuilder.Entity<MstProductosFarmacium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MST_PRODUCTOS_FARMACIA", "suizasoft");

                entity.Property(e => e.FarC10FechaDispensFarmacia)
                    .HasMaxLength(8)
                    .HasColumnName("far_c10_fecha_dispens_farmacia")
                    .IsFixedLength();

                entity.Property(e => e.FarC11CantidadVentaProducto)
                    .HasPrecision(7, 2)
                    .HasColumnName("far_c11_cantidad_venta_producto");

                entity.Property(e => e.FarC12MontoUnitarioSinimpuesto)
                    .HasPrecision(12, 2)
                    .HasColumnName("far_c12_monto_unitario_sinimpuesto");

                entity.Property(e => e.FarC13CopagoProdFarmacia)
                    .HasPrecision(12, 2)
                    .HasColumnName("far_c13_copago_prod_farmacia");

                entity.Property(e => e.FarC14MontoPresentProdfarmacia)
                    .HasPrecision(12, 2)
                    .HasColumnName("far_c14_monto_present_prodfarmacia");

                entity.Property(e => e.FarC15MontoNocubiertoProdfarmacia)
                    .HasPrecision(12, 2)
                    .HasColumnName("far_c15_monto_nocubierto_prodfarmacia");

                entity.Property(e => e.FarC16DiagnosticoAsociadoProdfarmacia)
                    .HasMaxLength(5)
                    .HasColumnName("far_c16_diagnostico_asociado_prodfarmacia")
                    .IsFixedLength();

                entity.Property(e => e.FarC17ProductoExentoigv)
                    .HasMaxLength(1)
                    .HasColumnName("far_c17_producto_exentoigv");

                entity.Property(e => e.FarC18GuiaFarmacia)
                    .HasMaxLength(12)
                    .HasColumnName("far_c18_guia_farmacia")
                    .IsFixedLength();

                entity.Property(e => e.FarC1RucEmpresa)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("far_c1_ruc_empresa")
                    .IsFixedLength();

                entity.Property(e => e.FarC2CodigoIpress)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("far_c2_codigo_ipress")
                    .IsFixedLength();

                entity.Property(e => e.FarC3TipoDocpago)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("far_c3_tipo_docpago")
                    .IsFixedLength();

                entity.Property(e => e.FarC4NroDocpago)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("far_c4_nro_docpago")
                    .IsFixedLength();

                entity.Property(e => e.FarC5CorrelativoPrestac)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("far_c5_correlativo_prestac")
                    .IsFixedLength();

                entity.Property(e => e.FarC6CorrelativoProdfarmacAtenc)
                    .HasMaxLength(4)
                    .HasColumnName("far_c6_correlativo_prodfarmac_atenc")
                    .IsFixedLength();

                entity.Property(e => e.FarC7Catalprodfarmacia)
                    .HasMaxLength(1)
                    .HasColumnName("far_c7_catalprodfarmacia");

                entity.Property(e => e.FarC8Codproducfarmacia)
                    .HasMaxLength(15)
                    .HasColumnName("far_c8_codproducfarmacia")
                    .IsFixedLength();

                entity.Property(e => e.FarC9CodprodObservmedDigemid)
                    .HasMaxLength(6)
                    .HasColumnName("far_c9_codprod_observmed_digemid")
                    .IsFixedLength();

                entity.Property(e => e.FarCodFina)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("far_cod_fina")
                    .IsFixedLength();

                entity.Property(e => e.FarFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("far_fecha_creacion");

                entity.Property(e => e.FarIdMedicamento).HasColumnName("far_id_medicamento");

                entity.Property(e => e.FarNroFactura)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("far_nro_factura")
                    .IsFixedLength();

                entity.Property(e => e.FarNumeroAtencion).HasColumnName("far_numero_atencion");

                entity.Property(e => e.FarNumeroLote)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasColumnName("far_numero_lote")
                    .IsFixedLength();

                entity.Property(e => e.FarSerie)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("far_serie")
                    .IsFixedLength();

                entity.Property(e => e.FarUsuarioCreacion).HasColumnName("far_usuario_creacion");
            });

            modelBuilder.Entity<MstPromotor>(entity =>
            {
                entity.HasKey(e => e.ProId)
                    .HasName("MST_PROMOTOR_pkey");

                entity.ToTable("MST_PROMOTOR", "suizasoft");

                entity.HasIndex(e => e.ProIdModalidad, "IX_MST_PROMOTOR_pro_id_modalidad");

                entity.HasIndex(e => e.ProIdSupervisor, "IX_MST_PROMOTOR_pro_id_supervisor");

                entity.HasIndex(e => e.ProIdTipoDocumento, "IX_MST_PROMOTOR_pro_id_tipo_documento");

                entity.HasIndex(e => e.ProIdUbigeo, "IX_MST_PROMOTOR_pro_id_ubigeo");

                entity.HasIndex(e => e.ProIdTipoPromotor, "fki_promotor_tipopromotor_fk");

                entity.Property(e => e.ProId).HasColumnName("pro_id");

                entity.Property(e => e.ProApellidoMaterno)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_apellido_materno");

                entity.Property(e => e.ProApellidoPaterno)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_apellido_paterno");

                entity.Property(e => e.ProClaveWeb)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_clave_web");

                entity.Property(e => e.ProCodigoAnterior)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_codigo_anterior");

                entity.Property(e => e.ProComision).HasColumnName("pro_comision");

                entity.Property(e => e.ProDireccion)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_direccion");

                entity.Property(e => e.ProEmail)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_email");

                entity.Property(e => e.ProEstado).HasColumnName("pro_estado");

                entity.Property(e => e.ProFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pro_fecha_creacion");

                entity.Property(e => e.ProFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pro_fecha_modificacion");

                entity.Property(e => e.ProFechaNacimiento)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pro_fecha_nacimiento");

                entity.Property(e => e.ProIdModalidad).HasColumnName("pro_id_modalidad");

                entity.Property(e => e.ProIdSupervisor).HasColumnName("pro_id_supervisor");

                entity.Property(e => e.ProIdTipoDocumento).HasColumnName("pro_id_tipo_documento");

                entity.Property(e => e.ProIdTipoPromotor).HasColumnName("pro_id_tipo_promotor");

                entity.Property(e => e.ProIdUbigeo).HasColumnName("pro_id_ubigeo");

                entity.Property(e => e.ProNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_nombre");

                entity.Property(e => e.ProNombreCompleto)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_nombre_completo");

                entity.Property(e => e.ProNumeroDocumento)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_numero_documento");

                entity.Property(e => e.ProTelefonoCasa)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_telefono_casa");

                entity.Property(e => e.ProTelefonoMovil)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_telefono_movil");

                entity.Property(e => e.ProUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_usuario_creacion");

                entity.Property(e => e.ProUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_usuario_modificacion");

                entity.Property(e => e.ProUsuarioWeb)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_usuario_web");

                entity.HasOne(d => d.ProIdModalidadNavigation)
                    .WithMany(p => p.MstPromotors)
                    .HasForeignKey(d => d.ProIdModalidad)
                    .HasConstraintName("MST_PROMOTOR_pro_id_modalidad_fkey");

                entity.HasOne(d => d.ProIdSupervisorNavigation)
                    .WithMany(p => p.MstPromotors)
                    .HasForeignKey(d => d.ProIdSupervisor)
                    .HasConstraintName("MST_PROMOTOR_pro_id_supervisor_fkey");

                entity.HasOne(d => d.ProIdTipoDocumentoNavigation)
                    .WithMany(p => p.MstPromotors)
                    .HasForeignKey(d => d.ProIdTipoDocumento)
                    .HasConstraintName("MST_PROMOTOR_pro_id_tipo_documento_fkey");

                entity.HasOne(d => d.ProIdTipoPromotorNavigation)
                    .WithMany(p => p.MstPromotors)
                    .HasForeignKey(d => d.ProIdTipoPromotor)
                    .HasConstraintName("MST_PROMOTOR_pro_id_tipo_promotor_fkey");

                entity.HasOne(d => d.ProIdUbigeoNavigation)
                    .WithMany(p => p.MstPromotors)
                    .HasForeignKey(d => d.ProIdUbigeo)
                    .HasConstraintName("MST_PROMOTOR_pro_id_ubigeo_fkey");
            });

            modelBuilder.Entity<MstProyecto>(entity =>
            {
                entity.HasKey(e => e.PryId)
                    .HasName("MST_PROYECTO_pkey");

                entity.ToTable("MST_PROYECTO", "suizasoft");

                entity.Property(e => e.PryId).HasColumnName("pry_id");

                entity.Property(e => e.PryCodigoAnterior)
                    .HasMaxLength(3)
                    .HasColumnName("pry_codigo_anterior");

                entity.Property(e => e.PryCodigoSap)
                    .HasColumnType("character varying")
                    .HasColumnName("pry_codigo_sap");

                entity.Property(e => e.PryDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("pry_descripcion");

                entity.Property(e => e.PryEstado).HasColumnName("pry_estado");

                entity.Property(e => e.PryFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pry_fecha_creacion");
            });

            modelBuilder.Entity<MstResultadosRutaAw>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MST_RESULTADOS_RUTA_AWS", "suizasoft");

                entity.Property(e => e.RraFecModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("rra_fec_modificacion");

                entity.Property(e => e.RraFecRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("rra_fec_registro");

                entity.Property(e => e.RraFecVal)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("rra_fec_val");

                entity.Property(e => e.RraRoute)
                    .HasMaxLength(200)
                    .HasColumnName("rra_route");

                entity.Property(e => e.RraState)
                    .HasMaxLength(1)
                    .HasColumnName("rra_state");

                entity.Property(e => e.RraUsuModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("rra_usu_modificacion");

                entity.Property(e => e.RraUsuRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("rra_usu_registro");

                entity.Property(e => e.RraYearorder)
                    .HasMaxLength(12)
                    .HasColumnName("rra_yearorder");
            });

            modelBuilder.Entity<MstRol>(entity =>
            {
                entity.HasKey(e => e.RolId)
                    .HasName("rol_id_pk");

                entity.ToTable("MST_ROL", "suizasoft");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.Property(e => e.RolDescripcion)
                    .HasMaxLength(30)
                    .HasColumnName("rol_descripcion");

                entity.Property(e => e.RolEstado).HasColumnName("rol_estado");

                entity.Property(e => e.RolFechacreacion).HasColumnName("rol_fechacreacion");
            });

            modelBuilder.Entity<MstRolCentroMedico>(entity =>
            {
                entity.HasKey(e => e.RolCmId)
                    .HasName("rol_centro_medico_id_pk");

                entity.ToTable("MST_ROL_CENTRO_MEDICO", "suizasoft");

                entity.Property(e => e.RolCmId).HasColumnName("rol_cm_id");

                entity.Property(e => e.RolCmDescripcion)
                    .HasMaxLength(30)
                    .HasColumnName("rol_cm_descripcion");

                entity.Property(e => e.RolCmEstado).HasColumnName("rol_cm_estado");
            });

            modelBuilder.Entity<MstRuteoSeguro>(entity =>
            {
                entity.HasKey(e => e.RusId)
                    .HasName("MST_RUTEO_SEGUROS_pkey");

                entity.ToTable("MST_RUTEO_SEGUROS", "suizasoft");

                entity.Property(e => e.RusId).HasColumnName("rus_id");

                entity.Property(e => e.RusEstado).HasColumnName("rus_estado");

                entity.Property(e => e.RusFecha)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("rus_fecha");

                entity.Property(e => e.RusFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("rus_fecha_modificacion");

                entity.Property(e => e.RusFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("rus_fecha_registro");

                entity.Property(e => e.RusFlagEnvio).HasColumnName("rus_flag_envio");

                entity.Property(e => e.RusNumeroCitas).HasColumnName("rus_numero_citas");

                entity.Property(e => e.RusNumeroMedicos).HasColumnName("rus_numero_medicos");

                entity.Property(e => e.RusObseracion)
                    .HasColumnType("character varying")
                    .HasColumnName("rus_obseracion");

                entity.Property(e => e.RusUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("rus_usuario_modificacion");

                entity.Property(e => e.RusUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("rus_usuario_registro");
            });

            modelBuilder.Entity<MstSeccionLaboratorio>(entity =>
            {
                entity.HasKey(e => e.SecId)
                    .HasName("MST_SECCION_LABORATORIO_pkey");

                entity.ToTable("MST_SECCION_LABORATORIO", "suizasoft");

                entity.HasIndex(e => e.SecAreId, "IX_MST_SECCION_LABORATORIO_sec_are_id");

                entity.HasIndex(e => e.SecTipId, "IX_MST_SECCION_LABORATORIO_sec_tip_id");

                entity.Property(e => e.SecId).HasColumnName("sec_id");

                entity.Property(e => e.SecAreId).HasColumnName("sec_are_id");

                entity.Property(e => e.SecDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("sec_descripcion");

                entity.Property(e => e.SecEstado).HasColumnName("sec_estado");

                entity.Property(e => e.SecTipId).HasColumnName("sec_tip_id");

                entity.HasOne(d => d.SecAre)
                    .WithMany(p => p.MstSeccionLaboratorios)
                    .HasForeignKey(d => d.SecAreId)
                    .HasConstraintName("seccionlab_sec_are_id_fk");

                entity.HasOne(d => d.SecTip)
                    .WithMany(p => p.MstSeccionLaboratorios)
                    .HasForeignKey(d => d.SecTipId)
                    .HasConstraintName("seccionlab_sec_tip_id_fk");
            });

            modelBuilder.Entity<MstServicio>(entity =>
            {
                entity.HasKey(e => e.SerCodigo)
                    .HasName("MST_SERVICIO_pkey");

                entity.ToTable("MST_SERVICIO", "suizasoft");

                entity.HasIndex(e => e.SerAreaNegocio, "IX_MST_SERVICIO_ser_area_negocio");

                entity.HasIndex(e => e.SerCentroCostoNegocio, "IX_MST_SERVICIO_ser_centro_costo_negocio");

                entity.HasIndex(e => e.SerEquipo, "IX_MST_SERVICIO_ser_equipo");

                entity.HasIndex(e => e.SerIdEspecialidad, "IX_MST_SERVICIO_ser_id_especialidad");

                entity.HasIndex(e => e.SerLineaNegocio, "IX_MST_SERVICIO_ser_linea_negocio");

                entity.HasIndex(e => e.SerMetodo, "IX_MST_SERVICIO_ser_metodo");

                entity.HasIndex(e => e.SerProcesamiento, "IX_MST_SERVICIO_ser_procesamiento");

                entity.HasIndex(e => e.SerProyecto, "IX_MST_SERVICIO_ser_proyecto");

                entity.HasIndex(e => e.SerTempOptimaEnvio, "IX_MST_SERVICIO_ser_temp_optima_envio");

                entity.HasIndex(e => e.SerTipoServicio, "IX_MST_SERVICIO_ser_tipo_servicio");

                entity.HasIndex(e => e.SerTipoTubo, "IX_MST_SERVICIO_ser_tipo_tubo");

                entity.HasIndex(e => e.SerUnidadNegocio, "IX_MST_SERVICIO_ser_unidad_negocio");

                entity.Property(e => e.SerCodigo).HasColumnName("ser_codigo");

                entity.Property(e => e.SerAreaNegocio).HasColumnName("ser_area_negocio");

                entity.Property(e => e.SerBiopsia).HasColumnName("ser_biopsia");

                entity.Property(e => e.SerCentroCostoNegocio).HasColumnName("ser_centro_costo_negocio");

                entity.Property(e => e.SerCodigoAlfanumerico)
                    .HasMaxLength(8)
                    .HasColumnName("ser_codigo_alfanumerico");

                entity.Property(e => e.SerCodigoSap)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_codigo_sap");

                entity.Property(e => e.SerCodigoSegus)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_codigo_segus");

                entity.Property(e => e.SerComentarioEspanol)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_comentario_espanol");

                entity.Property(e => e.SerComentarioIngles)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_comentario_ingles");

                entity.Property(e => e.SerComisionLima).HasColumnName("ser_comision_lima");

                entity.Property(e => e.SerComisionMed).HasColumnName("ser_comision_med");

                entity.Property(e => e.SerComisionProvincia).HasColumnName("ser_comision_provincia");

                entity.Property(e => e.SerCondicionesPreanaliticas)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_condiciones_preanaliticas");

                entity.Property(e => e.SerCondicionesPreanaliticasRef)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_condiciones_preanaliticas_ref");

                entity.Property(e => e.SerConfidencial).HasColumnName("ser_confidencial");

                entity.Property(e => e.SerCosto).HasColumnName("ser_costo");

                entity.Property(e => e.SerDescripcionEspanol)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("ser_descripcion_espanol");

                entity.Property(e => e.SerDescripcionIngles)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_descripcion_ingles");

                entity.Property(e => e.SerEquipo).HasColumnName("ser_equipo");

                entity.Property(e => e.SerErrorSap)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_error_sap");

                entity.Property(e => e.SerEstado).HasColumnName("ser_estado");

                entity.Property(e => e.SerEstadoSap)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("ser_estado_sap")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.SerFechaModif)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ser_fecha_modif");

                entity.Property(e => e.SerFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ser_fecha_registro");

                entity.Property(e => e.SerFlagPerfil).HasColumnName("ser_flag_perfil");

                entity.Property(e => e.SerFlagTiempo)
                    .HasMaxLength(1)
                    .HasColumnName("ser_flag_tiempo");

                entity.Property(e => e.SerFox)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_fox");

                entity.Property(e => e.SerGrupoServicio)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_grupo_servicio");

                entity.Property(e => e.SerIdCie)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_id_cie");

                entity.Property(e => e.SerIdDiagnostico)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_id_diagnostico");

                entity.Property(e => e.SerIdEspecialidad).HasColumnName("ser_id_especialidad");

                entity.Property(e => e.SerIdTiempoProceso).HasColumnName("ser_id_tiempo_proceso");

                entity.Property(e => e.SerIdUnidadMedida).HasColumnName("ser_id_unidad_medida");

                entity.Property(e => e.SerLaboratorio).HasColumnName("ser_laboratorio");

                entity.Property(e => e.SerLineaNegocio).HasColumnName("ser_linea_negocio");

                entity.Property(e => e.SerMargen).HasColumnName("ser_margen");

                entity.Property(e => e.SerMetodo).HasColumnName("ser_metodo");

                entity.Property(e => e.SerMontoPrecioUnico).HasColumnName("ser_monto_precio_unico");

                entity.Property(e => e.SerNivel).HasColumnName("ser_nivel");

                entity.Property(e => e.SerNumSerAnterior)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_num_ser_anterior");

                entity.Property(e => e.SerObservaciones)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_observaciones");

                entity.Property(e => e.SerParametroLab).HasColumnName("ser_parametro_lab");

                entity.Property(e => e.SerPaternidad).HasColumnName("ser_paternidad");

                entity.Property(e => e.SerPrecioUnico).HasColumnName("ser_precio_unico");

                entity.Property(e => e.SerProcesamiento).HasColumnName("ser_procesamiento");

                entity.Property(e => e.SerProyecto).HasColumnName("ser_proyecto");

                entity.Property(e => e.SerSubTituloLaboratorio)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_sub_titulo_laboratorio");

                entity.Property(e => e.SerSuizaOnline)
                    .HasColumnName("ser_suiza_online")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SerSuizaParnert).HasColumnName("ser_suiza_parnert");

                entity.Property(e => e.SerTempOptimaEnvio).HasColumnName("ser_temp_optima_envio");

                entity.Property(e => e.SerTiempoProceso)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_tiempo_proceso");

                entity.Property(e => e.SerTipoServicio).HasColumnName("ser_tipo_servicio");

                entity.Property(e => e.SerTipoTubo).HasColumnName("ser_tipo_tubo");

                entity.Property(e => e.SerUnidadNegocio).HasColumnName("ser_unidad_negocio");

                entity.Property(e => e.SerUnidadSegus).HasColumnName("ser_unidad_segus");

                entity.Property(e => e.SerUsuarioModif)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_usuario_modif");

                entity.Property(e => e.SerUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("ser_usuario_registro");

                entity.Property(e => e.SerVerWeb).HasColumnName("ser_ver_web");

                entity.HasOne(d => d.SerAreaNegocioNavigation)
                    .WithMany(p => p.MstServicios)
                    .HasForeignKey(d => d.SerAreaNegocio)
                    .HasConstraintName("servicio_area_negocio_fk");

                entity.HasOne(d => d.SerCentroCostoNegocioNavigation)
                    .WithMany(p => p.MstServicios)
                    .HasForeignKey(d => d.SerCentroCostoNegocio)
                    .HasConstraintName("servicio_centro_costo_negocio_fk");

                entity.HasOne(d => d.SerEquipoNavigation)
                    .WithMany(p => p.MstServicios)
                    .HasForeignKey(d => d.SerEquipo)
                    .HasConstraintName("servicio_equipo_fk");

                entity.HasOne(d => d.SerIdEspecialidadNavigation)
                    .WithMany(p => p.MstServicios)
                    .HasForeignKey(d => d.SerIdEspecialidad)
                    .HasConstraintName("servicio_ser_especialidad_fk");

                entity.HasOne(d => d.SerIdUnidadMedidaNavigation)
                    .WithMany(p => p.MstServicios)
                    .HasForeignKey(d => d.SerIdUnidadMedida)
                    .HasConstraintName("servicio_unidad_medida_fk");

                entity.HasOne(d => d.SerLineaNegocioNavigation)
                    .WithMany(p => p.MstServicios)
                    .HasForeignKey(d => d.SerLineaNegocio)
                    .HasConstraintName("servicio_linea_negocio_fk");

                entity.HasOne(d => d.SerMetodoNavigation)
                    .WithMany(p => p.MstServicios)
                    .HasForeignKey(d => d.SerMetodo)
                    .HasConstraintName("servicio_metodo_fk");

                entity.HasOne(d => d.SerProcesamientoNavigation)
                    .WithMany(p => p.MstServicios)
                    .HasForeignKey(d => d.SerProcesamiento)
                    .HasConstraintName("servicio_procesamiento_fk");

                entity.HasOne(d => d.SerProyectoNavigation)
                    .WithMany(p => p.MstServicios)
                    .HasForeignKey(d => d.SerProyecto)
                    .HasConstraintName("servicio_proyectolab_fk");

                entity.HasOne(d => d.SerTempOptimaEnvioNavigation)
                    .WithMany(p => p.MstServicios)
                    .HasForeignKey(d => d.SerTempOptimaEnvio)
                    .HasConstraintName("servicio_temperatura_fk");

                entity.HasOne(d => d.SerTipoServicioNavigation)
                    .WithMany(p => p.MstServicios)
                    .HasForeignKey(d => d.SerTipoServicio)
                    .HasConstraintName("servicio_ser_tiposervicio_fk");

                entity.HasOne(d => d.SerTipoTuboNavigation)
                    .WithMany(p => p.MstServicios)
                    .HasForeignKey(d => d.SerTipoTubo)
                    .HasConstraintName("servicio_ttubo_fk");

                entity.HasOne(d => d.SerUnidadNegocioNavigation)
                    .WithMany(p => p.MstServicios)
                    .HasForeignKey(d => d.SerUnidadNegocio)
                    .HasConstraintName("servicio_unidad_negocio_fk");
            });

            modelBuilder.Entity<MstServicioAreaNegocio>(entity =>
            {
                entity.HasKey(e => e.SeaId)
                    .HasName("TIP_SERVICIO_AREA_LABORATORIO_pkey");

                entity.ToTable("MST_SERVICIO_AREA_NEGOCIO", "suizasoft");

                entity.HasIndex(e => e.SeaCentroCostoId, "IX_MST_SERVICIO_AREA_NEGOCIO_sea_centro_costo_id");

                entity.Property(e => e.SeaId).HasColumnName("sea_id");

                entity.Property(e => e.SeaAbreviaturaCodigo)
                    .HasMaxLength(3)
                    .HasColumnName("sea_abreviatura_codigo");

                entity.Property(e => e.SeaCentroCostoId).HasColumnName("sea_centro_costo_id");

                entity.Property(e => e.SeaDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("sea_descripcion");

                entity.Property(e => e.SeaEstado).HasColumnName("sea_estado");

                entity.Property(e => e.SeaSoFlagMostrar).HasColumnName("sea_so_flag_mostrar");

                entity.Property(e => e.SeaSoImageUrl)
                    .HasColumnType("character varying")
                    .HasColumnName("sea_so_image_url");

                entity.Property(e => e.SeaSoNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("sea_so_nombre");

                entity.HasOne(d => d.SeaCentroCosto)
                    .WithMany(p => p.MstServicioAreaNegocios)
                    .HasForeignKey(d => d.SeaCentroCostoId)
                    .HasConstraintName("MST_SERVICIO_ARE_NEGOCIO_CENTRO_COSTO_fkey_id");
            });

            modelBuilder.Entity<MstServicioIncor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MST_SERVICIO_INCOR", "suizasoft");

                entity.Property(e => e.SerIncorCodigo)
                    .HasMaxLength(50)
                    .HasColumnName("ser_incor_codigo");

                entity.Property(e => e.SerIncorEstado)
                    .IsRequired()
                    .HasColumnName("ser_incor_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SerIncorNombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ser_incor_nombre");

                entity.Property(e => e.SerSlFox)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ser_sl_fox");

                entity.Property(e => e.SerSlNombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ser_sl_nombre");
            });

            modelBuilder.Entity<MstSexo>(entity =>
            {
                entity.HasKey(e => e.SexId)
                    .HasName("MST_SEXO_pkey");

                entity.ToTable("MST_SEXO", "suizasoft");

                entity.Property(e => e.SexId).HasColumnName("sex_id");

                entity.Property(e => e.SexAbreviatura)
                    .HasMaxLength(1)
                    .HasColumnName("sex_abreviatura");

                entity.Property(e => e.SexDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("sex_descripcion");
            });

            modelBuilder.Entity<MstSistema>(entity =>
            {
                entity.HasKey(e => e.SisId)
                    .HasName("MST_SISTEMA_pkey");

                entity.ToTable("MST_SISTEMA", "suizasoft");

                entity.Property(e => e.SisId).HasColumnName("sis_id");

                entity.Property(e => e.SisActivo)
                    .HasColumnName("sis_activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SisContrasenia)
                    .HasMaxLength(100)
                    .HasColumnName("sis_contrasenia");

                entity.Property(e => e.SisDescripcion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("sis_descripcion");

                entity.Property(e => e.SisFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("sis_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SisFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("sis_fecha_modificacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SisNombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("sis_nombre");

                entity.Property(e => e.SisNombreCorto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sis_nombre_corto");

                entity.Property(e => e.SisTsiId).HasColumnName("sis_tsi_id");

                entity.Property(e => e.SisUrl)
                    .HasMaxLength(500)
                    .HasColumnName("sis_url");

                entity.Property(e => e.SisUsuIdCreacion).HasColumnName("sis_usu_id_creacion");

                entity.Property(e => e.SisUsuIdModificacion).HasColumnName("sis_usu_id_modificacion");

                entity.Property(e => e.SisUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("sis_usuario");

                entity.Property(e => e.SisVersion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("sis_version");
            });

            modelBuilder.Entity<MstSucursal>(entity =>
            {
                entity.HasKey(e => e.SucId)
                    .HasName("MST_SUCURSAL_pkey");

                entity.ToTable("MST_SUCURSAL", "suizasoft");

                entity.Property(e => e.SucId)
                    .HasMaxLength(2)
                    .HasColumnName("suc_id");

                entity.Property(e => e.SucCodigoSap)
                    .HasColumnType("character varying")
                    .HasColumnName("suc_codigo_sap");

                entity.Property(e => e.SucCodigoSucursal)
                    .HasColumnType("character varying")
                    .HasColumnName("suc_codigo_sucursal");

                entity.Property(e => e.SucDireccion)
                    .HasColumnType("character varying")
                    .HasColumnName("suc_direccion");

                entity.Property(e => e.SucEnvioSap).HasColumnName("suc_envio_sap");

                entity.Property(e => e.SucEstado).HasColumnName("suc_estado");

                entity.Property(e => e.SucFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("suc_fecha_modificacion");

                entity.Property(e => e.SucFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("suc_fecha_registro");

                entity.Property(e => e.SucNombreCorto)
                    .HasColumnType("character varying")
                    .HasColumnName("suc_nombre_corto");

                entity.Property(e => e.SucNombreLargo)
                    .HasColumnType("character varying")
                    .HasColumnName("suc_nombre_largo");

                entity.Property(e => e.SucTelefono)
                    .HasColumnType("character varying")
                    .HasColumnName("suc_telefono");

                entity.Property(e => e.SucUbigeo)
                    .HasColumnType("character varying")
                    .HasColumnName("suc_ubigeo");

                entity.Property(e => e.SucUsuarioModificacion).HasColumnName("suc_usuario_modificacion");

                entity.Property(e => e.SucUsuarioRegistro).HasColumnName("suc_usuario_registro");
            });

            modelBuilder.Entity<MstSucursalModalidad>(entity =>
            {
                entity.HasKey(e => e.SumId)
                    .HasName("MST_SUCURSAL_MODALIDAD_pkey");

                entity.ToTable("MST_SUCURSAL_MODALIDAD", "suizasoft");

                entity.HasIndex(e => e.SumIdModalidad, "IX_MST_SUCURSAL_MODALIDAD_sum_id_modalidad");

                entity.HasIndex(e => e.SumIdSucursal, "IX_MST_SUCURSAL_MODALIDAD_sum_id_sucursal");

                entity.Property(e => e.SumId).HasColumnName("sum_id");

                entity.Property(e => e.SucEstado).HasColumnName("suc_estado");

                entity.Property(e => e.SucFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("suc_fecha_modificacion");

                entity.Property(e => e.SucFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("suc_fecha_registro");

                entity.Property(e => e.SucUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("suc_usuario_modificacion");

                entity.Property(e => e.SucUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("suc_usuario_registro");

                entity.Property(e => e.SumIdModalidad).HasColumnName("sum_id_modalidad");

                entity.Property(e => e.SumIdSucursal)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("sum_id_sucursal");

                entity.HasOne(d => d.SumIdModalidadNavigation)
                    .WithMany(p => p.MstSucursalModalidads)
                    .HasForeignKey(d => d.SumIdModalidad)
                    .HasConstraintName("MST_SUCURSAL_MODALIDAD_MODALIDAD_fk");

                entity.HasOne(d => d.SumIdSucursalNavigation)
                    .WithMany(p => p.MstSucursalModalidads)
                    .HasForeignKey(d => d.SumIdSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_SUCURSAL_MODALIDAD_SUCURSAL_fk");
            });

            modelBuilder.Entity<MstTarifario>(entity =>
            {
                entity.HasKey(e => e.TarId)
                    .HasName("MST_TARIFARIO_pkey");

                entity.ToTable("MST_TARIFARIO", "suizasoft");

                entity.HasIndex(e => e.TarIdModalidad, "IX_MST_TARIFARIO_tar_id_modalidad");

                entity.Property(e => e.TarId).HasColumnName("tar_id");

                entity.Property(e => e.TarCodigoAnterior)
                    .HasColumnType("character varying")
                    .HasColumnName("tar_codigo_anterior");

                entity.Property(e => e.TarDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("tar_descripcion");

                entity.Property(e => e.TarEstado)
                    .HasColumnName("tar_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TarFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tar_fecha_modificacion");

                entity.Property(e => e.TarFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tar_fecha_registro");

                entity.Property(e => e.TarIdModalidad).HasColumnName("tar_id_modalidad");

                entity.Property(e => e.TarObservacion)
                    .HasColumnType("character varying")
                    .HasColumnName("tar_observacion");

                entity.Property(e => e.TarUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("tar_usuario_modificacion");

                entity.Property(e => e.TarUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("tar_usuario_registro");

                entity.HasOne(d => d.TarIdModalidadNavigation)
                    .WithMany(p => p.MstTarifarios)
                    .HasForeignKey(d => d.TarIdModalidad)
                    .HasConstraintName("tarifario_modalidad_fk");
            });

            modelBuilder.Entity<MstTarifarioCategorium>(entity =>
            {
                entity.HasKey(e => new { e.TacIdTarifa, e.TacIdServicio })
                    .HasName("MST_TARIFARIO_CATEGORIA_pkey");

                entity.ToTable("MST_TARIFARIO_CATEGORIA", "suizasoft");

                entity.HasIndex(e => e.TacIdServicio, "IX_MST_TARIFARIO_CATEGORIA_tac_id_servicio");

                entity.Property(e => e.TacIdTarifa).HasColumnName("tac_id_tarifa");

                entity.Property(e => e.TacIdServicio).HasColumnName("tac_id_servicio");

                entity.Property(e => e.TacEstado).HasColumnName("tac_estado");

                entity.Property(e => e.TacFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tac_fecha_modificacion");

                entity.Property(e => e.TacFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tac_fecha_registro");

                entity.Property(e => e.TacObservacion)
                    .HasColumnType("character varying")
                    .HasColumnName("tac_observacion");

                entity.Property(e => e.TacPretarifa)
                    .HasPrecision(13, 2)
                    .HasColumnName("tac_pretarifa");

                entity.Property(e => e.TacTarifa)
                    .HasMaxLength(3)
                    .HasColumnName("tac_tarifa")
                    .IsFixedLength();

                entity.Property(e => e.TacUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("tac_usuario_modificacion");

                entity.Property(e => e.TacUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("tac_usuario_registro");

                entity.Property(e => e.TacValorUnitarioSinigv)
                    .HasPrecision(13, 2)
                    .HasColumnName("tac_valor_unitario_sinigv");

                entity.HasOne(d => d.TacIdServicioNavigation)
                    .WithMany(p => p.MstTarifarioCategoria)
                    .HasForeignKey(d => d.TacIdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tarifa_categoria_servicio_fk");

                entity.HasOne(d => d.TacIdTarifaNavigation)
                    .WithMany(p => p.MstTarifarioCategoria)
                    .HasForeignKey(d => d.TacIdTarifa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tarifariocategoria_tarifario_fk");
            });

            modelBuilder.Entity<MstTarifarioPaquete>(entity =>
            {
                entity.HasKey(e => new { e.TapIdTarifa, e.TapIdPaquete })
                    .HasName("MST_TARIFARIO_PAQUETE_pkey");

                entity.ToTable("MST_TARIFARIO_PAQUETE", "suizasoft");

                entity.HasIndex(e => e.TapIdPaquete, "IX_MST_TARIFARIO_PAQUETE_tap_id_paquete");

                entity.Property(e => e.TapIdTarifa).HasColumnName("tap_id_tarifa");

                entity.Property(e => e.TapIdPaquete).HasColumnName("tap_id_paquete");

                entity.Property(e => e.TapEstado).HasColumnName("tap_estado");

                entity.Property(e => e.TapFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tap_fecha_modificacion");

                entity.Property(e => e.TapFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tap_fecha_registro");

                entity.Property(e => e.TapObservacion)
                    .HasColumnType("character varying")
                    .HasColumnName("tap_observacion");

                entity.Property(e => e.TapPretarifa)
                    .HasPrecision(13, 2)
                    .HasColumnName("tap_pretarifa");

                entity.Property(e => e.TapTarifa)
                    .HasMaxLength(3)
                    .HasColumnName("tap_tarifa")
                    .IsFixedLength();

                entity.Property(e => e.TapUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("tap_usuario_modificacion");

                entity.Property(e => e.TapUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("tap_usuario_registro");

                entity.Property(e => e.TapValorUnitarioSinigv)
                    .HasPrecision(13, 2)
                    .HasColumnName("tap_valor_unitario_sinigv");

                entity.HasOne(d => d.TapIdPaqueteNavigation)
                    .WithMany(p => p.MstTarifarioPaquetes)
                    .HasForeignKey(d => d.TapIdPaquete)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tarifa_paquete_fk");

                entity.HasOne(d => d.TapIdTarifaNavigation)
                    .WithMany(p => p.MstTarifarioPaquetes)
                    .HasForeignKey(d => d.TapIdTarifa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tarifario_paquete_tarifario_fk");
            });

            modelBuilder.Entity<MstTarifarioPerfil>(entity =>
            {
                entity.HasKey(e => new { e.TapIdTarifa, e.TapIdPerfil })
                    .HasName("MST_TARIFARIO_PERFIL_pkey");

                entity.ToTable("MST_TARIFARIO_PERFIL", "suizasoft");

                entity.HasIndex(e => e.TapIdPerfil, "IX_MST_TARIFARIO_PERFIL_tap_id_perfil");

                entity.Property(e => e.TapIdTarifa).HasColumnName("tap_id_tarifa");

                entity.Property(e => e.TapIdPerfil).HasColumnName("tap_id_perfil");

                entity.Property(e => e.TapEstado).HasColumnName("tap_estado");

                entity.Property(e => e.TapFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tap_fecha_modificacion");

                entity.Property(e => e.TapFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tap_fecha_registro");

                entity.Property(e => e.TapObservacion)
                    .HasColumnType("character varying")
                    .HasColumnName("tap_observacion");

                entity.Property(e => e.TapPretarifa)
                    .HasPrecision(13, 2)
                    .HasColumnName("tap_pretarifa");

                entity.Property(e => e.TapTarifa)
                    .HasMaxLength(3)
                    .HasColumnName("tap_tarifa")
                    .IsFixedLength();

                entity.Property(e => e.TapUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("tap_usuario_modificacion");

                entity.Property(e => e.TapUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("tap_usuario_registro");

                entity.Property(e => e.TapValorUnitarioSinigv)
                    .HasPrecision(13, 2)
                    .HasColumnName("tap_valor_unitario_sinigv");

                entity.HasOne(d => d.TapIdPerfilNavigation)
                    .WithMany(p => p.MstTarifarioPerfils)
                    .HasForeignKey(d => d.TapIdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tarifaperfil_perfil_fk");

                entity.HasOne(d => d.TapIdTarifaNavigation)
                    .WithMany(p => p.MstTarifarioPerfils)
                    .HasForeignKey(d => d.TapIdTarifa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tarifarioperfil_tarifario_fk");
            });

            modelBuilder.Entity<MstTiempoProceso>(entity =>
            {
                entity.HasKey(e => new { e.TprId, e.TprDescripcion })
                    .HasName("MST_TIEMPO_PROCESO_pkey");

                entity.ToTable("MST_TIEMPO_PROCESO", "suizasoft");

                entity.Property(e => e.TprId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("tpr_id");

                entity.Property(e => e.TprDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("tpr_descripcion");
            });

            modelBuilder.Entity<MstTipoCambio>(entity =>
            {
                entity.HasKey(e => e.TicFecha)
                    .HasName("PK_MST_TIPOCAMBIO");

                entity.ToTable("MST_TIPO_CAMBIO", "suizasoft");

                entity.Property(e => e.TicFecha).HasColumnName("tic_fecha");

                entity.Property(e => e.TicCompra)
                    .HasPrecision(13, 3)
                    .HasColumnName("tic_compra");

                entity.Property(e => e.TicFecharegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tic_fecharegistro")
                    .HasDefaultValueSql("(CURRENT_TIMESTAMP(0))::timestamp without time zone");

                entity.Property(e => e.TicUsuarioregistro)
                    .HasMaxLength(20)
                    .HasColumnName("tic_usuarioregistro");

                entity.Property(e => e.TicVenta)
                    .HasPrecision(13, 3)
                    .HasColumnName("tic_venta");
            });

            modelBuilder.Entity<MstTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.TdoId)
                    .HasName("MST_TIPO_DOCUMENTO_pkey");

                entity.ToTable("MST_TIPO_DOCUMENTO", "suizasoft");

                entity.Property(e => e.TdoId).HasColumnName("tdo_id");

                entity.Property(e => e.TdoEstado)
                    .IsRequired()
                    .HasColumnName("tdo_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TdoFeCodDoc).HasColumnName("tdo_fe_cod_doc");

                entity.Property(e => e.TdoNombreCorto)
                    .HasMaxLength(15)
                    .HasColumnName("tdo_nombre_corto");

                entity.Property(e => e.TdoNombreDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tdo_nombre_documento");

                entity.Property(e => e.TdoUsumod)
                    .HasMaxLength(100)
                    .HasColumnName("tdo_usumod");
            });

            modelBuilder.Entity<MstTipoDocumentoVentum>(entity =>
            {
                entity.HasKey(e => e.TdvId)
                    .HasName("MST_TIPO_DOCUMENTO_VENTA_pkey");

                entity.ToTable("MST_TIPO_DOCUMENTO_VENTA", "suizasoft");

                entity.Property(e => e.TdvId)
                    .ValueGeneratedNever()
                    .HasColumnName("tdv_id");

                entity.Property(e => e.TdvEstado).HasColumnName("tdv_estado");

                entity.Property(e => e.TdvNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("tdv_nombre");

                entity.Property(e => e.TdvNombreCorto)
                    .HasColumnType("character varying")
                    .HasColumnName("tdv_nombre_corto");
            });

            modelBuilder.Entity<MstTipoEvaluacion>(entity =>
            {
                entity.HasKey(e => e.TieId)
                    .HasName("MST_TIPO_EVALUACION_pkey");

                entity.ToTable("MST_TIPO_EVALUACION", "suizasoft");

                entity.Property(e => e.TieId).HasColumnName("tie_id");

                entity.Property(e => e.TieDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("tie_descripcion");

                entity.Property(e => e.TieEstado).HasColumnName("tie_estado");
            });

            modelBuilder.Entity<MstTipoLaboratorio>(entity =>
            {
                entity.HasKey(e => e.TipId)
                    .HasName("MST_TIPO_LABORATORIO_pkey");

                entity.ToTable("MST_TIPO_LABORATORIO", "suizasoft");

                entity.HasIndex(e => e.TipAreId, "IX_MST_TIPO_LABORATORIO_tip_are_id");

                entity.Property(e => e.TipId)
                    .ValueGeneratedNever()
                    .HasColumnName("tip_id");

                entity.Property(e => e.TipAreId).HasColumnName("tip_are_id");

                entity.Property(e => e.TipDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("tip_descripcion");

                entity.Property(e => e.TipEstado).HasColumnName("tip_estado");

                entity.HasOne(d => d.TipAre)
                    .WithMany(p => p.MstTipoLaboratorios)
                    .HasForeignKey(d => d.TipAreId)
                    .HasConstraintName("tipolaboratorio_tip_are_id_fk");
            });

            modelBuilder.Entity<MstTipoModalidad>(entity =>
            {
                entity.HasKey(e => e.TmoId)
                    .HasName("MST_TIPO_MODALIDAD_pkey");

                entity.ToTable("MST_TIPO_MODALIDAD", "suizasoft");

                entity.HasIndex(e => e.TmoIdModalidad, "IX_MST_TIPO_MODALIDAD_tmo_id_modalidad");

                entity.Property(e => e.TmoId)
                    .HasMaxLength(4)
                    .HasColumnName("tmo_id")
                    .IsFixedLength();

                entity.Property(e => e.TmoCodigoAnterior)
                    .HasMaxLength(3)
                    .HasColumnName("tmo_codigo_anterior")
                    .IsFixedLength();

                entity.Property(e => e.TmoDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("tmo_descripcion");

                entity.Property(e => e.TmoEstado).HasColumnName("tmo_estado");

                entity.Property(e => e.TmoIdModalidad).HasColumnName("tmo_id_modalidad");

                entity.HasOne(d => d.TmoIdModalidadNavigation)
                    .WithMany(p => p.MstTipoModalidads)
                    .HasForeignKey(d => d.TmoIdModalidad)
                    .HasConstraintName("MST_TIPO_MODALIDAD_tmo_id_modalidad_fkey");
            });

            modelBuilder.Entity<MstTipoPago>(entity =>
            {
                entity.HasKey(e => e.TpaId)
                    .HasName("MST_TIPO_PAGO_pkey");

                entity.ToTable("MST_TIPO_PAGO", "suizasoft");

                entity.Property(e => e.TpaId)
                    .ValueGeneratedNever()
                    .HasColumnName("tpa_id");

                entity.Property(e => e.TpaDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("tpa_descripcion ");
            });

            modelBuilder.Entity<MstTipoServicioLaboratorio>(entity =>
            {
                entity.HasKey(e => e.TisId)
                    .HasName("MST_TIPO_SERVICIO_LABORATORIO_pkey");

                entity.ToTable("MST_TIPO_SERVICIO_LABORATORIO", "suizasoft");

                entity.Property(e => e.TisId).HasColumnName("tis_id");

                entity.Property(e => e.TipEstado).HasColumnName("tip_estado");

                entity.Property(e => e.TisDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("tis_descripcion");
            });

            modelBuilder.Entity<MstTipoSistema>(entity =>
            {
                entity.HasKey(e => e.TsiId)
                    .HasName("MST_TIPO_SISTEMA_pkey");

                entity.ToTable("MST_TIPO_SISTEMA", "suizasoft");

                entity.Property(e => e.TsiId).HasColumnName("tsi_id");

                entity.Property(e => e.TsiDescripcion)
                    .HasMaxLength(100)
                    .HasColumnName("tsi_descripcion");

                entity.Property(e => e.TsiFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tsi_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsiFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tsi_fecha_modificacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TsiNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tsi_nombre");

                entity.Property(e => e.TsiUsuarioCreacion).HasColumnName("tsi_usuario_creacion");

                entity.Property(e => e.TsiUsuarioModificacion).HasColumnName("tsi_usuario_modificacion");
            });

            modelBuilder.Entity<MstTipoVentum>(entity =>
            {
                entity.HasKey(e => e.TveId)
                    .HasName("MST_TIPO_VENTA_pkey");

                entity.ToTable("MST_TIPO_VENTA", "suizasoft");

                entity.Property(e => e.TveId)
                    .ValueGeneratedNever()
                    .HasColumnName("tve_id");

                entity.Property(e => e.TveCodigoAnterior)
                    .HasColumnType("character varying")
                    .HasColumnName("tve_codigo_anterior");

                entity.Property(e => e.TveDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("tve_descripcion");

                entity.Property(e => e.TveEstado).HasColumnName("tve_estado");
            });

            modelBuilder.Entity<MstTokenPaciente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mst_token_paciente", "suizasoft");

                entity.Property(e => e.MtpFechaCreacion).HasColumnName("mtp_fecha_creacion");

                entity.Property(e => e.MtpFechaExpiracion).HasColumnName("mtp_fecha_expiracion");

                entity.Property(e => e.MtpId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("mtp_id")
                    .HasComment("pk");

                entity.Property(e => e.MtpPacId)
                    .HasColumnName("mtp_pac_id")
                    .HasComment("id_paciente");

                entity.Property(e => e.MtpRevoked).HasColumnName("mtp_revoked");

                entity.Property(e => e.MtpToken)
                    .HasColumnType("character varying")
                    .HasColumnName("mtp_token");

                entity.HasOne(d => d.MtpPac)
                    .WithMany()
                    .HasForeignKey(d => d.MtpPacId)
                    .HasConstraintName("mst_token_paciente_fk");
            });

            modelBuilder.Entity<MstTopicoEscaneo>(entity =>
            {
                entity.HasKey(e => e.ToeId)
                    .HasName("MST_TOPICO_ESCANEO_pkey");

                entity.ToTable("MST_TOPICO_ESCANEO", "suizasoft");

                entity.HasIndex(e => e.ToeIdTipoIngreso, "IX_MST_TOPICO_ESCANEO_toe_id_tipo_ingreso");

                entity.Property(e => e.ToeId).HasColumnName("toe_id");

                entity.Property(e => e.ToeDireccionIpRegistro)
                    .HasMaxLength(50)
                    .HasColumnName("toe_direccion_ip_registro");

                entity.Property(e => e.ToeFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("toe_fecha_creacion");

                entity.Property(e => e.ToeIdTipoIngreso).HasColumnName("toe_id_tipo_ingreso");

                entity.Property(e => e.ToeNombrePaciente)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("toe_nombre_paciente");

                entity.Property(e => e.ToeObservacion)
                    .HasMaxLength(200)
                    .HasColumnName("toe_observacion");

                entity.Property(e => e.ToeOrdenServicio)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("toe_orden_servicio");

                entity.Property(e => e.ToeUsuarioCreacion)
                    .HasMaxLength(20)
                    .HasColumnName("toe_usuario_creacion");

                entity.Property(e => e.ToeYearOrden)
                    .HasMaxLength(20)
                    .HasColumnName("toe_year_orden");

                entity.HasOne(d => d.ToeIdTipoIngresoNavigation)
                    .WithMany(p => p.MstTopicoEscaneos)
                    .HasForeignKey(d => d.ToeIdTipoIngreso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MST_TOPICO_ESCANEO_toe_id_tipo_ingreso_fkey");
            });

            modelBuilder.Entity<MstTramaDetDen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MST_TRAMA_DET_DEN", "suizasoft");

                entity.Property(e => e.DenC10SuperficieDentalDistal)
                    .HasMaxLength(1)
                    .HasColumnName("den_c10_superficie_dental_distal");

                entity.Property(e => e.DenC11SuperficieDentalVestib)
                    .HasMaxLength(1)
                    .HasColumnName("den_c11_superficie_dental_vestib");

                entity.Property(e => e.DenC12SuperficieDentalOclusal)
                    .HasMaxLength(1)
                    .HasColumnName("den_c12_superficie_dental_oclusal");

                entity.Property(e => e.DenC13SuperficieDentalTodapieza)
                    .HasMaxLength(1)
                    .HasColumnName("den_c13_superficie_dental_todapieza");

                entity.Property(e => e.DenC14SuperficieDentalPalatina)
                    .HasMaxLength(1)
                    .HasColumnName("den_c14_superficie_dental_palatina");

                entity.Property(e => e.DenC15SuperficieDentalCervical)
                    .HasMaxLength(1)
                    .HasColumnName("den_c15_superficie_dental_cervical");

                entity.Property(e => e.DenC16SuperficieDentalIncisal)
                    .HasMaxLength(1)
                    .HasColumnName("den_c16_superficie_dental_incisal");

                entity.Property(e => e.DenC1RucEmpresa)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("den_c1_ruc_empresa")
                    .IsFixedLength();

                entity.Property(e => e.DenC2CodigoIpress)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("den_c2_codigo_ipress")
                    .IsFixedLength();

                entity.Property(e => e.DenC3TipoDocpago)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("den_c3_tipo_docpago")
                    .IsFixedLength();

                entity.Property(e => e.DenC4NroDocpago)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("den_c4_nro_docpago")
                    .IsFixedLength();

                entity.Property(e => e.DenC5CorrelativoPrestac)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("den_c5_correlativo_prestac")
                    .IsFixedLength();

                entity.Property(e => e.DenC6CorrelativoServOdontolog)
                    .HasMaxLength(4)
                    .HasColumnName("den_c6_correlativo_serv_odontolog")
                    .IsFixedLength();

                entity.Property(e => e.DenC7CodigoPiezaDentaria)
                    .HasMaxLength(2)
                    .HasColumnName("den_c7_codigo_pieza_dentaria")
                    .IsFixedLength();

                entity.Property(e => e.DenC8SuperficieDentalMesial)
                    .HasMaxLength(1)
                    .HasColumnName("den_c8_superficie_dental_mesial");

                entity.Property(e => e.DenC9SuperficieDentalLingual)
                    .HasMaxLength(1)
                    .HasColumnName("den_c9_superficie_dental_lingual");

                entity.Property(e => e.DenCodFina)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("den_cod_fina")
                    .IsFixedLength();

                entity.Property(e => e.DenNroFactura)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("den_nro_factura")
                    .IsFixedLength();

                entity.Property(e => e.DenNumeroLote)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasColumnName("den_numero_lote")
                    .IsFixedLength();

                entity.Property(e => e.DenSerie)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("den_serie")
                    .IsFixedLength();
            });

            modelBuilder.Entity<MstTramaRuc>(entity =>
            {
                entity.HasKey(e => e.TrmRucEmpresa)
                    .HasName("MST_TRAMA_RUC_pkey");

                entity.ToTable("MST_TRAMA_RUC", "suizasoft");

                entity.Property(e => e.TrmRucEmpresa)
                    .HasMaxLength(11)
                    .HasColumnName("trm_ruc_empresa")
                    .IsFixedLength();

                entity.Property(e => e.TrmCodFina)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("trm_cod_fina")
                    .IsFixedLength();

                entity.Property(e => e.TrmFlagSuizalab).HasColumnName("trm_flag_suizalab");

                entity.Property(e => e.TrmFlagSuizalert).HasColumnName("trm_flag_suizalert");

                entity.Property(e => e.TrmId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("trm_id");
            });

            modelBuilder.Entity<MstTransaccione>(entity =>
            {
                entity.HasKey(e => e.TraId)
                    .HasName("MST_TRANSACCIONES_pkey");

                entity.ToTable("MST_TRANSACCIONES", "suizasoft");

                entity.Property(e => e.TraId).HasColumnName("tra_id");

                entity.Property(e => e.TraEstado)
                    .HasMaxLength(1)
                    .HasColumnName("tra_estado")
                    .HasDefaultValueSql("'C'::bpchar");

                entity.Property(e => e.TraFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tra_fecha_creacion");

                entity.Property(e => e.TraMonto)
                    .HasPrecision(13, 2)
                    .HasColumnName("tra_monto");

                entity.Property(e => e.TraNumeroTransaccion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("tra_numero_transaccion");

                entity.Property(e => e.TraTicket)
                    .HasMaxLength(15)
                    .HasColumnName("tra_ticket");
            });

            modelBuilder.Entity<MstUbigeo>(entity =>
            {
                entity.HasKey(e => e.UbiId)
                    .HasName("ubi_id_pk");

                entity.ToTable("MST_UBIGEO", "suizasoft");

                entity.Property(e => e.UbiId).HasColumnName("ubi_id");

                entity.Property(e => e.UbiCodigoDepartamento)
                    .HasColumnType("character varying")
                    .HasColumnName("ubi_codigo_departamento");

                entity.Property(e => e.UbiCodigoDistrito)
                    .HasColumnType("character varying")
                    .HasColumnName("ubi_codigo_distrito");

                entity.Property(e => e.UbiCodigoProvincia)
                    .HasColumnType("character varying")
                    .HasColumnName("ubi_codigo_provincia");

                entity.Property(e => e.UbiEstado).HasColumnName("ubi_estado");

                entity.Property(e => e.UbiNombreDepartamento)
                    .HasColumnType("character varying")
                    .HasColumnName("ubi_nombre_departamento");

                entity.Property(e => e.UbiNombreDistrito)
                    .HasColumnType("character varying")
                    .HasColumnName("ubi_nombre_distrito");

                entity.Property(e => e.UbiNombreProvincia)
                    .HasColumnType("character varying")
                    .HasColumnName("ubi_nombre_provincia");
            });

            modelBuilder.Entity<MstUnidadNegocio>(entity =>
            {
                entity.HasKey(e => e.UniId)
                    .HasName("MST_UNIDAD_NEGOCIO_pkey");

                entity.ToTable("MST_UNIDAD_NEGOCIO", "suizasoft");

                entity.Property(e => e.UniId).HasColumnName("uni_id");

                entity.Property(e => e.UniDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("uni_descripcion");

                entity.Property(e => e.UniEstado).HasColumnName("uni_estado");
            });

            modelBuilder.Entity<MstUsuario>(entity =>
            {
                entity.HasKey(e => e.UsuId)
                    .HasName("usu_id_pk");

                entity.ToTable("MST_USUARIO", "suizasoft");

                entity.Property(e => e.UsuId).HasColumnName("usu_id");

                entity.Property(e => e.UsuApellido)
                    .HasColumnType("character varying")
                    .HasColumnName("usu_apellido");

                entity.Property(e => e.UsuEstado).HasColumnName("usu_estado");

                entity.Property(e => e.UsuFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("usu_fecha_creacion");

                entity.Property(e => e.UsuFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("usu_fecha_modificacion");

                entity.Property(e => e.UsuNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("usu_nombre");

                entity.Property(e => e.UsuUsuario)
                    .HasColumnType("character varying")
                    .HasColumnName("usu_usuario");

                entity.Property(e => e.UsuUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("usu_usuario_creacion");

                entity.Property(e => e.UsuUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("usu_usuario_modificacion");
            });

            modelBuilder.Entity<MstUsuarioOmd>(entity =>
            {
                entity.HasKey(e => e.UsuId)
                    .HasName("MST_USUARIO_OMD_pkey");

                entity.ToTable("MST_USUARIO_OMD", "suizasoft");

                entity.Property(e => e.UsuId).HasColumnName("usu_id");

                entity.Property(e => e.UsuFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("usu_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UsuFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("usu_fecha_modificacion");

                entity.Property(e => e.UsuMedId).HasColumnName("usu_med_id");

                entity.Property(e => e.UsuRolId).HasColumnName("usu_rol_id");
            });

            modelBuilder.Entity<MstUsuarioSeguro>(entity =>
            {
                entity.HasKey(e => e.UssId)
                    .HasName("MST_USUARIO_SEGUROS_pkey");

                entity.ToTable("MST_USUARIO_SEGUROS", "suizasoft");

                entity.HasIndex(e => e.UssCorreo, "MST_USUARIO_SEGUROS_CORREO_unique")
                    .IsUnique();

                entity.Property(e => e.UssId).HasColumnName("uss_id");

                entity.Property(e => e.UssContrasena)
                    .HasColumnType("character varying")
                    .HasColumnName("uss_contrasena");

                entity.Property(e => e.UssCorreo)
                    .HasColumnType("character varying")
                    .HasColumnName("uss_correo");

                entity.Property(e => e.UssEstado)
                    .HasColumnName("uss_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UssFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("uss_fecha_modificacion");

                entity.Property(e => e.UssFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("uss_fecha_registro");

                entity.Property(e => e.UssNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("uss_nombre");

                entity.Property(e => e.UssPerfil).HasColumnName("uss_perfil");

                entity.Property(e => e.UssRefreshToken)
                    .HasColumnType("character varying")
                    .HasColumnName("uss_refreshToken");

                entity.Property(e => e.UssUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("uss_usuario_modificacion");

                entity.Property(e => e.UssUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("uss_usuario_registro");
            });

            modelBuilder.Entity<MstUsuarioSerie>(entity =>
            {
                entity.HasKey(e => e.UseId)
                    .HasName("MST_USUARIO_SERIE_pkey");

                entity.ToTable("MST_USUARIO_SERIE", "suizasoft");

                entity.HasIndex(e => e.UseIdAgenteSerie, "IX_MST_USUARIO_SERIE_use_id_agente_serie");

                entity.HasIndex(e => new { e.UseUid, e.UseIdAgenteSerie }, "MST_USUARIO_SERIE_use_uid_use_id_agente_serie_key")
                    .IsUnique();

                entity.Property(e => e.UseId).HasColumnName("use_id");

                entity.Property(e => e.UseEstado).HasColumnName("use_estado");

                entity.Property(e => e.UseFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("use_fecha_creacion");

                entity.Property(e => e.UseFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("use_fecha_modificacion");

                entity.Property(e => e.UseIdAgenteSerie).HasColumnName("use_id_agente_serie");

                entity.Property(e => e.UseUid)
                    .HasColumnType("character varying")
                    .HasColumnName("use_uid");

                entity.Property(e => e.UseUsername)
                    .HasColumnType("character varying")
                    .HasColumnName("use_username");

                entity.Property(e => e.UseUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("use_usuario_creacion");

                entity.Property(e => e.UseUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("use_usuario_modificacion");

                entity.HasOne(d => d.UseIdAgenteSerieNavigation)
                    .WithMany(p => p.MstUsuarioSeries)
                    .HasForeignKey(d => d.UseIdAgenteSerie)
                    .HasConstraintName("MST_USUARIO_SERIE_use_id_agente_serie_fkey");
            });

            modelBuilder.Entity<MstUsuariosGrupo>(entity =>
            {
                entity.HasKey(e => e.UsgIdGrupo)
                    .HasName("MST_USUARIOS_GRUPO_pkey");

                entity.ToTable("MST_USUARIOS_GRUPO", "suizasoft");

                entity.Property(e => e.UsgIdGrupo)
                    .ValueGeneratedNever()
                    .HasColumnName("usg_id_grupo");

                entity.Property(e => e.UsgEstado).HasColumnName("usg_estado");

                entity.Property(e => e.UsgFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("usg_fecha_modificacion");

                entity.Property(e => e.UsgFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("usg_fecha_registro");

                entity.Property(e => e.UsgIdUsuario).HasColumnName("usg_id_usuario");

                entity.Property(e => e.UsgUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("usg_usuario_modificacion");

                entity.Property(e => e.UsgUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("usg_usuario_registro");
            });

            modelBuilder.Entity<MstUsuariosSuizaPartner>(entity =>
            {
                entity.ToTable("MST_USUARIOS_SUIZA_PARTNER", "suizasoft");

                entity.HasIndex(e => e.Email, "UQ_f2ebfa43f634a65e27e404979dd")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("fullName");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.Roles)
                    .IsRequired()
                    .HasColumnName("roles")
                    .HasDefaultValueSql("'{user}'::text[]");
            });

            modelBuilder.Entity<PCountExa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("p_count_exa");

                entity.Property(e => e.Count).HasColumnName("count");
            });

            modelBuilder.Entity<PCountSiEstaValidado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("p_count_si_esta_validado");

                entity.Property(e => e.Count).HasColumnName("count");
            });

            modelBuilder.Entity<PEsperfilOServicio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("p_esperfil_o_servicio");

                entity.Property(e => e.Case).HasColumnName("case");
            });

            modelBuilder.Entity<PEsperfilOServicio1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("p_esperfil_o_servicio", "suizasoft");

                entity.Property(e => e.Case).HasColumnName("case");
            });

            modelBuilder.Entity<PTotalRegistro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("p_total_registros");

                entity.Property(e => e.Count).HasColumnName("count");
            });

            modelBuilder.Entity<ResAntibiograma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("res_antibiograma");

                entity.Property(e => e.JsonAgg)
                    .HasColumnType("json")
                    .HasColumnName("json_agg");
            });

            modelBuilder.Entity<ScCitum>(entity =>
            {
                entity.HasKey(e => e.CitId)
                    .HasName("SC_CITA_pkey");

                entity.ToTable("SC_CITA", "suizasoft");

                entity.Property(e => e.CitId).HasColumnName("cit_id");

                entity.Property(e => e.CitCchId).HasColumnName("cit_cch_id");

                entity.Property(e => e.CitCodigo)
                    .HasColumnType("character varying")
                    .HasColumnName("cit_codigo");

                entity.Property(e => e.CitEstado).HasColumnName("cit_estado");

                entity.Property(e => e.CitFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cit_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CitPacId).HasColumnName("cit_pac_id");

                entity.HasOne(d => d.CitCch)
                    .WithMany(p => p.ScCita)
                    .HasForeignKey(d => d.CitCchId)
                    .HasConstraintName("fk_cita_cupo_hoario");

                entity.HasOne(d => d.CitCchNavigation)
                    .WithMany(p => p.ScCita)
                    .HasForeignKey(d => d.CitCchId)
                    .HasConstraintName("fk_cita_paciente");
            });

            modelBuilder.Entity<ScCupoHorario>(entity =>
            {
                entity.HasKey(e => e.CchId)
                    .HasName("SC_CUPO_HORARIO_pkey");

                entity.ToTable("SC_CUPO_HORARIO", "suizasoft");

                entity.Property(e => e.CchId)
                    .ValueGeneratedNever()
                    .HasColumnName("cch_id");

                entity.Property(e => e.CchFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cch_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CchHoraFin).HasColumnName("cch_hora_fin");

                entity.Property(e => e.CchHoraInicio).HasColumnName("cch_hora_inicio");

                entity.Property(e => e.CchMinutosAtencion).HasColumnName("cch_minutos_atencion");

                entity.Property(e => e.CchPfsId).HasColumnName("cch_pfs_id");

                entity.Property(e => e.CchReservado)
                    .HasColumnName("cch_reservado")
                    .HasDefaultValueSql("false");

                entity.HasOne(d => d.CchPfs)
                    .WithMany(p => p.ScCupoHorarios)
                    .HasForeignKey(d => d.CchPfsId)
                    .HasConstraintName("fk_cupo_horario_pogramacion_fecha_servicio");
            });

            modelBuilder.Entity<ScProgramacionFecha>(entity =>
            {
                entity.HasKey(e => e.CpfId)
                    .HasName("SC_PROGRAMACION_FECHA_pkey");

                entity.ToTable("SC_PROGRAMACION_FECHA", "suizasoft");

                entity.Property(e => e.CpfId)
                    .ValueGeneratedNever()
                    .HasColumnName("cpf_id");

                entity.Property(e => e.CpfCpsId).HasColumnName("cpf_cps_id");

                entity.Property(e => e.CpfFecha).HasColumnName("cpf_fecha");

                entity.Property(e => e.CpfFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cpf_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CpfMdsId).HasColumnName("cpf_mds_id");

                entity.HasOne(d => d.CpfCps)
                    .WithMany(p => p.ScProgramacionFechas)
                    .HasForeignKey(d => d.CpfCpsId)
                    .HasConstraintName("fk_programacion_fecha_sucursal");

                entity.HasOne(d => d.CpfMds)
                    .WithMany(p => p.ScProgramacionFechas)
                    .HasForeignKey(d => d.CpfMdsId)
                    .HasConstraintName("fk_programacion_fecha_dia_semana");
            });

            modelBuilder.Entity<ScProgramacionFechaServicio>(entity =>
            {
                entity.HasKey(e => e.PfsId)
                    .HasName("SC_PROGRAMACION_FECHA_SERVICIO_pkey");

                entity.ToTable("SC_PROGRAMACION_FECHA_SERVICIO", "suizasoft");

                entity.Property(e => e.PfsId)
                    .ValueGeneratedNever()
                    .HasColumnName("pfs_id");

                entity.Property(e => e.PfsCpfId).HasColumnName("pfs_cpf_id");

                entity.Property(e => e.PfsCupoCantidad).HasColumnName("pfs_cupo_cantidad");

                entity.Property(e => e.PfsFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pfs_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PfsMedId).HasColumnName("pfs_med_id");

                entity.Property(e => e.PfsSerCodigo).HasColumnName("pfs_ser_codigo");

                entity.HasOne(d => d.PfsCpf)
                    .WithMany(p => p.ScProgramacionFechaServicios)
                    .HasForeignKey(d => d.PfsCpfId)
                    .HasConstraintName("fk_programacion_fecha_servicio_fecha");

                entity.HasOne(d => d.PfsMed)
                    .WithMany(p => p.ScProgramacionFechaServicios)
                    .HasForeignKey(d => d.PfsMedId)
                    .HasConstraintName("fk_programacion_fecha_servicio_medico");

                entity.HasOne(d => d.PfsSerCodigoNavigation)
                    .WithMany(p => p.ScProgramacionFechaServicios)
                    .HasForeignKey(d => d.PfsSerCodigo)
                    .HasConstraintName("fk_programacion_fecha_servicio_servicio");
            });

            modelBuilder.Entity<ScProgramacionSucursal>(entity =>
            {
                entity.HasKey(e => e.CpsId)
                    .HasName("SC_PROGRAMACION_SUCURSAL_pkey");

                entity.ToTable("SC_PROGRAMACION_SUCURSAL", "suizasoft");

                entity.Property(e => e.CpsId)
                    .ValueGeneratedNever()
                    .HasColumnName("cps_id");

                entity.Property(e => e.CpsEstado)
                    .HasColumnName("cps_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CpsFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("cps_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CpsFechaFin).HasColumnName("cps_fecha_fin");

                entity.Property(e => e.CpsFechaInicio).HasColumnName("cps_fecha_inicio");

                entity.Property(e => e.CpsSucursalId)
                    .HasMaxLength(2)
                    .HasColumnName("cps_sucursal_id")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ScSubModalidad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SC_SUB_MODALIDAD", "suizasoft");

                entity.Property(e => e.CsmEstado)
                    .HasColumnName("csm_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CsmFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("csm_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CsmId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("csm_id");

                entity.Property(e => e.CsmTmoId)
                    .HasMaxLength(4)
                    .HasColumnName("csm_tmo_id")
                    .IsFixedLength();

                entity.HasOne(d => d.CsmTmo)
                    .WithMany()
                    .HasForeignKey(d => d.CsmTmoId)
                    .HasConstraintName("fk_sub_modalidad_tipo_modalidad");
            });

            modelBuilder.Entity<SoCitaComplemento>(entity =>
            {
                entity.HasKey(e => e.CcoId)
                    .HasName("SO_CITA_COMPLEMENTO_pkey");

                entity.ToTable("SO_CITA_COMPLEMENTO", "suizasoft");

                entity.Property(e => e.CcoId).HasColumnName("cco_id");

                entity.Property(e => e.CcoIdCita).HasColumnName("cco_id_cita");

                entity.Property(e => e.CcoIdComplemento).HasColumnName("cco_id_complemento");

                entity.HasOne(d => d.CcoIdCitaNavigation)
                    .WithMany(p => p.SoCitaComplementos)
                    .HasForeignKey(d => d.CcoIdCita)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SO_CITA_COMPLEMENTO_cco_id_cita_fkey");

                entity.HasOne(d => d.CcoIdComplementoNavigation)
                    .WithMany(p => p.SoCitaComplementos)
                    .HasForeignKey(d => d.CcoIdComplemento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SO_CITA_COMPLEMENTO_cco_id_complemento_fkey");
            });

            modelBuilder.Entity<SoComplemento>(entity =>
            {
                entity.HasKey(e => e.ComId)
                    .HasName("SO_COMPLEMENTOS_pkey");

                entity.ToTable("SO_COMPLEMENTO", "suizasoft");

                entity.Property(e => e.ComId)
                    .HasColumnName("com_id")
                    .HasDefaultValueSql("nextval('suizasoft.\"SO_COMPLEMENTOS_com_id_seq\"'::regclass)");

                entity.Property(e => e.ComEstado).HasColumnName("com_estado");

                entity.Property(e => e.ComNombre)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("com_nombre");

                entity.Property(e => e.ComPrecio)
                    .HasPrecision(13, 2)
                    .HasColumnName("com_precio");
            });

            modelBuilder.Entity<SoMedicoCitaHorario>(entity =>
            {
                entity.HasKey(e => e.MchId)
                    .HasName("SO_MEDICO_CITA_HORARIO_pkey");

                entity.ToTable("SO_MEDICO_CITA_HORARIO", "suizasoft");

                entity.HasIndex(e => e.MchIdMedico, "IX_SO_MEDICO_CITA_HORARIO_mch_id_medico");

                entity.Property(e => e.MchId).HasColumnName("mch_id");

                entity.Property(e => e.MchDia)
                    .HasColumnType("character varying")
                    .HasColumnName("mch_dia");

                entity.Property(e => e.MchEstado)
                    .HasMaxLength(1)
                    .HasColumnName("mch_estado")
                    .HasDefaultValueSql("'C'::bpchar");

                entity.Property(e => e.MchFecha).HasColumnName("mch_fecha");

                entity.Property(e => e.MchFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("mch_fecha_creacion");

                entity.Property(e => e.MchHora).HasColumnName("mch_hora");

                entity.Property(e => e.MchIdMedico).HasColumnName("mch_id_medico");

                entity.Property(e => e.MchUsuarioCreacion)
                    .HasColumnType("character varying")
                    .HasColumnName("mch_usuario_creacion");

                entity.HasOne(d => d.MchIdMedicoNavigation)
                    .WithMany(p => p.SoMedicoCitaHorarios)
                    .HasForeignKey(d => d.MchIdMedico)
                    .HasConstraintName("SO_MEDICO_CITA_HORARIO_mch_id_medico_fkey");
            });

            modelBuilder.Entity<SoTipoAtencion>(entity =>
            {
                entity.HasKey(e => e.TatId)
                    .HasName("SO_TIPO_ATENCION_pkey");

                entity.ToTable("SO_TIPO_ATENCION", "suizasoft");

                entity.Property(e => e.TatId)
                    .ValueGeneratedNever()
                    .HasColumnName("tat_id");

                entity.Property(e => e.TatEstado).HasColumnName("tat_estado");

                entity.Property(e => e.TatNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("tat_nombre");
            });

            modelBuilder.Entity<SoTipoSeguro>(entity =>
            {
                entity.HasKey(e => e.TseId)
                    .HasName("SO_TIPO_SEGURO_pkey");

                entity.ToTable("SO_TIPO_SEGURO", "suizasoft");

                entity.Property(e => e.TseId)
                    .ValueGeneratedNever()
                    .HasColumnName("tse_id");

                entity.Property(e => e.TseEstado).HasColumnName("tse_estado");

                entity.Property(e => e.TseNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("tse_nombre");
            });

            modelBuilder.Entity<SoTipoServicio>(entity =>
            {
                entity.HasKey(e => e.TseId)
                    .HasName("SO_TIPO_SERVICIOS_pkey");

                entity.ToTable("SO_TIPO_SERVICIOS", "suizasoft");

                entity.Property(e => e.TseId)
                    .ValueGeneratedNever()
                    .HasColumnName("tse_id");

                entity.Property(e => e.TseEstado).HasColumnName("tse_estado");

                entity.Property(e => e.TseNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("tse_nombre");
            });

            modelBuilder.Entity<TefCompanium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEF_COMPANIA", "suizasoft");

                entity.Property(e => e.CEstado).HasColumnName("c_estado");

                entity.Property(e => e.CFechaCreacion).HasColumnName("c_fecha_creacion");

                entity.Property(e => e.CIafas)
                    .HasMaxLength(5)
                    .HasColumnName("c_iafas");

                entity.Property(e => e.CIpress)
                    .HasMaxLength(8)
                    .HasColumnName("c_ipress");

                entity.Property(e => e.CNumeroRuc)
                    .HasMaxLength(11)
                    .HasColumnName("c_numero_ruc");

                entity.Property(e => e.CRazonSocial)
                    .HasMaxLength(100)
                    .HasColumnName("c_razon_social");
            });

            modelBuilder.Entity<TefDetallePlantillaTrama>(entity =>
            {
                entity.HasKey(e => e.DIdDetallePlantillaTrama)
                    .HasName("TEF_DETALLE_PLANTILLA_TRAMA_pkey");

                entity.ToTable("TEF_DETALLE_PLANTILLA_TRAMA", "suizasoft");

                entity.Property(e => e.DIdDetallePlantillaTrama)
                    .ValueGeneratedNever()
                    .HasColumnName("d_id_detalle_plantilla_trama");

                entity.Property(e => e.DCodigo)
                    .HasMaxLength(3)
                    .HasColumnName("d_codigo");

                entity.Property(e => e.DDecimal).HasColumnName("d_decimal");

                entity.Property(e => e.DDireccion)
                    .HasMaxLength(20)
                    .HasColumnName("d_direccion");

                entity.Property(e => e.DEstado).HasColumnName("d_estado");

                entity.Property(e => e.DIdPlantillaTrama).HasColumnName("d_id_plantilla_trama");

                entity.Property(e => e.DLongitud).HasColumnName("d_longitud");

                entity.Property(e => e.DNombreCampo)
                    .HasMaxLength(100)
                    .HasColumnName("d_nombre_campo");

                entity.Property(e => e.DPosicionInicial).HasColumnName("d_posicion_inicial");
            });

            modelBuilder.Entity<TefPlantillaTrama>(entity =>
            {
                entity.HasKey(e => e.TIdPlantillaTrama)
                    .HasName("TEF_PLANTILLA_TRAMA_pkey");

                entity.ToTable("TEF_PLANTILLA_TRAMA", "suizasoft");

                entity.Property(e => e.TIdPlantillaTrama)
                    .ValueGeneratedNever()
                    .HasColumnName("t_id_plantilla_trama");

                entity.Property(e => e.TFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("t_fecha_creacion");

                entity.Property(e => e.TFormateoNombreGuia)
                    .HasMaxLength(100)
                    .HasColumnName("t_formateo_nombre_guia");

                entity.Property(e => e.TNombrePlantilla)
                    .HasMaxLength(100)
                    .HasColumnName("t_nombre_plantilla");

                entity.Property(e => e.TNombrePlantillaAlias)
                    .HasMaxLength(100)
                    .HasColumnName("t_nombre_plantilla_alias");
            });

            modelBuilder.Entity<TefTipoServicioLote>(entity =>
            {
                entity.HasKey(e => e.SIdTipoServicio)
                    .HasName("TEF_TIPO_SERVICIO_LOTE_pkey");

                entity.ToTable("TEF_TIPO_SERVICIO_LOTE", "suizasoft");

                entity.Property(e => e.SIdTipoServicio)
                    .ValueGeneratedNever()
                    .HasColumnName("s_id_tipo_servicio");

                entity.Property(e => e.SNombreTipoServicio)
                    .HasMaxLength(100)
                    .HasColumnName("s_nombre_tipo_servicio");
            });

            modelBuilder.Entity<TipAccionBitacora>(entity =>
            {
                entity.HasKey(e => e.TpaId)
                    .HasName("TIP_ACCION_BITACORA_pkey");

                entity.ToTable("TIP_ACCION_BITACORA", "suizasoft");

                entity.Property(e => e.TpaId).HasColumnName("tpa_id");

                entity.Property(e => e.TpaDescripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tpa_descripcion");

                entity.Property(e => e.TpaEstado).HasColumnName("tpa_estado");
            });

            modelBuilder.Entity<TipAfectacionIgv>(entity =>
            {
                entity.HasKey(e => e.AfeId)
                    .HasName("TIP_AFECTACION_IGV_pkey");

                entity.ToTable("TIP_AFECTACION_IGV", "suizasoft");

                entity.Property(e => e.AfeId)
                    .ValueGeneratedNever()
                    .HasColumnName("afe_id");

                entity.Property(e => e.AfeCodigoAfectacion).HasColumnName("afe_codigo_afectacion");

                entity.Property(e => e.AfeEstado).HasColumnName("afe_estado");

                entity.Property(e => e.AfeNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("afe_nombre");
            });

            modelBuilder.Entity<TipAreaAtencion>(entity =>
            {
                entity.HasKey(e => e.AatId)
                    .HasName("TIP_AREA_ATENCION_pkey");

                entity.ToTable("TIP_AREA_ATENCION", "suizasoft");

                entity.Property(e => e.AatId).HasColumnName("aat_id");

                entity.Property(e => e.AatEstado)
                    .HasColumnName("aat_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AatFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("aat_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.AatFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("aat_fecha_modificacion");

                entity.Property(e => e.AatNombre)
                    .HasMaxLength(50)
                    .HasColumnName("aat_nombre");

                entity.Property(e => e.AatNombreCorto)
                    .HasMaxLength(20)
                    .HasColumnName("aat_nombre_corto");

                entity.Property(e => e.AatVistaServicio)
                    .HasColumnName("aat_vista_servicio")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<TipCentroCostoNegocio>(entity =>
            {
                entity.HasKey(e => e.CecId)
                    .HasName("TIP_CENTRO_COSTO_pkey");

                entity.ToTable("TIP_CENTRO_COSTO_NEGOCIO", "suizasoft");

                entity.HasIndex(e => e.CecDescripcion, "TIP_CENTRO_COSTO_unique_descripcion")
                    .IsUnique();

                entity.Property(e => e.CecId).HasColumnName("cec_id");

                entity.Property(e => e.CecDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("cec_descripcion");

                entity.Property(e => e.CecEstado).HasColumnName("cec_estado");
            });

            modelBuilder.Entity<TipContenedor>(entity =>
            {
                entity.HasKey(e => e.TcoId)
                    .HasName("TIP_CONTENEDOR_pkey");

                entity.ToTable("TIP_CONTENEDOR", "suizasoft");

                entity.Property(e => e.TcoId)
                    .ValueGeneratedNever()
                    .HasColumnName("tco_id");

                entity.Property(e => e.TcoDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("tco_descripcion");

                entity.Property(e => e.TcoEstado).HasColumnName("tco_estado");
            });

            modelBuilder.Entity<TipEquipoLaboratorio>(entity =>
            {
                entity.HasKey(e => e.EquId)
                    .HasName("MST_EQUIPO_LABORATORIO_pkey");

                entity.ToTable("TIP_EQUIPO_LABORATORIO", "suizasoft");

                entity.Property(e => e.EquId)
                    .ValueGeneratedNever()
                    .HasColumnName("equ_id");

                entity.Property(e => e.EquCodigoAnterior)
                    .HasColumnType("character varying")
                    .HasColumnName("equ_codigo_anterior");

                entity.Property(e => e.EquDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("equ_descripcion");

                entity.Property(e => e.EquEstado).HasColumnName("equ_estado");
            });

            modelBuilder.Entity<TipEstadoCitasSeguro>(entity =>
            {
                entity.HasKey(e => e.EscId)
                    .HasName("TIP_ESTADO_CITAS_SEGURO_pkey");

                entity.ToTable("TIP_ESTADO_CITAS_SEGURO", "suizasoft");

                entity.Property(e => e.EscId).HasColumnName("esc_id");

                entity.Property(e => e.EscDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("esc_descripcion");

                entity.Property(e => e.EscDescripcionCorta)
                    .HasColumnType("character varying")
                    .HasColumnName("esc_descripcion_corta");

                entity.Property(e => e.EscEstado).HasColumnName("esc_estado");

                entity.Property(e => e.EscFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("esc_fecha_modificacion");

                entity.Property(e => e.EscFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("esc_fecha_registro");

                entity.Property(e => e.EscUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("esc_usuario_modificacion");

                entity.Property(e => e.EscUsuarioRegistro)
                    .HasColumnType("character varying")
                    .HasColumnName("esc_usuario_registro");
            });

            modelBuilder.Entity<TipFisiologicoInterface>(entity =>
            {
                entity.HasKey(e => e.FiId)
                    .HasName("TIP_FISIOLOGICO_INTERFACE_pkey");

                entity.ToTable("TIP_FISIOLOGICO_INTERFACE", "suizasoft");

                entity.Property(e => e.FiId)
                    .ValueGeneratedNever()
                    .HasColumnName("fi_id");

                entity.Property(e => e.FiDescripcion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("fi_descripcion");

                entity.Property(e => e.FiEstado).HasColumnName("fi_estado");

                entity.Property(e => e.FiFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fi_fecha_registro");

                entity.Property(e => e.FiUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("fi_usuario_creacion");
            });

            modelBuilder.Entity<TipGrupoEtnicoInterface>(entity =>
            {
                entity.HasKey(e => e.GeId)
                    .HasName("TIP_GRUPO_ETNICO_INTERFACE_pkey");

                entity.ToTable("TIP_GRUPO_ETNICO_INTERFACE", "suizasoft");

                entity.Property(e => e.GeId)
                    .ValueGeneratedNever()
                    .HasColumnName("ge_id");

                entity.Property(e => e.GeDescripcion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("ge_descripcion");

                entity.Property(e => e.GeEstado).HasColumnName("ge_estado");

                entity.Property(e => e.GeFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ge_fecha_registro");

                entity.Property(e => e.GeUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("ge_usuario_creacion");
            });

            modelBuilder.Entity<TipGrupoOmd>(entity =>
            {
                entity.HasKey(e => e.GruId)
                    .HasName("TIP_GRUPO_OMD_pkey");

                entity.ToTable("TIP_GRUPO_OMD", "suizasoft");

                entity.Property(e => e.GruId).HasColumnName("gru_id");

                entity.Property(e => e.GruEstado)
                    .HasColumnName("gru_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.GruIndex).HasColumnName("gru_index");

                entity.Property(e => e.GruNombre)
                    .HasMaxLength(50)
                    .HasColumnName("gru_nombre");

                entity.Property(e => e.GsoFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("gso_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.GsoFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("gso_fecha_modificacion");
            });

            modelBuilder.Entity<TipLineaNegocio>(entity =>
            {
                entity.HasKey(e => e.LinId)
                    .HasName("TIP_LINEA_NEGOCIO_pkey");

                entity.ToTable("TIP_LINEA_NEGOCIO", "suizasoft");

                entity.HasIndex(e => e.LinUnidadNegocioId, "IX_TIP_LINEA_NEGOCIO_lin_unidad_negocio_id");

                entity.Property(e => e.LinId).HasColumnName("lin_id");

                entity.Property(e => e.LinDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("lin_descripcion");

                entity.Property(e => e.LinEstado).HasColumnName("lin_estado");

                entity.Property(e => e.LinUnidadNegocioId).HasColumnName("lin_unidad_negocio_id");

                entity.HasOne(d => d.LinUnidadNegocio)
                    .WithMany(p => p.TipLineaNegocios)
                    .HasForeignKey(d => d.LinUnidadNegocioId)
                    .HasConstraintName("TIP_LINEA_NEGOCIO_unidad_negocio_fkey_id");
            });

            modelBuilder.Entity<TipMedico>(entity =>
            {
                entity.HasKey(e => e.TmeId)
                    .HasName("TIP_MEDICO_pkey");

                entity.ToTable("TIP_MEDICO", "suizasoft");

                entity.Property(e => e.TmeId)
                    .ValueGeneratedNever()
                    .HasColumnName("tme_id");

                entity.Property(e => e.TmeDescripccion)
                    .HasColumnType("character varying")
                    .HasColumnName("tme_descripccion");

                entity.Property(e => e.TmeEstado).HasColumnName("tme_estado");

                entity.Property(e => e.TmeNombre)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("tme_nombre");
            });

            modelBuilder.Entity<TipMedicoColegiatura>(entity =>
            {
                entity.HasKey(e => e.TmcId)
                    .HasName("TIP_MEDICO_COLEGIATURA_pkey");

                entity.ToTable("TIP_MEDICO_COLEGIATURA", "suizasoft");

                entity.Property(e => e.TmcId)
                    .ValueGeneratedNever()
                    .HasColumnName("tmc_id");

                entity.Property(e => e.TmcDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("tmc_descripcion");

                entity.Property(e => e.TmcEstado).HasColumnName("tmc_estado");

                entity.Property(e => e.TmcNombre)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("tmc_nombre");
            });

            modelBuilder.Entity<TipMedicoEspecialidad>(entity =>
            {
                entity.HasKey(e => e.MesId)
                    .HasName("TIP_MEDICO_ESPECIALIDAD_pkey");

                entity.ToTable("TIP_MEDICO_ESPECIALIDAD", "suizasoft");

                entity.Property(e => e.MesId)
                    .ValueGeneratedNever()
                    .HasColumnName("mes_id");

                entity.Property(e => e.MesDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("mes_descripcion");

                entity.Property(e => e.MesEstado).HasColumnName("mes_estado");

                entity.Property(e => e.MesNombre)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("mes_nombre");
            });

            modelBuilder.Entity<TipModuloFacturacion>(entity =>
            {
                entity.HasKey(e => e.MfaId)
                    .HasName("TIP_MODULO_FACTURACION_pkey");

                entity.ToTable("TIP_MODULO_FACTURACION", "suizasoft");

                entity.Property(e => e.MfaId)
                    .ValueGeneratedNever()
                    .HasColumnName("mfa_id");

                entity.Property(e => e.MfaDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("mfa_descripcion");

                entity.Property(e => e.MfaNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("mfa_nombre");

                entity.Property(e => e.MfaNombreCorto)
                    .HasColumnType("character varying")
                    .HasColumnName("mfa_nombre_corto");
            });

            modelBuilder.Entity<TipMuestraLaboratorio>(entity =>
            {
                entity.HasKey(e => e.MueId)
                    .HasName("MST_MUESTRA_LABORATORIO_pkey");

                entity.ToTable("TIP_MUESTRA_LABORATORIO", "suizasoft");

                entity.HasIndex(e => e.MueIdContenedor, "IX_TIP_MUESTRA_LABORATORIO_mue_id_contenedor");

                entity.HasIndex(e => e.MueIdTubo, "IX_TIP_MUESTRA_LABORATORIO_mue_id_tubo");

                entity.Property(e => e.MueId)
                    .ValueGeneratedNever()
                    .HasColumnName("mue_id");

                entity.Property(e => e.MueCodigoAnterior)
                    .HasColumnType("character varying")
                    .HasColumnName("mue_codigo_anterior");

                entity.Property(e => e.MueDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("mue_descripcion");

                entity.Property(e => e.MueEstado).HasColumnName("mue_estado");

                entity.Property(e => e.MueIdContenedor).HasColumnName("mue_id_contenedor");

                entity.Property(e => e.MueIdTubo).HasColumnName("mue_id_tubo");

                entity.HasOne(d => d.MueIdContenedorNavigation)
                    .WithMany(p => p.TipMuestraLaboratorios)
                    .HasForeignKey(d => d.MueIdContenedor)
                    .HasConstraintName("TIP_MUESTRA_LABORATORIO_mue_id_contenedor_fkey");

                entity.HasOne(d => d.MueIdTuboNavigation)
                    .WithMany(p => p.TipMuestraLaboratorios)
                    .HasForeignKey(d => d.MueIdTubo)
                    .HasConstraintName("TIP_MUESTRA_LABORATORIO_mue_id_tubo_fkey");
            });

            modelBuilder.Entity<TipNotaCreditoOperacion>(entity =>
            {
                entity.HasKey(e => e.NcoId)
                    .HasName("TIP_NOTA_CREDITO_OPERACION_pkey");

                entity.ToTable("TIP_NOTA_CREDITO_OPERACION", "suizasoft");

                entity.Property(e => e.NcoId)
                    .ValueGeneratedNever()
                    .HasColumnName("nco_id");

                entity.Property(e => e.NcoDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("nco_descripcion");

                entity.Property(e => e.NcoNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("nco_nombre");
            });

            modelBuilder.Entity<TipOrdenEstado>(entity =>
            {
                entity.HasKey(e => e.ToeId)
                    .HasName("TIP_ORDEN_ESTADO_pkey");

                entity.ToTable("TIP_ORDEN_ESTADO", "suizasoft");

                entity.Property(e => e.ToeId)
                    .ValueGeneratedNever()
                    .HasColumnName("toe_id");

                entity.Property(e => e.ToeDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("toe_descripcion");

                entity.Property(e => e.ToeEstado)
                    .HasColumnName("toe_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ToeNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("toe_nombre");
            });

            modelBuilder.Entity<TipPagoCuentum>(entity =>
            {
                entity.HasKey(e => e.PcuId)
                    .HasName("TIP_PAGO_CUENTA_pkey");

                entity.ToTable("TIP_PAGO_CUENTA", "suizasoft");

                entity.Property(e => e.PcuId)
                    .ValueGeneratedNever()
                    .HasColumnName("pcu_id");

                entity.Property(e => e.PcuDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("pcu_descripcion");

                entity.Property(e => e.PcuEstado).HasColumnName("pcu_estado");

                entity.Property(e => e.PcuNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("pcu_nombre");

                entity.Property(e => e.PcuNombreCorto)
                    .HasColumnType("character varying")
                    .HasColumnName("pcu_nombre_corto");
            });

            modelBuilder.Entity<TipPagoTarjetum>(entity =>
            {
                entity.HasKey(e => e.PtaId)
                    .HasName("TIP_PAGO_TARJETA_pkey");

                entity.ToTable("TIP_PAGO_TARJETA", "suizasoft");

                entity.Property(e => e.PtaId)
                    .ValueGeneratedNever()
                    .HasColumnName("pta_id");

                entity.Property(e => e.PtaDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("pta_descripcion");

                entity.Property(e => e.PtaEstado).HasColumnName("pta_estado");

                entity.Property(e => e.PtaNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("pta_nombre");

                entity.Property(e => e.PtaNombreCorto)
                    .HasColumnType("character varying")
                    .HasColumnName("pta_nombre_corto");
            });

            modelBuilder.Entity<TipParentesco>(entity =>
            {
                entity.HasKey(e => e.TpaId)
                    .HasName("TIP_PARENTESCO_pkey");

                entity.ToTable("TIP_PARENTESCO", "suizasoft");

                entity.Property(e => e.TpaId)
                    .ValueGeneratedNever()
                    .HasColumnName("tpa_id");

                entity.Property(e => e.TpaEstado)
                    .HasColumnName("tpa_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TpaFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tpa_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TpaFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tpa_fecha_modificacion");

                entity.Property(e => e.TpaNombre)
                    .HasMaxLength(20)
                    .HasColumnName("tpa_nombre");

                entity.Property(e => e.TpaNombreCorto)
                    .HasMaxLength(5)
                    .HasColumnName("tpa_nombre_corto");
            });

            modelBuilder.Entity<TipPrioridad>(entity =>
            {
                entity.HasKey(e => e.TpId)
                    .HasName("TIP_PRIORIDAD_pkey");

                entity.ToTable("TIP_PRIORIDAD", "suizasoft");

                entity.Property(e => e.TpId)
                    .ValueGeneratedNever()
                    .HasColumnName("tp_id");

                entity.Property(e => e.TpDescripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tp_descripcion");

                entity.Property(e => e.TpEstado).HasColumnName("tp_estado");
            });

            modelBuilder.Entity<TipPrioridadAtencion>(entity =>
            {
                entity.HasKey(e => e.PatId)
                    .HasName("TIP_PRIORIDAD_ATENCION_pkey");

                entity.ToTable("TIP_PRIORIDAD_ATENCION", "suizasoft");

                entity.Property(e => e.PatId)
                    .ValueGeneratedNever()
                    .HasColumnName("pat_id");

                entity.Property(e => e.PatEstado)
                    .HasColumnName("pat_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PatFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pat_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PatFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pat_fecha_modificacion");

                entity.Property(e => e.PatNombre)
                    .HasMaxLength(20)
                    .HasColumnName("pat_nombre");
            });

            modelBuilder.Entity<TipProcedencium>(entity =>
            {
                entity.HasKey(e => e.ProId)
                    .HasName("MST_PROCEDENCIAS_pkey");

                entity.ToTable("TIP_PROCEDENCIA", "suizasoft");

                entity.Property(e => e.ProId).HasColumnName("pro_id");

                entity.Property(e => e.ProDescripcion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("pro_descripcion");

                entity.Property(e => e.ProEstado).HasColumnName("pro_estado");

                entity.Property(e => e.ProFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pro_fecha_creacion");

                entity.Property(e => e.ProFechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pro_fecha_modificacion");

                entity.Property(e => e.ProUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("pro_usuario_creacion");

                entity.Property(e => e.ProUsuarioModificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("pro_usuario_modificacion");
            });

            modelBuilder.Entity<TipPromotor>(entity =>
            {
                entity.HasKey(e => e.TprId)
                    .HasName("MST_TIPO_PROMOTOR_pkey");

                entity.ToTable("TIP_PROMOTOR", "suizasoft");

                entity.Property(e => e.TprId)
                    .ValueGeneratedNever()
                    .HasColumnName("tpr_id");

                entity.Property(e => e.TprNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("tpr_nombre");
            });

            modelBuilder.Entity<TipRiesgo>(entity =>
            {
                entity.HasKey(e => e.TrsgId)
                    .HasName("TIP_RIESGO_pkey");

                entity.ToTable("TIP_RIESGO", "suizasoft");

                entity.HasIndex(e => e.TrsgNombre, "tip_riesgo_nombre_unique")
                    .IsUnique();

                entity.Property(e => e.TrsgId).HasColumnName("trsg_id");

                entity.Property(e => e.TrsgEstado).HasColumnName("trsg_estado");

                entity.Property(e => e.TrsgNombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("trsg_nombre");
            });

            modelBuilder.Entity<TipSeguro>(entity =>
            {
                entity.HasKey(e => e.TsegId)
                    .HasName("TIP_SEGURO_pkey");

                entity.ToTable("TIP_SEGURO", "suizasoft");

                entity.HasIndex(e => e.TsegNombre, "nombre_unique")
                    .IsUnique();

                entity.Property(e => e.TsegId).HasColumnName("tseg_id");

                entity.Property(e => e.TsegEstado).HasColumnName("tseg_estado");

                entity.Property(e => e.TsegNombre)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("tseg_nombre");
            });

            modelBuilder.Entity<TipServicioArea>(entity =>
            {
                entity.HasKey(e => e.GseId)
                    .HasName("MST_GRUPO_SERVICIO_pkey");

                entity.ToTable("TIP_SERVICIO_AREA", "suizasoft");

                entity.Property(e => e.GseId)
                    .HasColumnType("character varying")
                    .HasColumnName("gse_id");

                entity.Property(e => e.GseDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("gse_descripcion");

                entity.Property(e => e.GseEstado).HasColumnName("gse_estado");
            });

            modelBuilder.Entity<TipServicioAreaLaboratorioBak>(entity =>
            {
                entity.HasKey(e => e.AreId)
                    .HasName("MST_AREA_LABORATORIO_pkey");

                entity.ToTable("TIP_SERVICIO_AREA_LABORATORIO_BAK", "suizasoft");

                entity.Property(e => e.AreId)
                    .ValueGeneratedNever()
                    .HasColumnName("are_id");

                entity.Property(e => e.AreDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("are_descripcion");

                entity.Property(e => e.AreEstado).HasColumnName("are_estado");
            });

            modelBuilder.Entity<TipServicioMetodoLaboratorio>(entity =>
            {
                entity.HasKey(e => e.MetId)
                    .HasName("MST_METODO_LABORATORIO_pkey");

                entity.ToTable("TIP_SERVICIO_METODO_LABORATORIO", "suizasoft");

                entity.Property(e => e.MetId)
                    .ValueGeneratedNever()
                    .HasColumnName("met_id");

                entity.Property(e => e.MetCodigoAnterior)
                    .HasColumnType("character varying")
                    .HasColumnName("met_codigo_anterior");

                entity.Property(e => e.MetDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("met_descripcion");

                entity.Property(e => e.MetEstado).HasColumnName("met_estado");
            });

            modelBuilder.Entity<TipServicioProceso>(entity =>
            {
                entity.HasKey(e => e.LprId)
                    .HasName("MST_LAB_PROCESO_pkey");

                entity.ToTable("TIP_SERVICIO_PROCESO", "suizasoft");

                entity.Property(e => e.LprId).HasColumnName("lpr_id");

                entity.Property(e => e.LprDescripcion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("lpr_descripcion");
            });

            modelBuilder.Entity<TipServicioTemperatura>(entity =>
            {
                entity.HasKey(e => e.LteId)
                    .HasName("MST_LAB_TEMPERATURA_pkey");

                entity.ToTable("TIP_SERVICIO_TEMPERATURA", "suizasoft");

                entity.Property(e => e.LteId).HasColumnName("lte_id");

                entity.Property(e => e.LteDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("lte_descripcion");
            });

            modelBuilder.Entity<TipTopicoEnvio>(entity =>
            {
                entity.HasKey(e => e.TteId)
                    .HasName("TIP_TOPICO_ENVIO_pkey");

                entity.ToTable("TIP_TOPICO_ENVIO", "suizasoft");

                entity.Property(e => e.TteId)
                    .HasMaxLength(3)
                    .HasColumnName("tte_id");

                entity.Property(e => e.TteSedeCorto)
                    .HasColumnType("character varying")
                    .HasColumnName("tte_sede_corto");

                entity.Property(e => e.TteSedeLargo)
                    .HasColumnType("character varying")
                    .HasColumnName("tte_sede_largo");
            });

            modelBuilder.Entity<TipTopicoIngreso>(entity =>
            {
                entity.HasKey(e => e.TtiId)
                    .HasName("TIP_TOPICO_TIPO_MUESTRA_pkey");

                entity.ToTable("TIP_TOPICO_INGRESO", "suizasoft");

                entity.Property(e => e.TtiId)
                    .ValueGeneratedNever()
                    .HasColumnName("tti_id");

                entity.Property(e => e.TtiDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("tti_descripcion");

                entity.Property(e => e.TtiEstado).HasColumnName("tti_estado");

                entity.Property(e => e.TtiNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("tti_nombre");
            });

            modelBuilder.Entity<TipTopicoLaboratorio>(entity =>
            {
                entity.HasKey(e => e.TtlId)
                    .HasName("TIP_TOPICO_LABORATORIO_pkey");

                entity.ToTable("TIP_TOPICO_LABORATORIO", "suizasoft");

                entity.Property(e => e.TtlId)
                    .ValueGeneratedNever()
                    .HasColumnName("ttl_id");

                entity.Property(e => e.TtlNombreCorto)
                    .HasMaxLength(10)
                    .HasColumnName("ttl_nombre_corto");

                entity.Property(e => e.TtlNombreLargo)
                    .HasMaxLength(45)
                    .HasColumnName("ttl_nombre_largo");
            });

            modelBuilder.Entity<TipTubo>(entity =>
            {
                entity.HasKey(e => e.TubId)
                    .HasName("MST_TIPO_TUBO_pkey");

                entity.ToTable("TIP_TUBO", "suizasoft");

                entity.Property(e => e.TubId)
                    .ValueGeneratedNever()
                    .HasColumnName("tub_id");

                entity.Property(e => e.TubCodigoAnterior)
                    .HasColumnType("character varying")
                    .HasColumnName("tub_codigo_anterior");

                entity.Property(e => e.TubDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("tub_descripcion");

                entity.Property(e => e.TubEstado).HasColumnName("tub_estado");
            });

            modelBuilder.Entity<TipUnidadEdadInterface>(entity =>
            {
                entity.HasKey(e => e.UeiId)
                    .HasName("TIP_UNIDAD_EDAD_INTERFACE_pkey");

                entity.ToTable("TIP_UNIDAD_EDAD_INTERFACE", "suizasoft");

                entity.Property(e => e.UeiId)
                    .ValueGeneratedNever()
                    .HasColumnName("uei_id");

                entity.Property(e => e.UeiDescripcion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("uei_descripcion");

                entity.Property(e => e.UeiEstado).HasColumnName("uei_estado");

                entity.Property(e => e.UeiFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("uei_fecha_registro");

                entity.Property(e => e.UeiUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("uei_usuario_creacion");
            });

            modelBuilder.Entity<TipUnidadMedidum>(entity =>
            {
                entity.HasKey(e => e.UmId)
                    .HasName("TIP_UNIDAD_MEDIDA_pkey");

                entity.ToTable("TIP_UNIDAD_MEDIDA", "suizasoft");

                entity.Property(e => e.UmId).HasColumnName("um_id");

                entity.Property(e => e.UmDescripcion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("um_descripcion");

                entity.Property(e => e.UmEstado).HasColumnName("um_estado");

                entity.Property(e => e.UmFechaRegistro)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("um_fecha_registro");

                entity.Property(e => e.UmUsuarioCreacion)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("um_usuario_creacion");
            });

            modelBuilder.Entity<TipVigenciaOrdenMedica>(entity =>
            {
                entity.HasKey(e => e.VomId)
                    .HasName("TIP_VIGENCIA_ORDEN_MEDICA_pkey");

                entity.ToTable("TIP_VIGENCIA_ORDEN_MEDICA", "suizasoft");

                entity.Property(e => e.VomId).HasColumnName("vom_id");

                entity.Property(e => e.VomEstado)
                    .HasColumnName("vom_estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.VomFechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("vom_fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.VomFechaModificaion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("vom_fecha_modificaion");

                entity.Property(e => e.VomNombre)
                    .HasMaxLength(100)
                    .HasColumnName("vom_nombre");
            });

            modelBuilder.Entity<VCpsId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("v_cps_id");

                entity.Property(e => e.Column).HasColumnName("?column?");
            });

            modelBuilder.Entity<VEdad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("v_edad");

                entity.Property(e => e.Extract).HasColumnName("extract");
            });

            modelBuilder.Entity<VOmdId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("v_omd_id");

                entity.Property(e => e.Column).HasColumnName("?column?");
            });

            modelBuilder.Entity<WatchdogLog>(entity =>
            {
                entity.ToTable("watchdog_logs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Callingfrom)
                    .HasColumnType("character varying")
                    .HasColumnName("callingfrom");

                entity.Property(e => e.Callingmethod)
                    .HasMaxLength(100)
                    .HasColumnName("callingmethod");

                entity.Property(e => e.Eventid)
                    .HasMaxLength(100)
                    .HasColumnName("eventid");

                entity.Property(e => e.Linenumber).HasColumnName("linenumber");

                entity.Property(e => e.Loglevel)
                    .HasMaxLength(30)
                    .HasColumnName("loglevel");

                entity.Property(e => e.Message)
                    .HasColumnType("character varying")
                    .HasColumnName("message");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<WatchdogWatchexceptionlog>(entity =>
            {
                entity.ToTable("watchdog_watchexceptionlog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Encounteredat).HasColumnName("encounteredat");

                entity.Property(e => e.Message)
                    .HasColumnType("character varying")
                    .HasColumnName("message");

                entity.Property(e => e.Method)
                    .HasMaxLength(30)
                    .HasColumnName("method");

                entity.Property(e => e.Path)
                    .HasColumnType("character varying")
                    .HasColumnName("path");

                entity.Property(e => e.Querystring)
                    .HasColumnType("character varying")
                    .HasColumnName("querystring");

                entity.Property(e => e.Requestbody)
                    .HasColumnType("character varying")
                    .HasColumnName("requestbody");

                entity.Property(e => e.Source)
                    .HasColumnType("character varying")
                    .HasColumnName("source");

                entity.Property(e => e.Stacktrace)
                    .HasColumnType("character varying")
                    .HasColumnName("stacktrace");

                entity.Property(e => e.Typeof)
                    .HasColumnType("character varying")
                    .HasColumnName("typeof");
            });

            modelBuilder.Entity<WatchdogWatchlog>(entity =>
            {
                entity.ToTable("watchdog_watchlog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Endtime).HasColumnName("endtime");

                entity.Property(e => e.Host)
                    .HasColumnType("character varying")
                    .HasColumnName("host");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(30)
                    .HasColumnName("ipaddress");

                entity.Property(e => e.Method)
                    .HasMaxLength(30)
                    .HasColumnName("method");

                entity.Property(e => e.Path)
                    .HasColumnType("character varying")
                    .HasColumnName("path");

                entity.Property(e => e.Querystring)
                    .HasColumnType("character varying")
                    .HasColumnName("querystring");

                entity.Property(e => e.Requestbody)
                    .HasColumnType("character varying")
                    .HasColumnName("requestbody");

                entity.Property(e => e.Requestheaders)
                    .HasColumnType("character varying")
                    .HasColumnName("requestheaders");

                entity.Property(e => e.Responsebody)
                    .HasColumnType("character varying")
                    .HasColumnName("responsebody");

                entity.Property(e => e.Responseheaders)
                    .HasColumnType("character varying")
                    .HasColumnName("responseheaders");

                entity.Property(e => e.Responsestatus).HasColumnName("responsestatus");

                entity.Property(e => e.Starttime).HasColumnName("starttime");

                entity.Property(e => e.Timespent)
                    .HasColumnType("character varying")
                    .HasColumnName("timespent");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
