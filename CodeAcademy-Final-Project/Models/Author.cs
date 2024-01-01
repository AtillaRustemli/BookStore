using CodeAcademy_Final_Project.Models.ReletionTables;

namespace CodeAcademy_Final_Project.Models
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }

        public int SocialMediaId { get; set; }
        public SocialMedia SocialMedia { get; set; }
        public List<BookAuthor> BookBaseAuthor { get; set; }
        public List<EBookAuthor> EBookAuthor { get; set; }
        public List<ABookAuthor> ABookAuthor { get; set; }
    }
}
