using CodeAcademy_Final_Project.Models.ReletionTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class EBookCategoryConfiguration:IEntityTypeConfiguration<EBookCategory>
    {

        public void Configure(EntityTypeBuilder<EBookCategory> builder)
        {
            builder.Property(b => b.CategoryId).IsRequired();
            builder.HasData(
                 new EBookCategory
                 {
                     Id = 1,
                     CategoryId = 1,
                     EBookId = 1,
                 }
                 );



        }
    }
}
