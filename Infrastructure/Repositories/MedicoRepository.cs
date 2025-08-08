using Application.Common;
using Application.Interfaces.IRepository;
using Application.Interfaces.IServices;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.DTO;
using Domain.Entities;
using Domain.Enumerations;
using Domain.Models;
using Domain.Payloads;
using Domain.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security.Claims;

namespace Infrastructure.Repositories;


public class MedicoRepository : IMedicoRepository
{

    private readonly SuizasoftContext _context;

    private readonly IMapper _mapper;

    private readonly ISaveFilesAwsService _saveFilesAwsService;

    private readonly IHttpContextAccessor? _httpContextAccessor;


    public MedicoRepository(SuizasoftContext dataContext, IMapper mapper, ISaveFilesAwsService saveFilesAwsService, IHttpContextAccessor? httpContextAccessor)
    {
        _context = dataContext;
        _mapper = mapper;
        _saveFilesAwsService = saveFilesAwsService;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<(ServiceStatus, MedicoDTO)> GetAllMedic(string numDoc)
    {

        MedicoDTO entidad = null;
        try
        {
            entidad = await _context.MstMedicos.AsNoTracking().Where(p => p.NumeroDocumento == numDoc)
                                                             .OrderByDescending(p => p.FechaCreacion)
                                                             .ProjectTo<MedicoDTO>(_mapper.ConfigurationProvider)
                                                             .FirstOrDefaultAsync();

            if (entidad == null) return (ServiceStatus.NotFound, null);
        }
        catch (Exception e)
        {
            return (ServiceStatus.InternalError, null);
        }
        return (ServiceStatus.Ok, entidad);

    }

    public async Task<(ServiceStatus, string)> FastCheckMedico(string docNumber)
    {
        bool isExists = false;

        try
        {
            isExists = await _context.MstMedicos.AnyAsync(doc => doc.NumeroDocumento == docNumber);

            if (!isExists)
                return (ServiceStatus.NotFound, "Medico No Encontrado");

        }

        catch (Exception e)
        {
            return (ServiceStatus.InternalError, "Error interno" + e);
        }

        return (ServiceStatus.Ok, "Success");

    }

    public async Task<(ServiceStatus, MedicoDTO, string)> CheckMedico(string docNumber)
    {

        try
        {
            var companyDTO = await _context.MstMedicos.AsNoTracking()
                                                      .Where(p => p.NumeroDocumento == docNumber)
                                                      .ProjectTo<MedicoDTO>(_mapper.ConfigurationProvider)
                                                      .SingleOrDefaultAsync();

            if (companyDTO is not null) return (ServiceStatus.Ok, companyDTO, "Medico existe");

        }

        catch (Exception e)
        {
            return (ServiceStatus.InternalError, null, $"Error Interno - {e.Message}");
        }

        return (ServiceStatus.NotFound, null, "No se encontro datos del medico");

    }
    //public async Task<(ServiceStatus, DataCollection<MedicoDTO>, string)> SearchMedicodatosAsync(string ColegioCodigo, string NombreCompleto, string ApellidoPaterno, string ApellidoMaterno, string value, int page, int amount, string records)
    //{
    //    DataCollection<MedicoDTO> entidades = new();

    //    long result;

    //    string valueUppered = "";

    //    var isNumeric = Int64.TryParse(value, out result);

    //    if (value != null) valueUppered = value.ToUpper();

    //    try
    //    {
    //        if (!string.IsNullOrWhiteSpace(NombreCompleto) ||
    //            !string.IsNullOrWhiteSpace(ApellidoPaterno) ||
    //            !string.IsNullOrWhiteSpace(ApellidoMaterno) ||
    //            !string.IsNullOrWhiteSpace(ColegioCodigo))
    //        {
    //            entidades = await _context.MstMedicos.AsNoTracking()
    //                                                .Where(p => p.ColegioCodigo == ColegioCodigo)
    //                                                .Where(p => p.Nombre == NombreCompleto)
    //                                                .Where(p => p.ApellidoPaterno == ApellidoPaterno)
    //                                                .Where(p => p.ApellidoMaterno == ApellidoMaterno)
    //                                                .OrderByDescending(p => p.FechaCreacion)
    //                                                .ProjectTo<MedicoDTO>(_mapper.ConfigurationProvider)
    //                                                .GetPagedAsync(page, amount);

    //        }

    //        if (entidades.HasItems)
    //        {
    //            foreach (var (item, index) in entidades.Items.WithCustomIndex())
    //            {
    //                item.Index = (page * amount) - amount + index;
    //            }

    //            return (ServiceStatus.Ok, entidades, "Succeeded");
    //        }
    //    }

    //    catch (Exception e)
    //    {
    //        return (ServiceStatus.InternalError, null, e.Message);
    //    }

    //    return (ServiceStatus.NotFound, new DataCollection<MedicoDTO> { Items = new List<MedicoDTO>() }, "No se encontraron registros");
    //}

    public async Task<(ServiceStatus, DataCollection<MedicoDTO>, string)> SearchMedicodatosAsync(
    string ColegioCodigo,
    string NombreCompleto,
    string ApellidoPaterno,
    string ApellidoMaterno,
    string value,
    int page,
    int amount,
    string records)
    {
        try
        {
            // 1. Empezamos con una consulta base (IQueryable) que iremos modificando.
            var query = _context.MstMedicos.AsNoTracking();

            // 2. Verificamos si se está haciendo una búsqueda por campos específicos.
            bool isSpecificSearch = !string.IsNullOrWhiteSpace(ColegioCodigo) ||
                                    !string.IsNullOrWhiteSpace(NombreCompleto) ||
                                    !string.IsNullOrWhiteSpace(ApellidoPaterno) ||
                                    !string.IsNullOrWhiteSpace(ApellidoMaterno);

            if (isSpecificSearch)
            {
                // Búsqueda por campos específicos:
                // Añadimos filtros dinámicamente solo para los campos que SÍ tienen valor.
                if (!string.IsNullOrWhiteSpace(ColegioCodigo))
                {
                    query = query.Where(p => p.ColegioCodigo.Contains(ColegioCodigo));
                }
                if (!string.IsNullOrWhiteSpace(NombreCompleto))
                {
                    // Nota: Tu entidad parece usar 'Nombre' y no 'NombreCompleto'. Ajusta si es necesario.
                    query = query.Where(p => p.Nombre.ToUpper().Contains(NombreCompleto.ToUpper()));
                }
                if (!string.IsNullOrWhiteSpace(ApellidoPaterno))
                {
                    query = query.Where(p => p.ApellidoPaterno.ToUpper().Contains(ApellidoPaterno.ToUpper()));
                }
                if (!string.IsNullOrWhiteSpace(ApellidoMaterno))
                {
                    query = query.Where(p => p.ApellidoMaterno.ToUpper().Contains(ApellidoMaterno.ToUpper()));
                }
            }
            else if (!string.IsNullOrWhiteSpace(value))
            {
                // Búsqueda general (si no se usaron los campos específicos)
                // Esta es la lógica que tenías en métodos anteriores.
                var isNumeric = long.TryParse(value, out _);
                if (isNumeric)
                {
                    query = query.Where(p => p.NumeroDocumento.Contains(value));
                }
                else
                {
                    string valueUpper = value.ToUpper();
                    query = query.Where(p => p.NombreCompleto.ToUpper().Contains(valueUpper));
                }
            }

            // 3. Aplicamos el filtro de estado (Activos/Inactivos/Todos)
            if (records == "A")
            {
                query = query.Where(p => p.Estado == true);
            }
            else if (records == "I")
            {
                query = query.Where(p => p.Estado == false);
            }

            // 4. Finalmente, ordenamos, proyectamos y ejecutamos la consulta paginada.
            var entidades = await query.OrderByDescending(p => p.FechaCreacion)
                                       .ProjectTo<MedicoDTO>(_mapper.ConfigurationProvider)
                                       .GetPagedAsync(page, amount);

            if (entidades.HasItems)
            {
                foreach (var (item, index) in entidades.Items.WithCustomIndex())
                {
                    item.Index = (page * amount) - amount + index;
                }
                return (ServiceStatus.Ok, entidades, "Succeeded");
            }

            return (ServiceStatus.NotFound, new DataCollection<MedicoDTO>(), "No se encontraron registros");
        }
        catch (Exception e)
        {
            return (ServiceStatus.InternalError, null, e.Message);
        }
    }

    public async Task<(ServiceStatus, DataCollection<MedicoDTO>, string)> SearchMedico(string value, int page, int amount, string records, int idTipoMedico, List<int> idEspecialidades)
    {

        DataCollection<MedicoDTO> entidades = new();

        long result;

        string valueUppered = "";

        var isNumeric = Int64.TryParse(value, out result);

        if (value != null) valueUppered = value.ToUpper();

        try
        {
            if (records == "T")
            {


                if (string.IsNullOrEmpty(value))
                {

                    entidades = await _context.MstMedicos.AsNoTracking()
                                                         .WhereIf(idTipoMedico != 0, p => p.IdTipo == idTipoMedico)
                                                         .WhereIf(idTipoMedico != 0, p => p.IdTipo == idTipoMedico)
                                                         .WhereIf(idEspecialidades.Count > 0, p => p.XMedicoAreaNegocios.Any(e => idEspecialidades.Contains(e.IdAreaNegocio)))
                                                         .WhereIf(idEspecialidades.Count != 0 && idTipoMedico != 0, p => p.XMedicoAreaNegocios.Any(e => idEspecialidades.Contains(e.IdAreaNegocio)) && p.IdTipo == idTipoMedico)
                                                         .OrderByDescending(p => p.FechaCreacion)
                                                         .ProjectTo<MedicoDTO>(_mapper.ConfigurationProvider)
                                                         .GetPagedAsync(page, amount);

                }
                else
                {

                    if (isNumeric)
                    {
                        entidades = await _context.MstMedicos.AsNoTracking()
                                                             .Where(p => p.NumeroDocumento.Contains(result.ToString()))
                                                             .OrderByDescending(p => p.FechaCreacion)
                                                             .ProjectTo<MedicoDTO>(_mapper.ConfigurationProvider)
                                                             .GetPagedAsync(page, amount);
                    }
                    else
                    {

                        entidades = await _context.MstMedicos.AsNoTracking()
                                                             .WhereIf(idEspecialidades.Count != 0 && idTipoMedico != 0, p => p.XMedicoAreaNegocios.Any(e => idEspecialidades.Contains(e.IdAreaNegocio)) && p.IdTipo == idTipoMedico && p.NombreCompleto.Contains(valueUppered))
                                                             .WhereIf(idEspecialidades.Count > 0, p => p.XMedicoAreaNegocios.Any(e => idEspecialidades.Contains(e.IdAreaNegocio)) && p.NombreCompleto.Contains(valueUppered))
                                                             .WhereIf(idTipoMedico != 0, p => p.IdTipo == idTipoMedico && p.NombreCompleto.Contains(valueUppered))
                                                             .Where(p => p.NombreCompleto.Contains(valueUppered))
                                                             .OrderByDescending(p => p.FechaCreacion)
                                                             .ProjectTo<MedicoDTO>(_mapper.ConfigurationProvider)
                                                             .GetPagedAsync(page, amount);

                    }

                }
            }
            else if (records == "A")
            {
                if (string.IsNullOrEmpty(value))
                {
                    entidades = await _context.MstMedicos.Where(p => p.Estado == true)
                                                         .OrderByDescending(p => p.FechaCreacion)
                                                         .ProjectTo<MedicoDTO>(_mapper.ConfigurationProvider)
                                                         .GetPagedAsync(page, amount);
                }
                else
                {

                    if (isNumeric)
                    {
                        entidades = await _context.MstMedicos.Where(p => p.NumeroDocumento.Contains(result.ToString()) && p.Estado == true)
                                                             .OrderByDescending(p => p.FechaCreacion)
                                                             .ProjectTo<MedicoDTO>(_mapper.ConfigurationProvider)
                                                             .GetPagedAsync(page, amount);
                    }
                    else
                    {
                        entidades = await _context.MstMedicos.Where(p => p.NombreCompleto.Contains(valueUppered) && p.Estado == true)
                                                         .OrderByDescending(p => p.FechaCreacion)
                                                         .ProjectTo<MedicoDTO>(_mapper.ConfigurationProvider)
                                                         .GetPagedAsync(page, amount);
                    }

                }

            }
            else if (records == "I")
            {
                if (string.IsNullOrEmpty(value))
                {
                    entidades = await _context.MstMedicos.Where(p => p.Estado == false)
                                                         .OrderByDescending(p => p.FechaCreacion)
                                                         .ProjectTo<MedicoDTO>(_mapper.ConfigurationProvider)
                                                         .GetPagedAsync(page, amount);
                }
                else
                {

                    if (isNumeric)
                    {
                        entidades = await _context.MstMedicos.Where(p => p.NumeroDocumento.Contains(result.ToString()) && p.Estado == false)
                                                             .OrderByDescending(p => p.FechaCreacion)
                                                             .ProjectTo<MedicoDTO>(_mapper.ConfigurationProvider)
                                                             .GetPagedAsync(page, amount);
                    }
                    else
                    {

                        entidades = await _context.MstMedicos.Where(p => p.NombreCompleto.Contains(valueUppered) && p.Estado == false)
                                                             .OrderByDescending(p => p.FechaCreacion)
                                                             .ProjectTo<MedicoDTO>(_mapper.ConfigurationProvider)
                                                             .GetPagedAsync(page, amount);
                    }
                }

            }


            if (entidades.HasItems)
            {
                foreach (var (item, index) in entidades.Items.WithCustomIndex())
                {
                    item.Index = (page * amount) - amount + index;
                }

                return (ServiceStatus.Ok, entidades, "Succeeded");
            }

        }

        catch (Exception e)
        {
            return (ServiceStatus.InternalError, null, e.Message);
        }

        return (ServiceStatus.NotFound, new DataCollection<MedicoDTO> { Items = new List<MedicoDTO>() }, "No se encontraron registros");

    }

    //public async Task<(ServiceStatus, MedicoDTO, string)> CreateMedico(CreateMedicoPayload newMedico)
    //{
    //    MstMedico medico = new();

    //    try
    //    {
    //        newMedico.Nombre = newMedico.Nombre.ToUpper();
    //        newMedico.ApellidoPaterno = newMedico.ApellidoPaterno.ToUpper();
    //        newMedico.ApellidoMaterno = newMedico.ApellidoMaterno.ToUpper();

    //        medico = _mapper.Map<MstMedico>(newMedico);

    //        medico.NombreCompleto = $"{newMedico.ApellidoPaterno} {newMedico.ApellidoMaterno} {newMedico.Nombre}";

    //        if (newMedico.IdTipoDocumento == Utils.TipoDocumento.Dni)
    //        {
    //            medico.UsuarioWeb = newMedico.NumeroDocumento;
    //            medico.PasswordWeb = Utils.GeneratePassword(newMedico.NumeroDocumento);
    //        }

    //        _context.Add(medico);

    //        //ADD ROL
    //        var medicRol = await _context.MstRolCentroMedicos.AsNoTracking().FirstOrDefaultAsync(x => x.RolCmDescripcion == "Medico");
    //        if (medicRol != null)
    //        {
    //            var newMedicRol = new DetMedicoRolCentroMedico
    //            {
    //                IdRol = medicRol.RolCmId,
    //                //IdMedico = medico.Id, //No genera el id hasta que se guarde
    //                Estado = true,
    //                FechaCreacion = DateTime.UtcNow.AddHours(-5),
    //                UsuarioCreacion = _httpContextAccessor!.HttpContext!.User.FindFirstValue("username").ToUpper(),
    //                XMedico = medico
    //            };
    //            _context.Add(newMedicRol);
    //        }

    //        await _context.SaveChangesAsync();

    //        var estado3 = _context.Entry(medico).State;

    //        if (_context.Entry(medico).State != EntityState.Unchanged)

    //            return (ServiceStatus.FailedValidation, null, "Error al crear");
    //    }

    //    catch (Exception e)
    //    {
    //        return (ServiceStatus.InternalError, null, $"Error Interno {e.Message} || {e.InnerException}");
    //    }

    //    var (estado, medicum) = await GetAllMedic(newMedico.NumeroDocumento);

    //    return (ServiceStatus.Ok, medicum, "Se creó un nuevo Medico");
    //}

    public async Task<(ServiceStatus, MedicoDTO, string)> CreateMedico(CreateMedicoPayload newMedico)
    {
        try
        {
            // --- INICIO DE VALIDACIONES ---

            // 1. Validar que los campos de texto principales no estén vacíos.
            if (string.IsNullOrWhiteSpace(newMedico.Nombre) ||
                string.IsNullOrWhiteSpace(newMedico.ApellidoPaterno) ||
                string.IsNullOrWhiteSpace(newMedico.ApellidoMaterno))
            {
                return (ServiceStatus.FailedValidation, null, "El nombre y los apellidos son campos obligatorios.");
            }

            // 2. Validar que sean alfanuméricos (permitiendo espacios y caracteres en español).
            if (!EsAlfanumericoValido(newMedico.Nombre) ||
                !EsAlfanumericoValido(newMedico.ApellidoPaterno) ||
                !EsAlfanumericoValido(newMedico.ApellidoMaterno))
            {
                return (ServiceStatus.FailedValidation, null, "El nombre y los apellidos solo pueden contener letras, números y espacios.");
            }

            // 3. Validar que el Colegio Médico exista y sea único.
            if (string.IsNullOrWhiteSpace(newMedico.ColegioCodigo))
            {
                return (ServiceStatus.FailedValidation, null, "El código de colegio médico es obligatorio.");
            }

            bool colegioYaExiste = await _context.MstMedicos.AsNoTracking()
                                          .AnyAsync(m => m.ColegioCodigo == newMedico.ColegioCodigo);
            if (colegioYaExiste)
            {
                return (ServiceStatus.FailedValidation, null, $"El código de colegio '{newMedico.ColegioCodigo}' ya está registrado. Por favor, verifique los datos.");
            }

            // --- FIN DE VALIDACIONES ---


            // Si todas las validaciones pasan, continuamos con la lógica original.
            MstMedico medico = new();

            newMedico.Nombre = newMedico.Nombre.ToUpper().Trim();
            newMedico.ApellidoPaterno = newMedico.ApellidoPaterno.ToUpper().Trim();
            newMedico.ApellidoMaterno = newMedico.ApellidoMaterno.ToUpper().Trim();

            medico = _mapper.Map<MstMedico>(newMedico);

            medico.NombreCompleto = $"{newMedico.ApellidoPaterno} {newMedico.ApellidoMaterno} {newMedico.Nombre}";

            if (newMedico.IdTipoDocumento == Utils.TipoDocumento.Dni)
            {
                medico.UsuarioWeb = newMedico.NumeroDocumento;
                medico.PasswordWeb = Utils.GeneratePassword(newMedico.NumeroDocumento);
            }

            _context.Add(medico);

            // ADD ROL
            var medicRol = await _context.MstRolCentroMedicos.AsNoTracking().FirstOrDefaultAsync(x => x.RolCmDescripcion == "Medico");
            if (medicRol != null)
            {
                var newMedicRol = new DetMedicoRolCentroMedico
                {
                    IdRol = medicRol.RolCmId,
                    Estado = true,
                    FechaCreacion = DateTime.UtcNow.AddHours(-5),
                    UsuarioCreacion = _httpContextAccessor!.HttpContext!.User.FindFirstValue("username").ToUpper(),
                    XMedico = medico
                };
                _context.Add(newMedicRol);
            }

            await _context.SaveChangesAsync();

            // Ya no necesitas esta validación, SaveChangesAsync arrojará una excepción si falla.
            // if (_context.Entry(medico).State != EntityState.Unchanged)
            //     return (ServiceStatus.FailedValidation, null, "Error al crear");

            var (estado, medicum) = await GetAllMedic(newMedico.NumeroDocumento);
            return (ServiceStatus.Ok, medicum, "Se creó un nuevo Medico");
        }
        catch (Exception e)
        {
            return (ServiceStatus.InternalError, null, $"Error Interno {e.Message} || {e.InnerException}");
        }
    }

    // === MÉTODO DE AYUDA PARA VALIDACIÓN ALFANUMÉRICA ===
    // Puedes agregar este método privado a tu clase para mantener el código limpio.
    private bool EsAlfanumericoValido(string texto)
    {
        if (string.IsNullOrEmpty(texto)) return false;
        // Esta expresión regular permite letras (incluyendo ñ y acentos), números y espacios.
        // ^ -> inicio de la cadena
        // $ -> fin de la cadena
        return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-Z0-9\sñáéíóúÁÉÍÓÚ]+$");
    }

