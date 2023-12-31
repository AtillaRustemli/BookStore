namespace CodeAcademy_Final_Project.Models.ReletionTables
{
    public class ABookCategory:BaseEntity
    {

        public int ABookId { get; set; }
        public ABook ABook { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
