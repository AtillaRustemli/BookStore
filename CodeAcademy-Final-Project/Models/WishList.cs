namespace CodeAcademy_Final_Project.Models
{
    public class WishList:BaseEntity
    {
        public string Name { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsMain { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<Book> Books { get; set; }
        public List<ABook> ABooks { get; set; }
        public List<EBook> EBooks { get; set; }
    }
}
