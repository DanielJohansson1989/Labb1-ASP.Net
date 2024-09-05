using LibraryAPI.Models;
using LibraryAPI.Models.DTOs;
using LibraryMVC.Models;

namespace LibraryMVC.Services
{
    public class BookService : APIClientService, IBookService
    {
        public BookService(IHttpClientFactory httpClientFactroy) : base(httpClientFactroy)
        {
        }

        public async Task<T> CreateBookAsync<T>(CreateBookDTO newBook)
        {
            return await SendRequestAsync<T>( new APIRequest
            {
                RequestType = StaticDetails.RequestType.POST,
                URL = StaticDetails.LibraryAPIBaseURL + "/api/book",
                Data = newBook,
                AccessToken = ""
            });
        }

        public async Task<T> DeleteBookAsync<T>(int id)
        {
            return await SendRequestAsync<T>(new APIRequest 
            {
                RequestType = StaticDetails.RequestType.DELETE,
                URL = StaticDetails.LibraryAPIBaseURL + "/api/book/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> GetAllBooks<T>()
        {
            return await SendRequestAsync<T>(new APIRequest
            {
                RequestType = StaticDetails.RequestType.GET,
                URL = StaticDetails.LibraryAPIBaseURL + "/api/books",
                AccessToken = ""
            });
        }

        public async Task<T> GetBookById<T>(int id)
        {
            return await SendRequestAsync<T>( new APIRequest
            {
                RequestType = StaticDetails.RequestType.GET,
                URL = StaticDetails.LibraryAPIBaseURL + "/api/book/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> GetBookBySearch<T>(string searchKeyword)
        {
            return await SendRequestAsync<T>( new APIRequest
            {
                RequestType = StaticDetails.RequestType.GET,
                URL = StaticDetails.LibraryAPIBaseURL + "/api/book/result?searchKeyword=" + searchKeyword,
                AccessToken = ""
            });
        }

        public async Task<T> UpdateBookAsync<T>(Book book)
        {
            return await SendRequestAsync<T>(new APIRequest
            {
                RequestType = StaticDetails.RequestType.PUT,
                URL = StaticDetails.LibraryAPIBaseURL + "/api/book",
                Data = book,
                AccessToken = ""
            });
        }
    }
}
