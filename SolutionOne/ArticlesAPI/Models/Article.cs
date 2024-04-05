namespace ArticlesAPI.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime RealeasDate { get; set; }   
        public int WriterId { get; set; }
    }
}
