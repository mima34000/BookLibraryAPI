using System.Collections.Generic;
using BookLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryAPI.Data
{
    // connects the Book Library app to the database
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
        }

        // represents the Books table in the database
        public DbSet<Book> Books { get; set; }
    }
}
