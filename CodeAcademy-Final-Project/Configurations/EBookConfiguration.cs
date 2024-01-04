using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations
{
    public class EBookConfiguration:IEntityTypeConfiguration<EBook>
    {
        public void Configure(EntityTypeBuilder<EBook> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(c => c.Price)
                .IsRequired();
            builder.Property(c => c.Released)
                .IsRequired();
            builder.Property(c => c.LanguageId)
                .IsRequired();
            builder.Property(c => c.PromotionId)
                .IsRequired();
            builder.Property(c => c.ImgUrl)
                .IsRequired();
            builder.Property(c => c.BTypeId)
                .IsRequired();
            builder.Property(c => c.EBookUrl)
                .IsRequired();
            builder.HasData(
                new EBook
                {
                    Id = 1,
                    Name = "Talk to the Heart",
                    Description = "This is book's description and there is nothing but description so good luck)",
                    Price = 11,
                    Released = DateTime.Now,
                    LanguageId = 1,
                    PromotionId = 1,
                    ImgUrl = "book-example4.jpg",
                    SellCount = 0,
                    PopularityCount = 0,
                    BTypeId = 2,
                    EBookUrl="ardino.pdf",
                    ABookId= 1,

                }
                );
        }
    }
}
