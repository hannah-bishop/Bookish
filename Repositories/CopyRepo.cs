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

        // public List<Member> GetAllMembers()
        // {
        //     return _context
        //     .Members
        //     .ToList();
        // }
    }
}