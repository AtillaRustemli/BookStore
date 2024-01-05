using CodeAcademy_Final_Project.Models.ReletionTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class ABookCategoryConfiguration:IEntityTypeConfiguration<ABookCategory>
    {
        public void Configure(EntityTypeBuilder<ABookCategory> builder)
        {
            builder.Property(b => b.CategoryId).IsRequired();
            builder.HasData(
                 new ABookCategory
                 {
                     Id = 1,
                     CategoryId = 1,
                     ABookId = 1,
                 }
                 );



        }
    }
}
