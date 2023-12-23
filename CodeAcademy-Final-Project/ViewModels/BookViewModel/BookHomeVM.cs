using CodeAcademy_Final_Project.Models;

namespace CodeAcademy_Final_Project.ViewModels.BookViewModel
{
    public class BookHomeVM
    {
        public List<Book> Books { get; set; }
        public List<Promotion> Promotions { get; set; }
        public List<Category> Categories { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
