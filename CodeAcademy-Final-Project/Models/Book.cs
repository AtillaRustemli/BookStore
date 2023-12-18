namespace CodeAcademy_Final_Project.Models
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }
        public DateTime Released { get; set; }
        public double Price { get; set; }
        public string ImgUrl { get; set; }
        public List<AuthorBook> AuthorBook { get; set; }
        public List<BookGenre> BookGenre { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
