using CodeAcademy_Final_Project.Models.ReletionTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class ABookAuthorConfiguration:IEntityTypeConfiguration<ABookAuthor>
    {
        public void Configure(EntityTypeBuilder<ABookAuthor> builder)
        {
<<<<<<< HEAD
            builder.Property(b => b.ABookId).IsRequired();
=======
>>>>>>> 1889090b32e2d7e2f33be2b522e3ba9810934869
            builder.Property(b => b.AuthorId).IsRequired();
            builder.HasData(
                 new ABookAuthor
                 {
                     Id = 1,
                     AuthorId = 1,
                     ABookId = 1,
                 }
                 );



        }
    }
}
