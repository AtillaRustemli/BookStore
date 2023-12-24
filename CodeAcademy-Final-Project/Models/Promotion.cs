namespace CodeAcademy_Final_Project.Models
{
    public class Promotion:BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public string DetailImageUrl { get; set; }
        public DateTime EndTime { get; set; }
        public List<Book> Books { get; set; }
    }
}
