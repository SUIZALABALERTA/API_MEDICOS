using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class SexoConfiguration : IEntityTypeConfiguration<MstSexo>
    {
        public void Configure(EntityTypeBuilder<MstSexo> builder)
        {
            builder.HasKey(e => e.Id)
                    .HasName("MST_SEXO_pkey");

            builder.ToTable("MST_SEXO", "suizasoft");

            builder.Property(e => e.Id).HasColumnName("sex_id");

            builder.Property(e => e.Descripcion)
                .HasColumnType("character varying")
                .HasColumnName("sex_descripcion");
        }
    }
}
