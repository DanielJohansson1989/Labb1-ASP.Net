using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required, MaxLength(50)]
        public string Title { get; set; }
        [Required, MaxLength(50)]
        public string Author { get; set; }
        [Required, DisplayFormat]
        public DateOnly DateOfPublication { get; set; }
        [Required, MaxLength(30)]
        public string Genre { get; set; }
        public bool Available { get; set; } = true;
        public string? ImageURL { get; set; }
        public string? Description { get; set; }
    }
}
