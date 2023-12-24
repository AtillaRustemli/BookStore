namespace CodeAcademy_Final_Project.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<BookCategory> BookCategory { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
