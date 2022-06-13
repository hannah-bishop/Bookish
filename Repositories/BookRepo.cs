using System.Linq;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;

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
            .Include( b => b.Author)
            .Single();
        }

        public List<Book> GetAllBooks()
        {
            return _context
            .Books
            .Include(b => b.Author)
            .ToList();
        }
    }
}