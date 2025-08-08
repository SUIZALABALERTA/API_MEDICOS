using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class SystemConfiguration : IEntityTypeConfiguration<MstSistema>
    {
        public void Configure(EntityTypeBuilder<MstSistema> builder)
        {
            builder.HasKey(e => e.SisId)
                   .HasName("MST_SISTEMA_pkey");

            builder.ToTable("MST_SISTEMA", "suizasoft");

            builder.Property(e => e.SisId).HasColumnName("sis_id");

            builder.Property(e => e.SisActivo)
                .IsRequired()
                .HasColumnName("sis_activo")
                .HasDefaultValueSql("true");

            builder.Property(e => e.SisContrasenia)
                .HasMaxLength(100)
                .HasColumnName("sis_contrasenia");

            builder.Property(e => e.SisDescripcion)
                .IsRequired()
                .HasMaxLength(1000)
                .HasColumnName("sis_descripcion");

            builder.Property(e => e.SisFechaCreacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("sis_fecha_creacion")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(e => e.SisFechaModificacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("sis_fecha_modificacion")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(e => e.SisNombre)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("sis_nombre");

            builder.Property(e => e.SisNombreCorto)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("sis_nombre_corto");

            builder.Property(e => e.SisTsiId).HasColumnName("sis_tsi_id");

            builder.Property(e => e.SisUrl)
                .IsRequired()
                .HasMaxLength(500)
                .HasColumnName("sis_url");

            builder.Property(e => e.SisUsuIdCreacion).HasColumnName("sis_usu_id_creacion");

            builder.Property(e => e.SisUsuIdModificacion).HasColumnName("sis_usu_id_modificacion");

            builder.Property(e => e.SisUsuario)
                .HasMaxLength(50)
                .HasColumnName("sis_usuario");

            builder.Property(e => e.SisVersion)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("sis_version");
        }
    }
}
