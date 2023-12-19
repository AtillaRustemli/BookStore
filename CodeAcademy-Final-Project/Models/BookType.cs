namespace CodeAcademy_Final_Project.Models
{
    public class BookType:BaseEntity
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
    }
}
