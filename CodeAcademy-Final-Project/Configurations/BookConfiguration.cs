using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(c=>c.Price)
                .IsRequired();
            builder.Property(c => c.Released)
                .IsRequired();
            builder.Property(c => c.LanguageId)
                .IsRequired();
            builder.Property(c => c.CategoryId)
                .IsRequired();
            builder.Property(c => c.PromotionId)
                .IsRequired();
            builder.Property(c=>c.ImgUrl) 
                .IsRequired();
            builder.HasData(
                new Book
                {
                    Id=1,
                    Name="Talk to the Heart",
                    Description="This is book's description and there is nothing but description so good luck)",
                    Price =1,
                    Released=DateTime.Now,
                    LanguageId=1,
                    CategoryId=1,
                    PromotionId=1,
                    ImgUrl="book-example4.jpg"
                }
                );
        }
    }
}
