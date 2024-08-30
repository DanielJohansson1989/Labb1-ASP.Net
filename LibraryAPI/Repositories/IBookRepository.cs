using LibraryAPI.Models;

namespace LibraryAPI.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book> GetSingleAsync(int id);
        Task<Book> GetSingleAsync(string title);
        Task CreateBookAsync(Book book);
        Task DeleteBookAsync(Book book);
        Task UpdateBookAsync(Book book);
        Task SaveAsync();
    }
}
