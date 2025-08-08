using AutoMapper;
using Domain.Constants;
using Domain.DTO;
using Domain.Entities;
using Domain.Payloads;

namespace Domain.Common.Mappings;

public class MyAutomapper : Profile
{
    public MyAutomapper()
    {
        CreateMap<CreateMedicoPayload, MstMedico>()    //1
                .ForMember(x => x.FechaNacimiento, y => y.MapFrom(z => string.IsNullOrEmpty(z.FechaNacimiento) ? (DateTime?)null : Utils.Utils.ConvertDate(z.FechaNacimiento)))
                .ForMember(x => x.FechaInscripcion, y => y.MapFrom(z => string.IsNullOrEmpty(z.FechaInscripcion) ? (DateTime?)null : Utils.Utils.ConvertDate(z.FechaInscripcion)));

        CreateMap<MstMedico, MedicoDTO>()               //2
                .ForMember(x => x.Index, y => y.MapFrom(z => 1))
                .ForMember(x => x.TipoDocumento, y => y.MapFrom(z => z.XTipoDocumento.NombreCorto))
                .ForMember(x => x.Sexo, y => y.MapFrom(z => z.XSexo.Descripcion))

                .ForMember(x => x.FechaNacimiento, y => y.MapFrom(
                    z => z.FechaNacimiento.HasValue ? z.FechaNacimiento.Value.ToString("dd/MM/yyyy") : null))
                .ForMember(x => x.FechaInscripcion, y => y.MapFrom(
                    z => z.FechaInscripcion.HasValue ? z.FechaInscripcion.Value.ToString("dd/MM/yyyy") : null))

                .ForMember(x => x.UbigeoDireccion, y => y.MapFrom(z => z.XUbigeo.NombreDepartamento + "/" + z.XUbigeo.NombreProvincia + "/" + z.XUbigeo.NombreDistrito))
                .ForMember(x => x.UbigeoDireccionConsultorio, y => y.MapFrom(z => z.XUbigeoConsultorio.NombreDepartamento + "/" + z.XUbigeoConsultorio.NombreProvincia + "/" + z.XUbigeoConsultorio.NombreDistrito))

                .ForMember(x => x.TipoColegio, y => y.MapFrom(z => z.XMedicoColegiatura.Nombre))
                .ForMember(x => x.TipoMedico, y => y.MapFrom(z => z.XMedicoTipo.Nombre))
                .ForMember(x => x.Promotor, y => y.MapFrom(z => z.IdPromotor != null ? (z.XPromotor.ProApellidoPaterno + "/" + z.XPromotor.ProApellidoMaterno + "/" + z.XPromotor.ProNombre) : ""))
                .ForMember(x => x.MovilPromotor, y => y.MapFrom(z => z.IdPromotor != null ? (z.XPromotor.ProTelefonoMovil) : ""))
                .ForMember(x => x.DireccionPromotor, y => y.MapFrom(z => z.IdPromotor != null ? (z.XPromotor.ProDireccion) : ""))
                .ForMember(x => x.TelefonoCasaPromotor, y => y.MapFrom(z => z.IdPromotor != null ? (z.XPromotor.ProTelefonoCasa) : ""));


        CreateMap<DetMedicoAreaNegocio, EspecialodadesDTO>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.IdAreaNegocio))
                .ForMember(x => x.Nombre, y => y.MapFrom(z => z.DmanIdAreaNegocioNavigation.SeaDescripcion));

        CreateMap<DetMedicoRolCentroMedico, RolesDTO>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.IdRol))
               .ForMember(x => x.Nombre, y => y.MapFrom(z => z.XRol.RolCmDescripcion));

        CreateMap<MstOrdenServicioCabecera, OrdenServicioCabeceraDTO>();


        CreateMap<UpdateMedicoPayload, MstMedico>()
                .ForMember(x => x.IdColegioTipo, y => y.MapFrom(z => z.IdTipoColegio))
                .ForMember(x => x.FechaNacimiento, y => y.MapFrom(z => string.IsNullOrEmpty(z.FechaNacimiento) ? (DateTime?)null : Utils.Utils.ConvertDate(z.FechaNacimiento)))
                .ForMember(x => x.FechaInscripcion, y => y.MapFrom(z => string.IsNullOrEmpty(z.FechaInscripcion) ? (DateTime?)null : Utils.Utils.ConvertDate(z.FechaInscripcion)));



        CreateMap<string, GetPersonReniecPayload>()
                  .ForMember(x => x.nuDniUsuario, y => y.MapFrom(z => Constantes.CredencialesReniec.usuarioReniec))
                  .ForMember(x => x.nuRucUsuario, y => y.MapFrom(z => Constantes.CredencialesReniec.rucSuiza))
                  .ForMember(x => x.password, y => y.MapFrom(z => Constantes.CredencialesReniec.claveReniec))
                  .ForMember(x => x.nuDniConsulta, y => y.MapFrom(z => z));

        CreateMap<PatientResultDTO, MedicoDTO>() //4
                   .ForMember(x => x.IdTipoDocumento, y => y.MapFrom(z => Utils.Utils.TipoDocumento.Dni))
                   .ForMember(x => x.TipoDocumento, y => y.MapFrom(z => "DNI"))
                   .ForMember(x => x.NumeroDocumento, y => y.MapFrom(z => z.NumeroDocumento))
                   .ForMember(x => x.Nombre, y => y.MapFrom(z => z.Nombre))
                   .ForMember(x => x.ApellidoPaterno, y => y.MapFrom(z => z.ApellidoPaterno))
                   .ForMember(x => x.ApellidoMaterno, y => y.MapFrom(z => z.ApellidoMaterno))
                   .ForMember(x => x.FechaNacimiento, y => y.MapFrom(z => z.FechaNacimiento))
                   .ForMember(x => x.IdSexo, y => y.MapFrom(z => z.Sexo == Utils.Utils.Genero.M ? 2 : 1))
                   .ForMember(x => x.Sexo, y => y.MapFrom(z => z.Sexo));

        CreateMap<int, DetMedicoRolCentroMedico>()
                   .ForMember(x => x.IdMedico, y => y.MapFrom(z => z))
                   .ForMember(x => x.Estado, y => y.MapFrom(z => true))
                   .ForMember(x => x.FechaCreacion, y => y.MapFrom(z => DateTime.Now))
                   .ForMember(x => x.UsuarioCreacion, y => y.MapFrom(z => "AUTO"));
    }
}