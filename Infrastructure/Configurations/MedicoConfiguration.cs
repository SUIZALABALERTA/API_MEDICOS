using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class MedicoConfiguration : IEntityTypeConfiguration<MstMedico>
    {
        public void Configure(EntityTypeBuilder<MstMedico> builder)
        {
            builder.HasKey(e => e.Id)
                    .HasName("MST_MEDICO_pkey");

            builder.ToTable("MST_MEDICO", "suizasoft");

            builder.Property(e => e.Id).HasColumnName("med_id");

            builder.Property(e => e.AccesoWeb).HasColumnName("med_acceso_web");

            builder.Property(e => e.ApellidoMaterno)
                .HasColumnType("character varying")
                .HasColumnName("med_apellido_materno");

            builder.Property(e => e.ApellidoPaterno)
                .HasColumnType("character varying")
                .HasColumnName("med_apellido_paterno");

            builder.Property(e => e.ColegioCodigo)
                .HasColumnType("character varying")
                .HasColumnName("med_colegio_codigo");

            builder.Property(e => e.ConsultorioDireccion)
                .HasColumnType("character varying")
                .HasColumnName("med_consultorio_direccion");

            builder.Property(e => e.ConsultorioReferencia)
                .HasColumnType("character varying")
                .HasColumnName("med_consultorio_referencia");

            builder.Property(e => e.Correo)
                .HasColumnType("character varying")
                .HasColumnName("med_correo");

            builder.Property(e => e.Direccion)
                .HasColumnType("character varying")
                .HasColumnName("med_direccion");

            builder.Property(e => e.DireccionReferencia)
                .HasColumnType("character varying")
                .HasColumnName("med_direccion_referencia");

            builder.Property(e => e.Estado).HasColumnName("med_estado");

            builder.Property(e => e.FechaInscripcion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("med_fecha_inscripcion");

            builder.Property(e => e.FechaNacimiento).HasColumnName("med_fecha_nacimiento");

            builder.Property(e => e.IdColegioTipo).HasColumnName("med_id_colegio_tipo");

            builder.Property(e => e.IdPromotor).HasColumnName("med_id_promotor");

            builder.Property(e => e.IdSexo).HasColumnName("med_id_sexo");

            builder.Property(e => e.IdTipo).HasColumnName("med_id_tipo");

            builder.Property(e => e.IdTipoDocumento).HasColumnName("med_id_tipo_documento");

            builder.Property(e => e.IdUbigeo).HasColumnName("med_id_ubigeo");

            builder.Property(e => e.IdUbigeoConsultorio).HasColumnName("med_id_ubigeo_consultorio");

            builder.Property(e => e.ImageRuta)
                .HasColumnType("character varying")
                .HasColumnName("med_image_ruta");

            builder.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("med_nombre");

            builder.Property(e => e.NumeroDocumento)
                .HasColumnType("character varying")
                .HasColumnName("med_numero_documento");

            builder.Property(e => e.PasswordWeb)
                .HasColumnType("character varying")
                .HasColumnName("med_password_web");

            builder.Property(e => e.TelefonoCasa)
                .HasColumnType("character varying")
                .HasColumnName("med_telefono_casa");

            builder.Property(e => e.TelefonoMovil)
                .HasColumnType("character varying")
                .HasColumnName("med_telefono_movil");

            builder.Property(e => e.UsuarioWeb)
                .HasColumnType("character varying")
                .HasColumnName("med_usuario_web");

            builder.Property(e => e.Linkedin)
              .HasColumnType("character varying")
              .HasColumnName("med_linkedin");

            builder.Property(e => e.Doctoralia)
               .HasColumnType("character varying")
               .HasColumnName("med_doctoralia");

            builder.Property(e => e.Twitter)
                .HasColumnType("character varying")
                .HasColumnName("med_twitter");

            builder.Property(e => e.FechaCreacion)
                  .HasColumnType("timestamp without time zone")
                  .HasColumnName("med_fecha_creacion");

            builder.Property(e => e.FechaModificacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("med_fecha_modificacion");

            builder.Property(e => e.UsuarioCreacion)
              .HasColumnType("character varying")
              .HasColumnName("med_usuario_creacion");

            builder.Property(e => e.UsuarioModificacion)
                .HasColumnType("character varying")
                .HasColumnName("med_usuario_modificacion");

            builder.Property(e => e.NombreCompleto)
               .HasColumnType("character varying")
               .HasColumnName("med_nombre_completo");

            builder.Property(e => e.Rne)
             .HasColumnType("character varying")
             .HasColumnName("med_rne");

            builder.Property(e => e.Rna)
             .HasColumnType("character varying")
             .HasColumnName("med_rna");

            builder.HasOne(d => d.XMedicoColegiatura)
                .WithMany(p => p.MstMedicos)
                .HasForeignKey(d => d.IdColegioTipo)
                .HasConstraintName("MST_MEDICO_med_id_colegio_tipo_fkey");

            builder.HasOne(d => d.XPromotor)
                .WithMany(p => p.MstMedicos)
                .HasForeignKey(d => d.IdPromotor)
                .HasConstraintName("MST_MEDICO_med_id_promotor_fkey");

            builder.HasOne(d => d.XSexo)
                .WithMany(p => p.XMedicos)
                .HasForeignKey(d => d.IdSexo)
                .HasConstraintName("MST_MEDICO_med_id_sexo_fkey");

            builder.HasOne(d => d.XMedicoTipo)
                .WithMany(p => p.MstMedicos)
                .HasForeignKey(d => d.IdTipo)
                .HasConstraintName("MST_MEDICO_med_id_tipo_fkey");

            builder.HasOne(d => d.XTipoDocumento)
                .WithMany(p => p.XMedicos)
                .HasForeignKey(d => d.IdTipoDocumento)
                .HasConstraintName("MST_MEDICO_med_id_tipo_documento_fkey");

            builder.HasOne(d => d.XUbigeo)
                .WithMany(p => p.XMedicoUbigeo)
                .HasForeignKey(d => d.IdUbigeo)
                .HasConstraintName("MST_MEDICO_med_id_ubigeo_fkey");

            builder.HasOne(d => d.XUbigeoConsultorio)
                .WithMany(p => p.XMedicoUbigeoConsultorio)
                .HasForeignKey(d => d.IdUbigeoConsultorio)
                .HasConstraintName("MST_MEDICO_med_id_ubigeo_consultorio_fkey");
        }
    }
}
