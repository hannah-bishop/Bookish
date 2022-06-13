using Bookish.Repositories;
using Bookish.Models;

namespace Bookish.Services
{
    public class CopyService
    {
        private CopyRepo _copyRepo = new CopyRepo();

        public Copy GetCopyById(int id)
        {
            return _copyRepo.GetCopyById(id);
        }

        // public List<Member> GetAllMembers()
        // {
        //     return _memberRepo.GetAllMembers();
        // }
    }
}