namespace CodeAcademy_Final_Project.Models.ReletionTables
{
    public class EBookGenre : BaseEntity
    {
        public int EBookId { get; set; }
        public EBook EBook { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
