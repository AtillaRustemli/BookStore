using CodeAcademy_Final_Project.Models.ReletionTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class ABookGenreConfiguration:IEntityTypeConfiguration<ABookGenre>
    {
        public void Configure(EntityTypeBuilder<ABookGenre> builder)
        {
            builder.Property(b => b.GenreId).IsRequired();
            builder.HasData(
                 new ABookGenre
                 {
                     Id = 1,
                     GenreId = 1,
                     ABookId = 1,
                 }
                 );



        }
    }
}
