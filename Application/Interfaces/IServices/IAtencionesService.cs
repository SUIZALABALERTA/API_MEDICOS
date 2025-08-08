using Domain.Results;

namespace Application.Interfaces.IServices;

public interface IAtencionesService
{
    Task<MessageResult<object>> GetAtenciones(string value, string startDate, string endDate, int idMedico, int page, int amount);
}