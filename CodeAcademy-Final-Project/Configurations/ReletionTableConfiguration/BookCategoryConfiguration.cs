using CodeAcademy_Final_Project.Models.ReletionTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.Property(bc => bc.BookId).IsRequired();
            builder.Property(bc => bc.CategoryId).IsRequired();
         


            builder.HasData(
                 new BookCategory
                 {
                     Id = 1,
                     BookId = 1,
                     CategoryId = 1


                 }
            );
        }
    }
}
