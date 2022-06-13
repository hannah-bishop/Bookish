namespace Bookish.Models
{
    public class CheckedOutBook
    {
        public int Id { get; set; }
        public Copy Copy { get; set; }
        public Member Member { get; set; }
        public DateTime DueDate { get; set; }
        public Boolean Returned { get; set; }
    }
}