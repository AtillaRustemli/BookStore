namespace CodeAcademy_Final_Project.Models
{
    public class BookBaseGenre:BaseEntity
    {
        public int? BookBaseId { get; set; }
        public Book Book { get; set; }
        public EBook EBook { get; set; }
        public ABook ABook { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int TypeId { get; set; }
    }
}
