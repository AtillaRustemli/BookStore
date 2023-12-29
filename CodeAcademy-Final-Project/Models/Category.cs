namespace CodeAcademy_Final_Project.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<BookBaseCategory> BookBaseCategory { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
