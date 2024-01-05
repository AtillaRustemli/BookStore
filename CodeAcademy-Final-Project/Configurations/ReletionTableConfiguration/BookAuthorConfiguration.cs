using CodeAcademy_Final_Project.Models.ReletionTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
           
            builder.Property(b => b.AuthorId).IsRequired();
            builder.HasData(
                 new BookAuthor
                 {
                     Id = 1,
                     AuthorId = 1,
                     BookId = 1,
                 }
                 );



        }
    }
}
