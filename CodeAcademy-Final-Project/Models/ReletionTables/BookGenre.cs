namespace CodeAcademy_Final_Project.Models.ReletionTables
{
    public class BookGenre : BaseEntity
    {
        public int? BookId { get; set; }
        public Book Book { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
