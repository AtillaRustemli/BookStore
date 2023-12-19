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
            builder.Property(c => c.LanguageId)
                .IsRequired();
            builder.Property(c=>c.ImgUrl) 
                .IsRequired();
        }
    }
}
