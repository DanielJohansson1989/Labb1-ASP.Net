using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .ToTable("Book")
                .HasData(
                new Book { ID = 1, Title = "Flugornas herre", Author = "William Golding", DateOfPublication = new DateOnly(2010, 08, 12), Genre = "Skönlitteratur", Available = true, ImageURL = "\\images\\flugornas-herre.jpg" },
                new Book { ID = 2, Title = "Härskarringen", Author = "J R R Tolkien", DateOfPublication = new DateOnly(2002, 01, 01), Genre = "Fantasy", Available = true, ImageURL = "\\images\\harskarringen.jpg" },
                new Book { ID = 3, Title = "Hembiträdet", Author = "Freida McFadden", DateOfPublication = new DateOnly(2024, 03, 08), Genre = "Deckare", Available = false, ImageURL = "\\images\\hembitradet.jpg" },
                new Book { ID = 4, Title = "Aja baja, Alfons Åberg", Author = "Gunilla Bergström", DateOfPublication = new DateOnly(2006, 10, 30), Genre = "Barnbok", Available = true, ImageURL = "\\images\\aja-baja-alfons-aberg.jpg" },
                new Book { ID = 5, Title = "Pippi Långstrump", Author = "Astrid Lindgren", DateOfPublication = new DateOnly(2015, 04, 20), Genre = "Barnbok", Available = false, ImageURL = "\\images\\pippi-langstrump.jpg" },
                new Book { ID = 6, Title = "Den gröna milen", Author = "Stephen King", DateOfPublication = new DateOnly(2019, 09, 25), Genre = "Skräck", Available = false, ImageURL = "\\images\\den-grona-milen.jpg" }
                );
        }
    }
}
