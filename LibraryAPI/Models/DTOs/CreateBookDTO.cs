using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models.DTOs
{
    public class CreateBookDTO
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateOnly DateOfPublication { get; set; }
        public string Genre { get; set; }
        public string ImageURL { get; set; }
    }
}
