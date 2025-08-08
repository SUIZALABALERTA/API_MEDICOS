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
    public class DetMedicoRolCentroMedicoConfiguration : IEntityTypeConfiguration<DetMedicoRolCentroMedico>
    {
        public void Configure(EntityTypeBuilder<DetMedicoRolCentroMedico> builder)
        {
            builder.HasKey(e => new { e.IdRol, e.IdMedico }).HasName("DET_MEDICO_ROL_CENTRO_MEDICO_pkey");

            builder.ToTable("DET_MEDICO_ROL_CENTRO_MEDICO", "suizasoft");

            builder.Property(e => e.IdRol).HasColumnName("dmr_cm_id_rol");
            builder.Property(e => e.IdMedico).HasColumnName("dmr_cm_id_medico");
            builder.Property(e => e.Estado).HasColumnName("dcm_estado");
            builder.Property(e => e.FechaCreacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dcm_fecha_creacion");
            builder.Property(e => e.FechaModificacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dcm_fecha_modificacion");
            builder.Property(e => e.UsuarioCreacion)
                .IsRequired()
                .HasColumnType("character varying")
                .HasColumnName("dcm_usuario_creacion");
            builder.Property(e => e.UsuarioModificacion)
                .HasColumnType("character varying")
                .HasColumnName("dcm_usuario_modificacion");

            builder.HasOne(d => d.XMedico).WithMany(p => p.XMedicoRol)
                .HasForeignKey(d => d.IdMedico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DET_MEDICO_ROL_CENTRO_MEDICO_dmr_cm_id_medico_fkey");

            builder.HasOne(d => d.XRol).WithMany(p => p.XMedicoRolCentroMedico)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DET_MEDICO_ROL_CENTRO_MEDICO_dmr_cm_id_rol_fkey");
        }
    }
}
