namespace CodeAcademy_Final_Project.Models
{
    public class BookBaseCategory:BaseEntity
    {
        public int? BookBaseId { get; set; }
        public Book Book { get; set; }
        public EBook EBook { get; set; }
        public ABook ABook { get; set; }
        public int CategoryId{ get; set; }
        public Category Category { get; set; }
        public int TypeId { get; set; }
    }
}
