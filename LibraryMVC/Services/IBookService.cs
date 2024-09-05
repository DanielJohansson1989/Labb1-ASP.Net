using LibraryAPI.Models;
using LibraryAPI.Models.DTOs;

namespace LibraryMVC.Services
{
    public interface IBookService
    {
        Task<T> GetAllBooks<T>();
        Task<T> GetBookById<T>(int id);
        Task<T> GetBookBySearch<T>(string searchKeyword);
        Task<T> CreateBookAsync<T>(CreateBookDTO newBook);
        Task<T> UpdateBookAsync<T>(Book book);
        Task<T> DeleteBookAsync<T>(int id);
    }
}
