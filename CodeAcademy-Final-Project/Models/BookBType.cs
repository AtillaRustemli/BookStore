namespace CodeAcademy_Final_Project.Models
{
    public class BookBType:BaseEntity
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int BTypeId { get; set; }
        public BType BType { get; set; }
    }
}
