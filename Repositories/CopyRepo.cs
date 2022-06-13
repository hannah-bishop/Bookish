using Bookish.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Repositories
{
    public class CopyRepo
    {
        private BookishContext _context = new BookishContext();

        public Copy GetCopyById(int id)
        {
            return _context
            .Copies
            .Where(b => b.Id == id)
            .Include(b => b.Book)
            .Single();
        }

        public List<Copy> GetAllCopies()
        {
            return _context
            .Copies
            .Include(b => b.Book)
            .Include(b => b.Book.Author)
            .ToList();
        }
    }
}