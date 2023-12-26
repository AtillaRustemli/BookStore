namespace CodeAcademy_Final_Project.Models
{
    public class Book:BaseEntity
    {
        public Book()
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
        public List<BookCategory> BookCategory { get; set; }
        public List<AuthorBook> AuthorBook { get; set; }
        public List<BookGenre> BookGenre { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; }

    }
}
