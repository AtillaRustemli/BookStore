using CodeAcademy_Final_Project.Models;

namespace CodeAcademy_Final_Project.ViewModels.EBookVM
{
    public class EBookHomeVM
    {
        public List<EBook> EBooks { get; set; }
        public List<Promotion> Promotions { get; set; }
        public List<Category> Categories { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
