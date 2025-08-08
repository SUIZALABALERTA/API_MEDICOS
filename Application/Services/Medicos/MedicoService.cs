using Application.Common;
using Application.Interfaces.IProxies;
using Application.Interfaces.IRepository;
using Application.Interfaces.IServices;
using AutoMapper;
using Domain.DTO;
using Domain.Enumerations;
using Domain.Models;
using Domain.Payloads;
using Domain.Results;
using System.Net;

namespace Application.Services.Medicos;

public class MedicoService : IMedicoService
{
    private readonly IMedicoRepository _medicoRepository;
    private readonly IMapper _mapper;
    private readonly IPacienteProxy _pacienteProxy;


    public MedicoService(IMedicoRepository MedicoRepository, IMapper map, IPacienteProxy pacienteProxy)
    {
        _medicoRepository = MedicoRepository;
        _mapper = map;
        _pacienteProxy = pacienteProxy;
    }

    public async Task<MessageResult<DataCollection<MedicoDTO>>> SearchMedico(string value, int page, int amount, string records, int idTipoMedico, List<int> idEspecialidades)
    {
        var (status, result, message) = await _medicoRepository.SearchMedico(value, page, amount, records, idTipoMedico, idEspecialidades);

        if (status != ServiceStatus.Ok)
            throw new ErrorHandler(
                    status == ServiceStatus.NotFound
                    ? HttpStatusCode.BadRequest
                    : HttpStatusCode.InternalServerError
                , message
                );

        return MessageResult<DataCollection<MedicoDTO>>.Of(message, result);
    }

    public async Task<MessageResult<DataCollection<MedicoDTO>>> SearchMedicodatosAsync(string ColegioCodigo, string NombreCompleto, string ApellidoPaterno, string ApellidoMaterno, string value, int page, int amount, string records)
    {
        var (status, result, message) = await _medicoRepository.SearchMedicodatosAsync(ColegioCodigo, NombreCompleto, ApellidoPaterno, ApellidoMaterno, value, page, amount, records);

        if (status != ServiceStatus.Ok)
            throw new ErrorHandler(
                    status == ServiceStatus.NotFound
                    ? HttpStatusCode.BadRequest
                    : HttpStatusCode.InternalServerError
                , message
                );

        return MessageResult<DataCollection<MedicoDTO>>.Of(message, result);
    }

    public async Task<MessageResult<MedicoDTO>> GetMedico(string numDoc)
    {

        var (status, medico) = await _medicoRepository.GetAllMedic(numDoc);


        if (status is ServiceStatus.NotFound && numDoc.Length is 8)
        {

            var pacienteproxy = await _pacienteProxy.GetPaciente<MessageResult<PatientResultDTO>>(numDoc);

            if (pacienteproxy.Data is null)
                throw new ErrorHandler(HttpStatusCode.NotFound, "Medico no encontrado");

            return MessageResult<MedicoDTO>.Of("Succeeded", _mapper.Map<MedicoDTO>(pacienteproxy.Data));
        }


        return MessageResult<MedicoDTO>.Of("Succeeded", medico);
    }

    public async Task<MessageResult<MedicoDTO>> CreateMedico(CreateMedicoPayload request)
    {
        ServiceStatus estado = ServiceStatus.NotFound;
        MedicoDTO medico = null;
        string mensajeResponse = string.Empty;

        if (request.IdTipoDocumento != (int)TypeDocument.SinEspecificar)
        {
            (estado, medico, mensajeResponse) = await _medicoRepository.CheckMedico(request.NumeroDocumento);

            if (estado == ServiceStatus.Ok)
                return MessageResult<MedicoDTO>.Of(mensajeResponse, medico, code: 2);

            if (estado == ServiceStatus.InternalError)
                throw new ErrorHandler(HttpStatusCode.InternalServerError, mensajeResponse);
        }

        if (estado == ServiceStatus.NotFound)
        {
            if (request.IdUbigeo == null) request.IdUbigeo = 0;

            (estado, medico, mensajeResponse) = await _medicoRepository.CreateMedico(request);
        }


        if (estado != ServiceStatus.Ok)
            throw new ErrorHandler(
                    estado == ServiceStatus.FailedValidation
                    ? HttpStatusCode.BadRequest
                    : HttpStatusCode.InternalServerError
                , mensajeResponse);

        return MessageResult<MedicoDTO>.Of(mensajeResponse, medico);
    }

