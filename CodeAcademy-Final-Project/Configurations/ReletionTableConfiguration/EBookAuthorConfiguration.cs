using CodeAcademy_Final_Project.Models.ReletionTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class EBookAuthorConfiguration:IEntityTypeConfiguration<EBookAuthor>
    {
      
        public void Configure(EntityTypeBuilder<EBookAuthor> builder)
        {
            builder.Property(b => b.AuthorId).IsRequired();
            builder.HasData(
                 new EBookAuthor
                 {
                     Id = 1,
                     AuthorId = 1,
                     EBookId = 1,
                 }
                 );



        }
    }
}
