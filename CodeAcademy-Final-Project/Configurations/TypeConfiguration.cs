using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations
{
    public class TypeConfiguration : IEntityTypeConfiguration<BType>
    {

        public void Configure(EntityTypeBuilder<BType> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(60);
            builder.HasData(
                new BType { Id = 1, Name = "Book" },
                new BType { Id = 2, Name = "eBook" },
                new BType { Id = 3, Name = "aBook" }
                );
        }
    }
}
