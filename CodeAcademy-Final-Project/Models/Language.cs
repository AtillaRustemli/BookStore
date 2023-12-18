namespace CodeAcademy_Final_Project.Models
{
    public class Language:BaseEntity
    {
        public string Name { get; set; }
        public List<Book> Book { get; set; }
    }
}
