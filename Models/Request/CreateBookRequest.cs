namespace Bookish.Models.Request
{
    public class CreateBookRequest
    {
        public string Title { get; set ;}
        public int AuthorId {get; set;}

        public string CoverImageUrl {get; set;}
        public string Blurb{get; set;}
    }
}