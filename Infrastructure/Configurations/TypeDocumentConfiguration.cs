using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class TypeDocumentConfiguration : IEntityTypeConfiguration<MstTipoDocumento>
    {
        public void Configure(EntityTypeBuilder<MstTipoDocumento> builder)
        {
            builder.HasKey(e => e.Id)
                    .HasName("MST_TIPO_DOCUMENTO_pkey");

            builder.ToTable("MST_TIPO_DOCUMENTO", "suizasoft");

            builder.Property(e => e.Id).HasColumnName("tdo_id");

            builder.Property(e => e.Estado)
                .HasColumnType("char")
                .HasColumnName("tdo_estado")
                .HasDefaultValueSql("true");

            builder.Property(e => e.FeCodDoc).HasColumnName("tdo_fe_cod_doc");

            builder.Property(e => e.NombreCorto)
                .HasMaxLength(15)
                .HasColumnName("tdo_nombre_corto");

            builder.Property(e => e.NombreDocumento)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("tdo_nombre_documento");

            builder.Property(e => e.Usumod)
                .HasMaxLength(100)
                .HasColumnName("tdo_usumod");
        }
    }
}
