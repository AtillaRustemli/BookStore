namespace CodeAcademy_Final_Project.Models.ReletionTables
{
    public class ABookGenre:BaseEntity
    {
        public int ABookId { get; set; }
        public ABook ABook { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
