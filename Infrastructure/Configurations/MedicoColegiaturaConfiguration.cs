using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class MedicoColegiaturaConfiguration : IEntityTypeConfiguration<TipMedicoColegiatura>
    {
        public void Configure(EntityTypeBuilder<TipMedicoColegiatura> builder)
        {
            builder.HasKey(e => e.Id)
                    .HasName("TIP_MEDICO_COLEGIATURA_pkey");

            builder.ToTable("TIP_MEDICO_COLEGIATURA", "suizasoft");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("tmc_id");

            builder.Property(e => e.Descripcion)
                .HasColumnType("character varying")
                .HasColumnName("tmc_descripcion");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnType("character varying")
                .HasColumnName("tmc_nombre");
        }
    }
}
