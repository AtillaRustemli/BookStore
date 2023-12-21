namespace CodeAcademy_Final_Project.Models
{
    public class BType:BaseEntity
    {
        public string Name { get; set; }
        public List<BookBType> BookType { get; set; }
    }
}
