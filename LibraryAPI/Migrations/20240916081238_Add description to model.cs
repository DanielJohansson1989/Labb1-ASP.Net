using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class Adddescriptiontomodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 1,
                column: "Description",
                value: "Efter ett flyghaveri kastas en grupp pojkar mellan sex och tolv år iland på en liten ö i Söderhavet. De stiftar lagar, fördelar sysslorna och väljer anförare. Deras tillvaro kan bli paradisisk med rik tillgång på god mat, sol och fullständig frihet från de vuxnas tvång. Men snart tar leken en annan vänding: skräcken kryper över pojkarna, rivaliteten växer mellan ledarna. Det som kunde varit ett spännande sommarlovsäventyr blir en furiös hetsjakt där fruktan och grymhet slår fram och vägen mot undergång ligger utstakad.");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 2,
                column: "Description",
                value: "Trilogin om Härskarringen - Sagan om ringen, Sagan om de två tornen och Sagan om konungens återkomst samlade i en upplaga.");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 3,
                column: "Description",
                value: "Millie har avtjänat ett tioårigt fängelsestraff och bor i sin bil när hon får jobb som hembiträde hos den förmögna familjen Winchester: mamma Nina, pappa Andrew och nioåriga dottern Cecelia. Bostad ingår - ett minimalt vindsrum i familjens jättevilla.\r\nMillie satsar allt på att sköta jobbet perfekt - hon städar, tvättar, tar hand om parets dotter, lagar fantastiska middagar till familjen och äter själv ensam i vindsrummet. Men snart börjar hon ana att familjen Winchester döljer betydligt mörkare hemligheter än hon själv. ");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 4,
                column: "Description",
                value: "Pappa läser tidningen och vill inte leka med Alfons. \"Akta sågen\" säger han när Alfons drar fram verktygslådan. Alfons hamrar och spikar.");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 5,
                column: "Description",
                value: "Den allra första boken om Pippi Långstrump, den starkaste och snällaste och roligaste och rikaste flickan i hela världen. Hon bor alldeles ensam i Villa Villekulla med sin häst och sin apa Herr Nilsson. En hel kappsäck full med gullpengar har hon också. I huset bredvid bor Tommy och Annika, och sedan Pippi flyttade in har allt blivit mycket roligare! För Pippi bakar pepparkakor direkt på golvet, hon kan lyfta sin häst på rak arm och hon leker kull med poliser när de kommer och vill hämta henne till ett barnhem.");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 6,
                column: "Description",
                value: "På delstatsfängelset i Cold Mountain, i det cellblock som kallas Den gröna milen, väntar samvetslösa mördare på att dö fastspända i Gamla Gnisten, den elektriska stolen. De bevakas av härdade fängelsevakter som har sett sin beskärda del av brutalitet och omänsklighet. Men när fången John Coffey, dömd att dö för våldtäkt och mord på två minderåriga flickor, anländer på Den gröna milen förändras allt.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Book");
        }
    }
}
