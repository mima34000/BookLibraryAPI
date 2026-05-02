using System.ComponentModel.DataAnnotations;

namespace BookLibraryAPI.DTOs
{
    // used when updating an existing book
    public class BookUpdateDto
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

        // updated read status
        public bool IsRead { get; set; }
    }
}