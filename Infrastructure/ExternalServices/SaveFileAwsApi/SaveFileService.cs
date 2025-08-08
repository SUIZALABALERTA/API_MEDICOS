using Application.Interfaces.IServices;
using Domain.Models;
using System.Net.Http.Headers;

namespace Infrastructure.ExternalServices.SaveFileAwsApi;

public class SaveFileService : ISaveFilesAwsService
{

    private readonly SaveFileClient _client;
    public SaveFileService(SaveFileClient client)
    {
        _client = client;
    }

    public async Task<ConsultaResponse> SaveFileAws(byte[] pdf, string FileName, string formatExtension)
    {
        using (var ms = new MemoryStream(pdf))
        {
            var files = new StreamContent(ms);
            var name = FileName;

            var imageContent = new ByteArrayContent(files.ReadAsByteArrayAsync().Result);

            var multipart = CreateMultipartWithName(imageContent, FileName + formatExtension, "files[]");

            multipart.Add(new StringContent("SuizaMedicosProfile"), "path");
            multipart.Add(new StringContent("true"), "is_replace");


            try
            {
                var result = await _client.SaveFileAws(multipart);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

    public static MultipartFormDataContent CreateMultipartWithName(ByteArrayContent file, string name, string property)
    {
        try
        {
            var multiForm = new MultipartFormDataContent();

            file.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");

            multiForm.Add(file, property, name);

            return multiForm;

        }
        catch (Exception)
        {
            return null;
        }

    }
}

