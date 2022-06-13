using Bookish.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Repositories
{
    public class CheckedOutBookRepo
    {
        private BookishContext _context = new BookishContext();

        public CheckedOutBook GetCheckedOutBookById(int id)
        {
            return _context
            .CheckedOutBooks
            .Where(b => b.Id == id)
            .Include(b => b.Member)
            .Include(b => b.Copy)
            .Single();
        }
    }
}