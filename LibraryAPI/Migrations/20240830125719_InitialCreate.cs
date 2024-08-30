using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfPublication = table.Column<DateOnly>(type: "date", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "ID", "Author", "Available", "DateOfPublication", "Genre", "Title" },
                values: new object[,]
                {
                    { 1, "William Golding", true, new DateOnly(2010, 8, 12), "Skönlitteratur", "Flugornas herre" },
                    { 2, "J R R Tolkien", true, new DateOnly(2002, 1, 1), "Fantasy", "Härskarringen" },
                    { 3, "Freida McFadden", false, new DateOnly(2024, 3, 8), "Deckare", "Hembiträdet" },
                    { 4, "Gunilla Bergström", true, new DateOnly(2006, 10, 30), "Barnbok", "Aja baja, Alfons Åberg" },
                    { 5, "Astrid Lindgren", false, new DateOnly(2015, 4, 20), "Barnbok", "Pippi Långstrump" },
                    { 6, "Stephen King", false, new DateOnly(2019, 9, 25), "Skräck", "Den gröna milen" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
