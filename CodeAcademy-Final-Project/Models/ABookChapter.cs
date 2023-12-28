namespace CodeAcademy_Final_Project.Models
{
    public class ABookChapter:BaseEntity
    {
        public string ABookUrl { get; set; }
        public int ABookId { get; set; }
        public ABook ABook { get; set; }

    }
}
