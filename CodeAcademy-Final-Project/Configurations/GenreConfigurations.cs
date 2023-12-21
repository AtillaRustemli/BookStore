using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations
{
    public class GenreConfigurations : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(60); 
            builder.HasData(
                new Genre { Id=1, Name="Fanatsy" }
                );

        }
    }
}
