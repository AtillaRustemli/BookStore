namespace CodeAcademy_Final_Project.Models
{
    public class SocialMedia:BaseEntity
    {
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? Pinterest { get; set; }
        public Author Author { get; set; }
    }
}
