namespace CodeAcademy_Final_Project.Models.ReletionTables
{
    public class BookAuthor : BaseEntity
    {
        public int? BookId { get; set; }
        public Book Book { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
