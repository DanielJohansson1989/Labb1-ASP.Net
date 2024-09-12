using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageURL",
                value: "\\images\\flugornas-herre.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 2,
                column: "ImageURL",
                value: "\\images\\harskarringen.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 3,
                column: "ImageURL",
                value: "\\images\\hembitradet.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 4,
                column: "ImageURL",
                value: "\\images\\aja-baja-alfons-aberg.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 5,
                column: "ImageURL",
                value: "\\images\\pippi-langstrump.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 6,
                column: "ImageURL",
                value: "\\images\\den-grona-milen.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageURL",
                value: "C:\\Users\\46703\\source\\repos\\Labb1-ASP.Net\\LibraryMVC\\wwwroot\\images\\flugornas-herre.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 2,
                column: "ImageURL",
                value: "C:\\Users\\46703\\source\\repos\\Labb1-ASP.Net\\LibraryMVC\\wwwroot\\images\\harskarringen.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 3,
                column: "ImageURL",
                value: "C:\\Users\\46703\\source\\repos\\Labb1-ASP.Net\\LibraryMVC\\wwwroot\\images\\hembitradet.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 4,
                column: "ImageURL",
                value: "C:\\Users\\46703\\source\\repos\\Labb1-ASP.Net\\LibraryMVC\\wwwroot\\images\\aja-baja-alfons-aberg.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 5,
                column: "ImageURL",
                value: "C:\\Users\\46703\\source\\repos\\Labb1-ASP.Net\\LibraryMVC\\wwwroot\\images\\pippi-langstrump.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "ID",
                keyValue: 6,
                column: "ImageURL",
                value: "C:\\Users\\46703\\source\\repos\\Labb1-ASP.Net\\LibraryMVC\\wwwroot\\images\\den-grona-milen.jpg");
        }
    }
}