    public async Task<MessageResult<MedicoDTO>> UpdateMedico(UpdateMedicoPayload medico)
    {

        var (status, message) = await _medicoRepository.FastCheckMedico(medico.NumeroDocumento);

        if (status != ServiceStatus.Ok)
            throw new ErrorHandler(
                    status == ServiceStatus.NotFound
                    ? HttpStatusCode.BadRequest
                    : HttpStatusCode.InternalServerError
                , message);


        if (!string.IsNullOrEmpty(medico.Rna))
        {
            if (medico.Rna.Length < 4) throw new ErrorHandler(HttpStatusCode.BadRequest, "RNA debe ser mayor a 4 digitos");
        }

        if (!string.IsNullOrEmpty(medico.Rne))
        {
            if (medico.Rne.Length < 4) throw new ErrorHandler(HttpStatusCode.BadRequest, "RNE debe ser mayor a 4 digitos");
        }

        var (estado, updatedMedico, messageResponse) = await _medicoRepository.UpdateMedico(medico);


        if (estado != ServiceStatus.Ok)
            throw new ErrorHandler(
                    estado == ServiceStatus.FailedValidation
                    ? HttpStatusCode.BadRequest
                    : HttpStatusCode.InternalServerError
                , messageResponse);

        return MessageResult<MedicoDTO>.Of(messageResponse, updatedMedico);

    }

    public async Task<MessageResult<string>> UpdateImage(Attachment attachment)
    {
        var (status, pathImage, message) = await _medicoRepository.UpdateImage(attachment);

        if (status != ServiceStatus.Ok)
            throw new ErrorHandler(
                    status == ServiceStatus.FailedValidation
                    ? HttpStatusCode.BadRequest
                    : HttpStatusCode.InternalServerError
                , message
                );

        return MessageResult<string>.Of(message, pathImage);
    }
    public async Task<MessageResult<object>> GetMedicoTipo()
    {
        var (status, result, message) = await _medicoRepository.GetMedicoTipo();

        if (status != ServiceStatus.Ok)
            throw new ErrorHandler(
                    status == ServiceStatus.FailedValidation
                    ? HttpStatusCode.BadRequest
                    : HttpStatusCode.InternalServerError
                , message
                );

        return MessageResult<object>.Of(message, result);
    }

    public async Task<MessageResult<object>> GetColegioTipo()
    {
        var (status, result, message) = await _medicoRepository.GetColegioTipo();

        if (status != ServiceStatus.Ok)
            throw new ErrorHandler(
                    status == ServiceStatus.FailedValidation
                    ? HttpStatusCode.BadRequest
                    : HttpStatusCode.InternalServerError
                , message
                );

        return MessageResult<object>.Of(message, result);
    }

    public async Task<MessageResult<object>> GetEspecialidad()
    {
        var (status, result, message) = await _medicoRepository.GetEspecialidad();

        if (status != ServiceStatus.Ok)
            throw new ErrorHandler(
                    status == ServiceStatus.FailedValidation
                    ? HttpStatusCode.BadRequest
                    : HttpStatusCode.InternalServerError
                , message
                );

        return MessageResult<object>.Of(message, result);
    }
    public async Task<MessageResult<object>> GetRoles()
    {
        var (status, result, message) = await _medicoRepository.GetRoles();

        if (status != ServiceStatus.Ok)
            throw new ErrorHandler(
                    status == ServiceStatus.FailedValidation
                    ? HttpStatusCode.BadRequest
                    : HttpStatusCode.InternalServerError
                , message
                );

        return MessageResult<object>.Of(message, result);
    }
}
