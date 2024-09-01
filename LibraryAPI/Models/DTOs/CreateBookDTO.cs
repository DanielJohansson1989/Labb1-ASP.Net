using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models.DTOs
{
    public class CreateBookDTO
    {
        [Required, MaxLength(50)]
        public string Title { get; set; }
        [Required, MaxLength(50)]
        public string Author { get; set; }
        public DateOnly DateOfPublication { get; set; }
        public string Genre { get; set; }
    }
}
