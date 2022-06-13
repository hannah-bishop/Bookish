namespace Bookish.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }
        public List<CheckedOutBook> CheckedOutBooks { get; set; }

    }
}
