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
                new Book { ID = 1, Title = "Flugornas herre", Author = "William Golding", DateOfPublication = new DateOnly(2010, 08, 12), Genre = "Skönlitteratur", Available = true, ImageURL = "\\images\\flugornas-herre.jpg", Description = "Efter ett flyghaveri kastas en grupp pojkar mellan sex och tolv år iland på en liten ö i Söderhavet. De stiftar lagar, fördelar sysslorna och väljer anförare. Deras tillvaro kan bli paradisisk med rik tillgång på god mat, sol och fullständig frihet från de vuxnas tvång. Men snart tar leken en annan vänding: skräcken kryper över pojkarna, rivaliteten växer mellan ledarna. Det som kunde varit ett spännande sommarlovsäventyr blir en furiös hetsjakt där fruktan och grymhet slår fram och vägen mot undergång ligger utstakad." },
                new Book { ID = 2, Title = "Härskarringen", Author = "J R R Tolkien", DateOfPublication = new DateOnly(2002, 01, 01), Genre = "Fantasy", Available = true, ImageURL = "\\images\\harskarringen.jpg", Description = "Trilogin om Härskarringen - Sagan om ringen, Sagan om de två tornen och Sagan om konungens återkomst samlade i en upplaga." },
                new Book { ID = 3, Title = "Hembiträdet", Author = "Freida McFadden", DateOfPublication = new DateOnly(2024, 03, 08), Genre = "Deckare", Available = false, ImageURL = "\\images\\hembitradet.jpg", Description = "Millie har avtjänat ett tioårigt fängelsestraff och bor i sin bil när hon får jobb som hembiträde hos den förmögna familjen Winchester: mamma Nina, pappa Andrew och nioåriga dottern Cecelia. Bostad ingår - ett minimalt vindsrum i familjens jättevilla.\r\nMillie satsar allt på att sköta jobbet perfekt - hon städar, tvättar, tar hand om parets dotter, lagar fantastiska middagar till familjen och äter själv ensam i vindsrummet. Men snart börjar hon ana att familjen Winchester döljer betydligt mörkare hemligheter än hon själv. " },
                new Book { ID = 4, Title = "Aja baja, Alfons Åberg", Author = "Gunilla Bergström", DateOfPublication = new DateOnly(2006, 10, 30), Genre = "Barnbok", Available = true, ImageURL = "\\images\\aja-baja-alfons-aberg.jpg", Description = "Pappa läser tidningen och vill inte leka med Alfons. \"Akta sågen\" säger han när Alfons drar fram verktygslådan. Alfons hamrar och spikar." },
                new Book { ID = 5, Title = "Pippi Långstrump", Author = "Astrid Lindgren", DateOfPublication = new DateOnly(2015, 04, 20), Genre = "Barnbok", Available = false, ImageURL = "\\images\\pippi-langstrump.jpg", Description = "Den allra första boken om Pippi Långstrump, den starkaste och snällaste och roligaste och rikaste flickan i hela världen. Hon bor alldeles ensam i Villa Villekulla med sin häst och sin apa Herr Nilsson. En hel kappsäck full med gullpengar har hon också. I huset bredvid bor Tommy och Annika, och sedan Pippi flyttade in har allt blivit mycket roligare! För Pippi bakar pepparkakor direkt på golvet, hon kan lyfta sin häst på rak arm och hon leker kull med poliser när de kommer och vill hämta henne till ett barnhem." },
                new Book { ID = 6, Title = "Den gröna milen", Author = "Stephen King", DateOfPublication = new DateOnly(2019, 09, 25), Genre = "Skräck", Available = false, ImageURL = "\\images\\den-grona-milen.jpg", Description = "På delstatsfängelset i Cold Mountain, i det cellblock som kallas Den gröna milen, väntar samvetslösa mördare på att dö fastspända i Gamla Gnisten, den elektriska stolen. De bevakas av härdade fängelsevakter som har sett sin beskärda del av brutalitet och omänsklighet. Men när fången John Coffey, dömd att dö för våldtäkt och mord på två minderåriga flickor, anländer på Den gröna milen förändras allt." }
                );
        }
    }
}
