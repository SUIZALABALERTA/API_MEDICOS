using Domain.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;

namespace Infrastructure.ExternalServices.SaveFileAwsApi;
public class SaveFileClient : BaseHttpClient
{
    private readonly HttpClient _httpClient;

    public SaveFileClient(HttpClient httpClient, IConfiguration configuration) : base(httpClient)
    {
        _httpClient = httpClient;
        httpClient.DefaultRequestHeaders.Clear();
        httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " +
        Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", configuration["SISTEMA:Usuario"], configuration["SISTEMA:Password"]))));

    }

    public async Task<ConsultaResponse> SaveFileAws(MultipartFormDataContent request)
    {
        _httpClient.DefaultRequestHeaders.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));

        return await PostAwsS3(EndPoints.SaveFilesAws.SaveFiles, request);
    }
}

