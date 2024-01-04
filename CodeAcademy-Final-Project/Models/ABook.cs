using CodeAcademy_Final_Project.Models.ReletionTables;

namespace CodeAcademy_Final_Project.Models
{
    public class ABook:BookBase
    {
        public List<ABookChapter> ABookChapters { get; set; }
        public string Narrator { get; set; }
        public Book Book { get; set; }
        public EBook EBook { get; set; }
        public List<ABookAuthor> ABookAuthor { get; set; }
        public List<ABookGenre> ABookGenre { get; set; }
        public List<ABookCategory> ABookCategory { get; set; }

    }
}
