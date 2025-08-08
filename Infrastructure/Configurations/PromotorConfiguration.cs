using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class PromotorConfiguration : IEntityTypeConfiguration<MstPromotor>
    {
        public void Configure(EntityTypeBuilder<MstPromotor> entity)
        {
            entity.HasKey(e => e.ProId)
                    .HasName("MST_PROMOTOR_pkey");

            entity.ToTable("MST_PROMOTOR", "suizasoft");

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
                .WithMany(p => p.XPromotors)
                .HasForeignKey(d => d.ProIdTipoPromotor)
                .HasConstraintName("MST_PROMOTOR_pro_id_tipo_promotor_fkey");

            entity.HasOne(d => d.ProIdUbigeoNavigation)
                .WithMany(p => p.MstPromotors)
                .HasForeignKey(d => d.ProIdUbigeo)
                .HasConstraintName("MST_PROMOTOR_pro_id_ubigeo_fkey");

        }
    }
}
