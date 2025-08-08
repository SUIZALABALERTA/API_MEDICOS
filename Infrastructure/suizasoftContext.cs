using Domain.Entities;
using Domain.Models;
using Domain.Utils;
using Infrastructure.Configurations;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace Infrastructure
{
    public partial class SuizasoftContext : DbContext
    {
        private readonly IHttpContextAccessor? _httpContextAccessor;
        private readonly IOptions<DatabaseSettings> _databaseSettings;


        public SuizasoftContext(DbContextOptions<SuizasoftContext> options, IHttpContextAccessor httpContextAccessor, IOptions<DatabaseSettings> databaseSettings) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
            _databaseSettings = databaseSettings;
        }

        public virtual DbSet<MstSistema> MstSistemas { get; set; }
        public virtual DbSet<MstMedico> MstMedicos { get; set; } = null!;
        public virtual DbSet<MstUbigeo> MstUbigeos { get; set; }
        public virtual DbSet<MstTipoDocumento> MstTipoDocumentos { get; set; }
        public virtual DbSet<MstSexo> MstSexos { get; set; }
        public virtual DbSet<TipMedicoColegiatura> TipMedicoColegiaturas { get; set; }
        public virtual DbSet<TipMedico> TipMedicos { get; set; }
        public virtual DbSet<MstPromotor> MstPromotors { get; set; }
        public virtual DbSet<TipPromotor> MstTipoPromotors { get; set; }
        public virtual DbSet<MstOrdenServicioCabecera> MstOrdenServicioCabeceras { get; set; }
        public virtual DbSet<MstModalidad> MstModalidads { get; set; }

        public virtual DbSet<DetMedicoRolCentroMedico> DetMedicoRolCentroMedicos { get; set; }
        public virtual DbSet<MstRolCentroMedico> MstRolCentroMedicos { get; set; }
        public virtual DbSet<DetMedicoAreaNegocio> DetMedicoAreaNegocios { get; set; }
        public virtual DbSet<MstServicioAreaNegocio> MstServicioAreaNegocios { get; set; } = null!;

        public virtual DbSet<DetOrdenServicioDetalle> DetOrdenServicioDetalles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _databaseSettings.Value.PostgresSQLConnection + $"Application Name=Medicos.Api;";

                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            ProcesarSalvado();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void ProcesarSalvado()
        {
            var user = _httpContextAccessor!.HttpContext!.User.FindFirstValue("username").ToUpper();

            foreach (var item in ChangeTracker.Entries().Where(e => e.State == EntityState.Added && e.Entity is AuditEntity))
            {
                var entidad = item.Entity as AuditEntity;

                entidad.FechaCreacion = Utils.CurrentDateTime();
                entidad!.UsuarioCreacion = user;
                item.Property(nameof(entidad.UsuarioModificacion)).IsModified = false;
                entidad.FechaModificacion = null;
            }

            foreach (var item in ChangeTracker.Entries().Where(e => e.State == EntityState.Modified && e.Entity is AuditEntity))
            {
                var entidad = item.Entity as AuditEntity;

                item.Property(nameof(entidad.UsuarioCreacion)).IsModified = false;
                item.Property(nameof(entidad.FechaCreacion)).IsModified = false;

                if (item.Property(nameof(entidad.FechaModificacion)).IsModified)
                {
                    entidad!.UsuarioModificacion = user;
                    entidad.FechaModificacion = Utils.CurrentDateTime();
                }
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new SystemConfiguration());

            modelBuilder.ApplyConfiguration(new MedicoConfiguration());

            modelBuilder.ApplyConfiguration(new UbigeoConfiguration());

            modelBuilder.ApplyConfiguration(new TypeDocumentConfiguration());

            modelBuilder.ApplyConfiguration(new SexoConfiguration());

            modelBuilder.ApplyConfiguration(new MedicoColegiaturaConfiguration());

            modelBuilder.ApplyConfiguration(new MedicoTipoConfiguration());

            modelBuilder.ApplyConfiguration(new PromotorConfiguration());

            modelBuilder.ApplyConfiguration(new PromotorTipoConfiguration());

            modelBuilder.ApplyConfiguration(new DetMedicoRolCentroMedicoConfiguration());

            modelBuilder.ApplyConfiguration(new MstRolCentroMedicoConfiguration());

            modelBuilder.ApplyConfiguration(new DetMedicoAreaNegocioConfiguration());

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

            modelBuilder.Entity<MstServicioAreaNegocio>(entity =>
            {
                entity.HasKey(e => e.SeaId)
                    .HasName("TIP_SERVICIO_AREA_LABORATORIO_pkey");

                entity.ToTable("MST_SERVICIO_AREA_NEGOCIO", "suizasoft");

                entity.Property(e => e.SeaId)
                    .HasColumnName("sea_id")
                    .HasDefaultValueSql("nextval('suizasoft.\"TIP_SERVICIO_AREA_LABORATORIO_are_id_seq\"'::regclass)");

                entity.Property(e => e.SeaAbreviaturaCodigo)
                    .HasMaxLength(3)
                    .HasColumnName("sea_abreviatura_codigo");

                entity.Property(e => e.SeaCentroCostoId).HasColumnName("sea_centro_costo_id");

                entity.Property(e => e.SeaDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("sea_descripcion");

                entity.Property(e => e.SeaSoNombre).HasColumnType("character varying").HasColumnName("sea_so_nombre");
                entity.Property(e => e.SeaSoFlagMostrar).HasColumnName("sea_so_flag_mostrar");

                entity.Property(e => e.SeaEstado).HasColumnName("sea_estado");

                //entity.HasOne(d => d.SeaCentroCosto)
                //    .WithMany(p => p.MstServicioAreaNegocios)
                //    .HasForeignKey(d => d.SeaCentroCostoId)
                //    .HasConstraintName("MST_SERVICIO_ARE_NEGOCIO_CENTRO_COSTO_fkey_id");
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



                entity.HasOne(d => d.OrsIdMedicoNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdMedico)
                    .HasConstraintName("orden_servicio_cab_medico_fk");

                entity.HasOne(d => d.OrsIdModalidadNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdModalidad)
                    .HasConstraintName("orden_servicio_cab_modalidad_fk");


                entity.HasOne(d => d.OrsIdPacienteNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdPaciente)
                    .HasConstraintName("orden_servicio_cab_pac_fk");


                entity.HasOne(d => d.OrsIdSucursalNavigation)
                    .WithMany(p => p.MstOrdenServicioCabeceras)
                    .HasForeignKey(d => d.OrsIdSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orden_servicio_cab_sucursal_fk");

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
        }

    }
}
