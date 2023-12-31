namespace CodeAcademy_Final_Project.Models.ReletionTables
{
    public class EBookCategory : BaseEntity
    {
        public int EBookId { get; set; }
        public EBook EBook { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
