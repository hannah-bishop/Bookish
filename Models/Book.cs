namespace Bookish.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Author Author { get; set; }

        public string CoverImageUrl { get; set; }

        public string Blurb { get; set; }
        public List<Copy> Copies { get; set; }
    }
}
