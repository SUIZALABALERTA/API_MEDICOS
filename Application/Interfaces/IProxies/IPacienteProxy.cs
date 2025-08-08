namespace Application.Interfaces.IProxies;

public interface IPacienteProxy
{
    Task<T> GetPaciente<T>(string numeroDocumento);
}