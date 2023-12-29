namespace CodeAcademy_Final_Project.Models
{
    public class Genre:BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<BookBaseGenre> BookBaseGenre { get; set; }
    }
}
