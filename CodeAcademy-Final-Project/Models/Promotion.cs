namespace CodeAcademy_Final_Project.Models
{
    public class Promotion:BaseEntity
    {
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public List<Book> Books { get; set; }
    }
}
