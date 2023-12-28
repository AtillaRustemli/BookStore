namespace CodeAcademy_Final_Project.Models
{
    public class BookBaseAuthor:BaseEntity
    {
        public int? BookId { get; set; }
        public Book Book { get; set; }
        public int? EBookId { get; set; }
        public EBook EBook { get; set; }
        public int? ABookId { get; set; }
        public ABook ABook { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
