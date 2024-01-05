using CodeAcademy_Final_Project.Models.ReletionTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class EBookGenreConfiguration:IEntityTypeConfiguration<EBookGenre>
    {
        public void Configure(EntityTypeBuilder<EBookGenre> builder)
        {
            builder.Property(b => b.GenreId).IsRequired();
            builder.HasData(
                 new EBookGenre
                 {
                     Id = 1,
                     GenreId = 1,
                     EBookId = 1,
                 }
                 );



        }
    }
}
