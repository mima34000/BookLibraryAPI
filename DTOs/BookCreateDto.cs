namespace BookLibraryAPI.DTOs
{
    // used when creating a new book - no id needed
    public class BookCreateDto
    {
        // title of the new book
        public string Title { get; set; } = string.Empty;

        // author of the new book
        public string Author { get; set; } = string.Empty;

        // year it was published
        public int Year { get; set; }

        // true if already read, false if not
        public bool IsRead { get; set; }
    }
}
