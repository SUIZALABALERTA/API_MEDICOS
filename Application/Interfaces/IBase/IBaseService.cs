using Domain.Models;

namespace Application.Interfaces.IBase
{
    public interface IBaseService : IDisposable
    {
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
