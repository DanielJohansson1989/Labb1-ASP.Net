using LibraryMVC.Models;

namespace LibraryMVC.Services
{
    public interface IAPIClientService : IDisposable
    {
        APIResponseDTO APIRespons { get; set; }
        Task<T> SendRequestAsync<T>(APIRequest request);
    }
}
