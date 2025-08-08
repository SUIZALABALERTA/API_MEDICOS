using Domain.Models;

namespace Application.Interfaces.IServices

{
    public interface ISaveFilesAwsService
    {
        Task<ConsultaResponse> SaveFileAws(byte[] pdf, string FileName, string formatExtension);
    }
}
