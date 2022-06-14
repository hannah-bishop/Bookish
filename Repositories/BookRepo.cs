using Bookish.Models;
using Microsoft.EntityFrameworkCore;
using Bookish.Models.Request;

namespace Bookish.Repositories
{
    public class BookRepo
    {
        private BookishContext _context = new BookishContext();

        public Book GetBookById(int id)
        {
            return _context
            .Books
            .Where(b => b.Id == id)
            .Include(b => b.Author)
            .Single();
        }

        public List<Book> GetAllBooks()
        {
            return _context
            .Books
            .Include(b => b.Author)
            .ToList();
        }
        public Book CreateBook(CreateBookRequest request)
        {
            Book newBook = new Book
            {
                Title = request.Title,
                CoverImageUrl = request.CoverImageUrl,
                Blurb = request.Blurb
            };
            Author author = _context
            .Authors
            .Where(a => a.Id == request.AuthorId)
            .Single();
            newBook.Author = author;
            var insertedBook = _context.Books.Add(newBook);
            _context.SaveChanges();
            return insertedBook.Entity;
        }
    }
}