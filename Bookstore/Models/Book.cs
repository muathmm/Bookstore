using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Book
    {
        public  int BookId { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Title must be between 1 and 100 characters.")]
        public string Title { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Author name must be between 2 and 50 characters.")]
        public string Author { get; set; }

        [Required]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00.")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Genre must be between 3 and 30 characters.")]
        public string Genre { get; set; }
    }

}
