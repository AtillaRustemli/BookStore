using CodeAcademy_Final_Project.Models.ReletionTables;

namespace CodeAcademy_Final_Project.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Genre> Genres { get; set; }
        public List<BookCategory> BookBaseCategory { get; set; }
        public List<EBookCategory> EBookCategory { get; set; }
        public List<ABookCategory> ABookCategory { get; set; }
    }
}
