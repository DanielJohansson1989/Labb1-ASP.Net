using LibraryMVC.Models;
using Newtonsoft.Json;
using System.Text;

namespace LibraryMVC.Services
{
    public class APIClientService : IAPIClientService
    {
        public APIResponseDTO APIRespons { get; set; }

        private IHttpClientFactory _httpClientFactory;
        public APIClientService(IHttpClientFactory httpClientFactroy) 
        {
            _httpClientFactory = httpClientFactroy;
            APIRespons = new APIResponseDTO();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public async Task<T> SendRequestAsync<T>(APIRequest request)
        {
            try
            {
                var client = _httpClientFactory.CreateClient("LibraryAPI");

                HttpRequestMessage requestMessage = new HttpRequestMessage();
                requestMessage.Headers.Add("Accept", "application/json");
                requestMessage.RequestUri = new Uri(request.URL);
                client.DefaultRequestHeaders.Clear();

                if (request.Data != null)
                {
                    requestMessage.Content = new StringContent(JsonConvert.SerializeObject(request.Data), Encoding.UTF8, "application/json");
                }

                switch (request.RequestType)
                {
                    case StaticDetails.RequestType.GET:
                        break;
                    case StaticDetails.RequestType.POST:
                        break;
                    case StaticDetails.RequestType.PUT:
                        break;
                    case StaticDetails.RequestType.DELETE:
                        break;
                    default:
                        break;
                }

                HttpResponseMessage apiResponse = await client.SendAsync(requestMessage);
                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var apiResponsDTO = JsonConvert.DeserializeObject<T>(apiContent);
                return apiResponsDTO;
            }
            catch (Exception ex)
            {

                var responsDTO = new APIResponseDTO()
                {
                    IsSuccess = false,
                    ErrorList = new List<string>() { Convert.ToString(ex.Message) }
                };

                var result = JsonConvert.SerializeObject(responsDTO);
                var apiResponseDTO = JsonConvert.DeserializeObject<T>(result);
                return apiResponseDTO;
            }   
        }
    }
}
