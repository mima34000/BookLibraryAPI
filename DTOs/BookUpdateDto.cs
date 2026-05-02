namespace BookLibraryAPI.DTOs
{
    // used when updating an existing book
    public class BookUpdateDto
    {
        // updated title
        public string Title { get; set; } = string.Empty;

        // updated author
        public string Author { get; set; } = string.Empty;

        // updated year
        public int Year { get; set; }

        // updated read status
        public bool IsRead { get; set; }
    }
}