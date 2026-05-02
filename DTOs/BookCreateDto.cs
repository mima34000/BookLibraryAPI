using System.ComponentModel.DataAnnotations;

namespace BookLibraryAPI.DTOs
{
    // used when creating a new book - no id needed
    public class BookCreateDto
    {
        // title is required and cannot be empty
        [Required]
        [StringLength(200, MinimumLength = 1)]
        public string Title { get; set; } = string.Empty;

        // author is required and cannot be empty
        [Required]
        [StringLength(200, MinimumLength = 1)]
        public string Author { get; set; } = string.Empty;

        // year must be between 1000 and current year
        [Range(1000, 2100)]
        public int Year { get; set; }

        // true if already read, false if not
        public bool IsRead { get; set; }
    }
}