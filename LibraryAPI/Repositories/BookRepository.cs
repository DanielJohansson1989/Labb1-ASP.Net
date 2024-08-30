using LibraryAPI.Data;
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateBookAsync(Book book)
        {
            _context.Books.Add(book);
        }

        public async Task DeleteBookAsync(Book book)
        {
            _context.Books.Remove(book);
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetSingleAsync(int id)
        {
            return await _context.Books.FirstOrDefaultAsync(b => b.ID == id);
        }

        public async Task<Book> GetSingleAsync(string title)
        {
            return await _context.Books.FirstOrDefaultAsync(b => b.Title.ToLower() == title.ToLower());
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBookAsync(Book book)
        {
            _context.Books.Update(book);
        }
    }
}