    public async Task<(ServiceStatus, MedicoDTO, string)> UpdateMedico(UpdateMedicoPayload newEntity)
    {
        MstMedico medico = new();

        try
        {
            medico = await _context.MstMedicos.AsTracking()
                                              .Include(x => x.XMedicoAreaNegocios)
                                              .Include(x => x.XMedicoRol)
                                              .FirstOrDefaultAsync(p => p.NumeroDocumento == newEntity.NumeroDocumento);

            medico = _mapper.Map(newEntity, medico);
            medico.NombreCompleto = $"{newEntity.ApellidoPaterno} {newEntity.ApellidoMaterno} {newEntity.Nombre}";
            medico.FechaNacimiento = Utils.ConvertDate(newEntity.FechaNacimiento);

            //Registro de especialidades
            SaveSpecialties(medico, newEntity.Specialties);

            //Registro de roles
            SaveRoles(medico, newEntity.Roles);

            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            return (ServiceStatus.InternalError, null, "Error al Actualizar" + e.Message);
        }

        var (estado, medicum) = await GetAllMedic(newEntity.NumeroDocumento);

        return (ServiceStatus.Ok, medicum, "Medico Actualizado");
    }

    public async Task<(ServiceStatus, string, string)> UpdateImage(Attachment attachment)
    {
        string attachmentPath = null;
        var formatResult = "";
        var formatExtension = "";

        var formato = attachment.ByteImage.Substring(0, 20);

        if (formato.Contains("jpeg"))
        {
            formatResult = "data:image/jpeg;base64,";
            formatExtension = ".jpeg";
        }
        else if (formato.Contains("jpg"))
        {
            formatResult = "data:image/jpg;base64,";
            formatExtension = ".jpg";
        }
        else
        {
            formatResult = "data:image/png;base64,";
            formatExtension = ".png";
        }

        try
        {
            byte[] imageBytes = Convert.FromBase64String(attachment.ByteImage.Replace(formatResult, string.Empty));

            var result = await _saveFilesAwsService.SaveFileAws(imageBytes, attachment.NumDoc, formatExtension);

            attachmentPath = result.Message;
        }
        catch (Exception ex)
        {
            return (ServiceStatus.InternalError, null, "Error: " + ex + ". Hubo un problema con la imagen, intente renombrar la imagen");
        }

        if (string.IsNullOrEmpty(attachmentPath))

            return (ServiceStatus.InternalError, null, "Error al guardar en  AWS");

        var (status, message) = await PostImageRoute(attachmentPath, attachment.NumDoc);

        if (status != ServiceStatus.Ok)

            return (ServiceStatus.InternalError, null, "Error al guardar base de datos");


        return (ServiceStatus.Ok, attachmentPath, message);
    }

