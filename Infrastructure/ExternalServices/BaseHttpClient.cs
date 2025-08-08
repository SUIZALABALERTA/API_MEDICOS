using Domain.Enumerations;
using Domain.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Text;


namespace Infrastructure.ExternalServices
{
    public class BaseHttpClient
    {
        private readonly HttpClient _httpClient;

        protected BaseHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        protected async Task<(ServiceStatus, string, T)> ExecuteRequest<T>(HttpMethod httpMethod, string uri, object content = null, Token token = null)
        {
            try
            {

                var request = CreateRequest(httpMethod, uri, content, token);

                var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead)
                                                .ConfigureAwait(false);

                if (response.StatusCode != HttpStatusCode.Created && response.StatusCode != HttpStatusCode.OK && response.StatusCode != HttpStatusCode.InternalServerError &&
                    response.StatusCode != HttpStatusCode.BadRequest && response.StatusCode != HttpStatusCode.Unauthorized && response.StatusCode != HttpStatusCode.Forbidden &&
                    response.StatusCode != HttpStatusCode.UnprocessableEntity)
                {
                    return (ServiceStatus.InternalError, "Error no identificado", default);
                }

                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return (ServiceStatus.Unauthorized, "Antes debe loguearse", default);
                }

                if (response.StatusCode == HttpStatusCode.UnprocessableEntity)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    return (ServiceStatus.UnprocessableEntity, $"Formato incorrecto: {result}", default);
                }

                if (response.StatusCode == HttpStatusCode.BadRequest ||
                    response.StatusCode == HttpStatusCode.InternalServerError ||
                    response.StatusCode == HttpStatusCode.Forbidden)
                {
                    var cont = await response.Content.ReadAsStringAsync();
                    var message = await Task.Run(async () => JsonConvert.DeserializeObject<Status>(await response.Content.ReadAsStringAsync()));

                    message.Message = message.Message.Replace('/', ' ');
                    message.Message = message.Code != null ? $"{message.Message} / {message.Code}" : $"{message.Message} / no code";

                    return ((ServiceStatus)response.StatusCode, $"{message.Message} / {message.Reference}", default);
                }

                var var1 = await Task.Run(async () => (ServiceStatus.Ok, "Registro obtenido de Reniec", JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync())));

                return var1;

            }
            catch (Exception e)
            {
                return (ServiceStatus.InternalError, "Error no identificado" + e, default);
            }
        }

        private HttpRequestMessage CreateRequest(HttpMethod httpMethod, string uri, object content = null, Token token = null)
        {
            var request = new HttpRequestMessage(httpMethod, uri);

            if (token != null) request.Headers.Authorization = new AuthenticationHeaderValue(token.TokenType, token.AccessToken);

            if (content != null)
            {
                if (content is MultipartFormDataContent)
                    request.Content = content as MultipartFormDataContent;
                else
                    request.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            }

            return request;
        }

        protected async Task<ConsultaResponse> PostAwsS3(string uri, object content)
        {
            var request = CreateRequestAswS3(HttpMethod.Post, uri, content);

            return await ExecuteRequestS3(request);
        }

        private static HttpRequestMessage CreateRequestAswS3(HttpMethod httpMethod, string uri, object content = null)
        {
            var request = new HttpRequestMessage(httpMethod, uri);
            if (content == null) return request;

            request.Content = (MultipartFormDataContent)content;

            return request;
        }

        private async Task<ConsultaResponse> ExecuteRequestS3(HttpRequestMessage request)
        {
            try
            {
                var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ErrorHandler(response.StatusCode, "No existe data que mostrar");
                }

                var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                response.EnsureSuccessStatusCode();

                var result = string.IsNullOrEmpty(responseContent) ? default : System.Text.Json.JsonSerializer.Deserialize<List<string>>(responseContent);

                ConsultaResponse responseMessage = new ConsultaResponse();
                responseMessage.Result = 1;
                responseMessage.Message = result[0].ToString();

                return responseMessage;
            }
            catch (Exception ex) when (ex is ArgumentNullException ||
                                       ex is InvalidOperationException ||
                                       ex is HttpRequestException ||
                                       ex is System.Text.Json.JsonException)
            {
                throw new Exception("HttpClient exception", ex);
            }
        }
    }
}
