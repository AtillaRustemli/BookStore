namespace CodeAcademy_Final_Project.Models
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }
        public DateTime Released { get; set; }
        public double Price { get; set; }
        public List<AuthorBook> AuthorBook { get; set; }
    }
}
