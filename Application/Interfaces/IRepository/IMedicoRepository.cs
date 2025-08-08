using Application.Common;
using Domain.DTO;
using Domain.Entities;
using Domain.Enumerations;
using Domain.Models;
using Domain.Payloads;

namespace Application.Interfaces.IRepository;

public interface IMedicoRepository
{
    Task<(ServiceStatus, MedicoDTO, string)> CheckMedico(string docNumber);
    Task<(ServiceStatus, MedicoDTO, string)> CreateMedico(CreateMedicoPayload newMedico);
    Task<(ServiceStatus, string)> FastCheckMedico(string docNumber);
    Task<(ServiceStatus, DataCollection<MedicoDTO>, string)> SearchMedico(string value, int page, int amount, string records, int idTipoMedico, List<int> idEspecialidades);
    Task<(ServiceStatus, DataCollection<MedicoDTO>, string)> SearchMedicodatosAsync(string ColegioCodigo, string NombreCompleto, string ApellidoPaterno, string ApellidoMaterno, string value, int page, int amount, string records);
    Task<(ServiceStatus, MedicoDTO, string)> UpdateMedico(UpdateMedicoPayload newEntity);
    Task<(ServiceStatus, MedicoDTO)> GetAllMedic(string numDoc);
    Task<(ServiceStatus, string, string)> UpdateImage(Attachment attachment);
    Task<(ServiceStatus, object, string)> GetMedicoTipo();
    Task<(ServiceStatus, object, string)> GetColegioTipo();
    Task<(ServiceStatus, object, string)> GetEspecialidad();

    Task<(ServiceStatus, object, string)> GetRoles();
}
