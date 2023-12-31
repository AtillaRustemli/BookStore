namespace CodeAcademy_Final_Project.Models.ReletionTables
{
    public class ABookAuthor:BaseEntity
    {
        public int ABookId { get; set; }
        public ABook ABook { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
