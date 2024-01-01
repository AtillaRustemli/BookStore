namespace CodeAcademy_Final_Project.Models
{
    public class BookBase:BaseEntity
    {
        public BookBase()
        {
            SellCount = 0;
            PopularityCount = 0;

        }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Released { get; set; }
        public double Price { get; set; }
        public long? PopularityCount { get; set; }
        public long? SellCount { get; set; }
        public string ImgUrl { get; set; }
        public int BTypeId { get; set; }
        public BType BType { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; }
    }
}
