using CodeAcademy_Final_Project.Models.ReletionTables;

namespace CodeAcademy_Final_Project.Models
{
    public class Genre:BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<BookGenre> BookBaseGenre { get; set; }
        public List<EBookGenre> EBookGenre { get; set; }
        public List<ABookAuthor> ABookAuthor { get; set; }
    }
}
