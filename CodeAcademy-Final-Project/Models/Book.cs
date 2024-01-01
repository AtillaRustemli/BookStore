using CodeAcademy_Final_Project.Models.ReletionTables;

namespace CodeAcademy_Final_Project.Models
{
    public class Book:BookBase
    {
        public Book() : base() { }
        public double  Height { get; set; }
        public double  Length { get; set; }
        public double  Width { get; set; }
        public int PageCount { get; set; }
        public List<BookAuthor> BookAuthor { get; set; }
        public List<BookGenre> BookGenre { get; set; }
        public List<BookCategory> BookCategory { get; set; }

    }
}
