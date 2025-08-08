using Application.Common;
using Domain.DTO;
using Domain.Models;
using Domain.Payloads;
using Domain.Results;

namespace Application.Interfaces.IServices

{
    public interface IMedicoService
    {
        Task<MessageResult<MedicoDTO>> CreateMedico(CreateMedicoPayload request);

        Task<MessageResult<MedicoDTO>> GetMedico(string numDoc);

        Task<MessageResult<DataCollection<MedicoDTO>>> SearchMedico(string value, int page, int amount, string records, int idTipoMedico, List<int> idEspecialidades);

        Task<MessageResult<DataCollection<MedicoDTO>>> SearchMedicodatosAsync(string ColegioCodigo, string NombreCompleto, string ApellidoPaterno, string ApellidoMaterno, string value, int page, int amount, string records);

        Task<MessageResult<MedicoDTO>> UpdateMedico(UpdateMedicoPayload patient);

        Task<MessageResult<string>> UpdateImage(Attachment attachment);

        Task<MessageResult<object>> GetMedicoTipo();

        Task<MessageResult<object>> GetColegioTipo();

        Task<MessageResult<object>> GetEspecialidad();

        Task<MessageResult<object>> GetRoles();
    }
}