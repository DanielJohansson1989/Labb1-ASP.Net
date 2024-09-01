using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Book
    {
        [Required]
        public int ID { get; set; }
        [Required, MaxLength(50)]
        public string Title { get; set; }
        [Required, MaxLength(50)]
        public string Author { get; set; }
        public DateOnly DateOfPublication { get; set; }
        public string Genre { get; set; }
        public bool Available { get; set; } = true;
    }
}
