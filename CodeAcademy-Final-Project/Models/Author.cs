namespace CodeAcademy_Final_Project.Models
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public List<AuthorBook> AuthorBook { get; set; }
    }
}
