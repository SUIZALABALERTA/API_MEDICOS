using Application.Interfaces.IRepository;
using Application.Interfaces.IServices;
using AutoMapper;
using Domain.Enumerations;
using Domain.Models;
using Domain.Results;
using System.Net;

namespace Application.Services.Atenciones;

public class AtencionesService : IAtencionesService
{
    private readonly IAtencionesRepository _atencionesRepository;
    private readonly IMapper _mapper;


    public AtencionesService(IAtencionesRepository atencionesRepository)
    {
        _atencionesRepository = atencionesRepository;
    }

    public async Task<MessageResult<object>> GetAtenciones(string value, string startDate, string endDate, int idMedico, int page, int amount)
    {
        var (status, message, result) = await _atencionesRepository.GetAtenciones(value, startDate, endDate, idMedico, page, amount);

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
