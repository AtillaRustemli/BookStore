using CodeAcademy_Final_Project.Models;

namespace CodeAcademy_Final_Project.Models.ReletionTables
{
    public class EBookAuthor : BaseEntity
    {
        public int EBookId { get; set; }
        public EBook EBook { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
