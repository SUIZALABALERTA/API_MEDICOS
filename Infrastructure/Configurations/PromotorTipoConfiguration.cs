using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class PromotorTipoConfiguration : IEntityTypeConfiguration<TipPromotor>
    {
        public void Configure(EntityTypeBuilder<TipPromotor> entity)
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
        }
    }
}
