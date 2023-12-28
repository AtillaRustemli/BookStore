namespace CodeAcademy_Final_Project.Models
{
    public class ABook:BookBase
    {
        public List<ABookChapter> ABookChapters { get; set; }
        public string Narrator { get; set; }
    }
}
