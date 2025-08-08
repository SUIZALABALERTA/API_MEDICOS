using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class DetMedicoAreaNegocioConfiguration : IEntityTypeConfiguration<DetMedicoAreaNegocio>
    {
        public void Configure(EntityTypeBuilder<DetMedicoAreaNegocio> builder)
        {
            builder.HasKey(e => new { e.IdMedico, e.IdAreaNegocio }).HasName("DET_MEDICO_AREA_NEGOCIO_pkey");

            builder.ToTable("DET_MEDICO_AREA_NEGOCIO", "suizasoft");

            builder.Property(e => e.IdMedico).HasColumnName("dman_id_medico");
            builder.Property(e => e.IdAreaNegocio).HasColumnName("dman_id_area_negocio");
            builder.Property(e => e.Estado).HasColumnName("dman_estado");
            builder.Property(e => e.FechaCreacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dman_fecha_creacion");
            builder.Property(e => e.FechaModificacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dman_fecha_modificacion");
            builder.Property(e => e.UsuarioCreacion)
                .IsRequired()
                .HasColumnType("character varying")
                .HasColumnName("dman_usuario_creacion");
            builder.Property(e => e.UsuarioModificacion)
                .HasColumnType("character varying")
                .HasColumnName("dman_usuario_modificacion");

            builder.HasOne(d => d.XMedico).WithMany(p => p.XMedicoAreaNegocios)
                .HasForeignKey(d => d.IdMedico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DET_MEDICO_AREA_NEGOCIO_dman_id_medico_fkey");

            builder.HasOne(d => d.DmanIdAreaNegocioNavigation)
                .WithMany(p => p.DetMedicoAreaNegocios)
                .HasForeignKey(d => d.IdAreaNegocio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DET_MEDICO_AREA_NEGOCIO_dman_id_area_negocio_fkey");

        }
    }
}
