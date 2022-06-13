using Bookish.Repositories;
using Bookish.Models;

namespace Bookish.Services
{
    public class CheckedOutBookService
    {
        private CheckedOutBookRepo _checkedOutBookRepo = new CheckedOutBookRepo();

        public CheckedOutBook GetCheckedOutBookById(int id)
        {
            return _checkedOutBookRepo.GetCheckedOutBookById(id);
        }
        public List<CheckedOutBook> GetAllCheckedOutBooks()
        {
            return _checkedOutBookRepo.GetAllCheckedOutBooks();
        }
    }
}