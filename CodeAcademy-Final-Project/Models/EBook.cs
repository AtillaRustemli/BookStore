using CodeAcademy_Final_Project.Models.ReletionTables;

namespace CodeAcademy_Final_Project.Models
{
    public class EBook: BookBase
    {
        public string EBookUrl { get; set; }
        public Book Book { get; set; }
        public List<EBookAuthor> EBookAuthor { get; set; }
        public List<EBookGenre> EBookGenre { get; set; }
        public List<EBookCategory> EBookCategory { get; set; }
    }
}
