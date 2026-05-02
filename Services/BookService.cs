using BookLibraryAPI.Data;
using BookLibraryAPI.DTOs;
using BookLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryAPI.Services
{
    // handles all the logic for books
    public class BookService
    {
        private readonly BookDbContext _context;

        // get the database context via dependency injection
        public BookService(BookDbContext context)
        {
            _context = context;
        }

        // get all books from the database
        public async Task<List<Book>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }

        // get one book by id
        public async Task<Book?> GetByIdAsync(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        // create a new book and save it to the database
        public async Task<Book> CreateAsync(BookCreateDto dto)
        {
            var book = new Book
            {
                Title = dto.Title,
                Author = dto.Author,
                Year = dto.Year,
                IsRead = dto.IsRead
            };

            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        // update an existing book
        public async Task<Book?> UpdateAsync(int id, BookUpdateDto dto)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return null;

            book.Title = dto.Title;
            book.Author = dto.Author;
            book.Year = dto.Year;
            book.IsRead = dto.IsRead;

            await _context.SaveChangesAsync();
            return book;
        }

        // delete a book by id
        public async Task<bool> DeleteAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return false;

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}