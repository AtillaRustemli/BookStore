using CodeAcademy_Final_Project.Models.ReletionTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class BookGenreConfiguration : IEntityTypeConfiguration<BookGenre>
    {
        public void Configure(EntityTypeBuilder<BookGenre> builder)
        {
            builder.Property(b => b.GenreId).IsRequired();
            builder.HasData(
                 new BookGenre
                 {
                     Id = 1,
                     GenreId = 1,
                     BookId = 1,
                 }
            );
        }
    }
}
