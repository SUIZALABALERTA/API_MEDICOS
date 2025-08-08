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
    public class MstRolCentroMedicoConfiguration : IEntityTypeConfiguration<MstRolCentroMedico>
    {
        public void Configure(EntityTypeBuilder<MstRolCentroMedico> builder)
        {
            builder.HasKey(e => e.RolCmId).HasName("rol_centro_medico_id_pk");

            builder.ToTable("MST_ROL_CENTRO_MEDICO", "suizasoft");

            builder.Property(e => e.RolCmId).HasColumnName("rol_cm_id");
            builder.Property(e => e.RolCmDescripcion)
                .HasMaxLength(30)
                .HasColumnName("rol_cm_descripcion");
            builder.Property(e => e.RolCmEstado).HasColumnName("rol_cm_estado");
        }
    }
}
