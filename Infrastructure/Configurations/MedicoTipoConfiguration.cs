using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class MedicoTipoConfiguration : IEntityTypeConfiguration<TipMedico>
    {
        public void Configure(EntityTypeBuilder<TipMedico> builder)
        {
            builder.HasKey(e => e.Id)
                  .HasName("TIP_MEDICO_pkey");

            builder.ToTable("TIP_MEDICO", "suizasoft");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("tme_id");

            builder.Property(e => e.Descripccion)
                .HasColumnType("character varying")
                .HasColumnName("tme_descripccion");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnType("character varying")
                .HasColumnName("tme_nombre");
        }
    }
}
