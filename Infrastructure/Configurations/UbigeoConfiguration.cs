using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class UbigeoConfiguration : IEntityTypeConfiguration<MstUbigeo>
    {
        public void Configure(EntityTypeBuilder<MstUbigeo> builder)
        {
            builder.HasKey(e => e.Id)
                   .HasName("ubi_id_pk");

            builder.ToTable("MST_UBIGEO", "suizasoft");

            builder.Property(e => e.Id).HasColumnName("ubi_id");

            builder.Property(e => e.CodigoDepartamento)
                .HasColumnType("character varying")
                .HasColumnName("ubi_codigo_departamento");

            builder.Property(e => e.CodigoDistrito)
                .HasColumnType("character varying")
                .HasColumnName("ubi_codigo_distrito");

            builder.Property(e => e.CodigoProvincia)
                .HasColumnType("character varying")
                .HasColumnName("ubi_codigo_provincia");

            builder.Property(e => e.Estado).HasColumnName("ubi_estado");

            builder.Property(e => e.NombreDepartamento)
                .HasColumnType("character varying")
                .HasColumnName("ubi_nombre_departamento");

            builder.Property(e => e.NombreDistrito)
                .HasColumnType("character varying")
                .HasColumnName("ubi_nombre_distrito");

            builder.Property(e => e.NombreProvincia)
                .HasColumnType("character varying")
                .HasColumnName("ubi_nombre_provincia");
        }
    }
}
