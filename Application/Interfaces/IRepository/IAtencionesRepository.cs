using Domain.Enumerations;

namespace Application.Interfaces.IRepository;

public interface IAtencionesRepository
{
    Task<(ServiceStatus,string, object)> GetAtenciones(string value, string startDate, string endDate, int idMedico, int page, int amount);
}
