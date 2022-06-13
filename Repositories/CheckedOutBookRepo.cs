using Bookish.Models;
using Microsoft.EntityFrameworkCore;
using System;

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
                .ThenInclude(a => a.Book)
                    .ThenInclude(c => c.Author)
            .Single();
        }
        public List<CheckedOutBook> GetAllCheckedOutBooks()
        {
            return _context
            .CheckedOutBooks
            .Include(b => b.Member)
            .Include(b => b.Copy)
                .ThenInclude(a => a.Book)
                    .ThenInclude(c => c.Author)
            .ToList();
        }
    }
}