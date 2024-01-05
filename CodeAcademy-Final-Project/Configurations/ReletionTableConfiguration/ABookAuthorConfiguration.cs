using CodeAcademy_Final_Project.Models.ReletionTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class ABookAuthorConfiguration:IEntityTypeConfiguration<ABookAuthor>
    {
        public void Configure(EntityTypeBuilder<ABookAuthor> builder)
        {
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