    private async Task<(ServiceStatus, string)> PostImageRoute(string path, string numdoc)
    {
        MstMedico medico = new();

        try
        {
            medico = await _context.MstMedicos.AsTracking()
                                              .FirstOrDefaultAsync(p => p.NumeroDocumento == numdoc);

            medico.ImageRuta = path;

            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            return (ServiceStatus.InternalError, "Hubo un error al guardar la imagen en la base de datos" + ex.Message);
        }

        return (ServiceStatus.Ok, "La imagen fue cargada a AWS exitosamente");
    }

    public async Task<(ServiceStatus, object, string)> GetMedicoTipo()
    {
        try
        {
            var entity = await _context.TipMedicos.AsNoTracking()
                                                  .Select(a => new { id = a.Id, nombre = a.Nombre, descripccion = a.Descripccion })
                                                  .ToListAsync();

            return (ServiceStatus.Ok, entity, "Exito");

        }

        catch (Exception e)
        {
            return (ServiceStatus.InternalError, null, "Error Interno" + e);
        }

    }
    public async Task<(ServiceStatus, object, string)> GetColegioTipo()
    {
        try
        {
            var entity = await _context.TipMedicoColegiaturas.AsNoTracking()
                                                  .Select(a => new { id = a.Id, nombre = a.Nombre, descripccion = a.Descripcion })
                                                  .ToListAsync();

            return (ServiceStatus.Ok, entity, "Exito");

        }

        catch (Exception e)
        {
            return (ServiceStatus.InternalError, null, "Error Interno" + e);
        }

    }
    public async Task<(ServiceStatus, object, string)> GetEspecialidad()
    {
        try
        {
            var entity = await _context.MstServicioAreaNegocios.AsNoTracking()
                                                  .Select(a => new { id = a.SeaId, nombre = a.SeaDescripcion })
                                                  .ToListAsync();

            return (ServiceStatus.Ok, entity, "Exito");

        }

        catch (Exception e)
        {
            return (ServiceStatus.InternalError, null, "Error Interno" + e);
        }

    }

