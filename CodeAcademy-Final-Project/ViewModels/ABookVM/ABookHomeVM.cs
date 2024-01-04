using CodeAcademy_Final_Project.Models;

namespace CodeAcademy_Final_Project.ViewModels.ABookVM
{
    public class ABookHomeVM
    {
        public List<ABook> ABooks { get; set; }
        public List<Promotion> Promotions { get; set; }
        public List<Category> Categories { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
