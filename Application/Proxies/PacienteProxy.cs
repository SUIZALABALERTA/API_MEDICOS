using Application.Interfaces.IProxies;
using Application.Services.BaseService;
using Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Application.Proxies;

public class PacienteProxy : BaseService, IPacienteProxy
{
    private readonly Apis _apiUrl;
    private readonly IHttpClientFactory _clientFactory;
    private readonly IConfiguration _configuration;
    private readonly string _apiKey;
    private readonly string _agente;

    public PacienteProxy(IOptions<Apis> apiurl, IHttpClientFactory httpClientFactory, IConfiguration configuration) : base(httpClientFactory)
    {
        _apiUrl = apiurl.Value;
        _clientFactory = httpClientFactory;
        _configuration = configuration;
        _apiKey = _configuration.GetSection("TokenManagement:ApiKey").Value;
        _agente = "MedicosApi";
    }

    public async Task<T> GetPaciente<T>(string numeroDocumento)
    {
        return await this.SendAsync<T>(new ApiRequest
        {
            apiType = SD.ApiType.GET,
            Url = $"{_apiUrl.SuizasoftEndpoint}/health/patient/{numeroDocumento}",
            ApiKey = _apiKey,
            Agente = _agente
        });
    }
}