    public async Task<(ServiceStatus, object, string)> GetRoles()
    {
        try
        {
            var entity = await _context.MstRolCentroMedicos.AsNoTracking()
                                                  .Select(a => new { id = a.RolCmId, value = a.RolCmDescripcion })
                                                  .ToListAsync();

            return (ServiceStatus.Ok, entity, "Exito");

        }

        catch (Exception e)
        {
            return (ServiceStatus.InternalError, null, "Error Interno" + e);
        }

    }

    private void SaveSpecialties(MstMedico medico, IEnumerable<int> specialties)
    {
        if (specialties == null)
            return;

        var specialtiesRemove = medico.XMedicoAreaNegocios.Where(x => !specialties.Contains(x.IdAreaNegocio));
        foreach (var specialty in specialtiesRemove)
        {
            medico.XMedicoAreaNegocios.Remove(specialty);
        }

        var specialtiesBDIds = medico.XMedicoAreaNegocios.Select(x => x.IdAreaNegocio);
        var newSpecialties = specialties
                                     .Where(x => !specialtiesBDIds.Contains(x))
                                     .Select(x => new DetMedicoAreaNegocio
                                     {
                                         IdMedico = medico.Id,
                                         IdAreaNegocio = x,
                                         Estado = true,
                                         FechaCreacion = DateTime.UtcNow.AddHours(-5),
                                         UsuarioCreacion = _httpContextAccessor!.HttpContext!.User.FindFirstValue("username").ToUpper()
                                     });

        foreach (var specialtie in newSpecialties)
        {
            medico.XMedicoAreaNegocios.Add(specialtie);
        }
    }

    private void SaveRoles(MstMedico medico, IEnumerable<int> roles)
    {
        if (roles == null)
            return;

        var rolsRemove = medico.XMedicoRol.Where(x => !roles.Contains(x.IdRol));
        foreach (var rol in rolsRemove)
        {
            medico.XMedicoRol.Remove(rol);
        }

        var rolsBdIds = medico.XMedicoRol.Select(x => x.IdRol);
        var newRoles = roles
                            .Where(x => !rolsBdIds.Contains(x))
                            .Select(x => new DetMedicoRolCentroMedico
                            {
                                IdMedico = medico.Id,
                                IdRol = x,
                                Estado = true,
                                FechaCreacion = DateTime.UtcNow.AddHours(-5),
                                UsuarioCreacion = _httpContextAccessor!.HttpContext!.User.FindFirstValue("username").ToUpper()
                            });

        foreach (var rol in newRoles)
        {
            medico.XMedicoRol.Add(rol);
        }
    }
}
