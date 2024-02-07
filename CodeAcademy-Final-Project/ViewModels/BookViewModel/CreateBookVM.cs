namespace CodeAcademy_Final_Project.ViewModels.BookViewModel
{
    public class CreateBookVM
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public int PageCount { get; set; }
        public int BookLanguage { get; set; }
        public string Description { get; set; }
        public IFormFile Photo { get; set; }
    }
}
