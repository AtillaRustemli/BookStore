using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations
{
    public class ABookChapterConfiguration : IEntityTypeConfiguration<ABookChapter>
    {
        public void Configure(EntityTypeBuilder<ABookChapter> builder)
        {
            builder.Property(abc=>abc.ABookUrl)
                .IsRequired();
            builder.Property(abc=>abc.ABookId) 
                .IsRequired();
            builder.HasData(
                new ABookChapter
                {
                    Id=1,
                    ABookUrl="",
                    ABookId=1
                }
                );
        }
    }
}
