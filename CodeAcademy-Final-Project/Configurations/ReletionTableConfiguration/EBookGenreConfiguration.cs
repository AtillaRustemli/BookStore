using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class EBookGenreConfiguration : IEntityTypeConfiguration<EBookGenre>
    {
        public void Configure(EntityTypeBuilder<EBookGenre> builder)
        {
            
            builder.Property(ebg=>ebg.GenreId).IsRequired();
            builder.Property(ebg=>ebg.EBookId).IsRequired();
            builder.HasData(
                new EBookGenre
                {
                    Id=1,
                    GenreId = 1,
                    EBookId = 1,
                }
                );
        }
    }
}
