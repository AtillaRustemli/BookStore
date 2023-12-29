using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations
{
    public class ABookConfiguration : IEntityTypeConfiguration<ABook>
    {
        public void Configure(EntityTypeBuilder<ABook> builder)
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
            builder.Property(c => c.Narrator)
                .IsRequired();
            builder.Property(c => c.SocialMediaId)
                .IsRequired();
            builder.HasData(
                new ABook
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
                    Narrator="Atilla",
                    SocialMediaId=1

                }
                );
        }
    }
}
