namespace CodeAcademy_Final_Project.Models
{
    public class Type:BaseEntity
    {
        public string Name { get; set; }
        public List<BookType> BookType { get; set; }
    }
}
