namespace BookLibraryAPI.Models
{
    public class Book
    {
        // unique id for each book
        public int Id { get; set; }

        // book title
        public string Title { get; set; } = string.Empty;

        // who wrote it
        public string Author { get; set; } = string.Empty;

        // year it was published
        public int Year { get; set; }

        // true if i have read it, false if not
        public bool IsRead { get; set; }
    }
}