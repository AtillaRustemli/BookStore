using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class BookTypeConfiguration : IEntityTypeConfiguration<BookBType>
    {
        public void Configure(EntityTypeBuilder<BookBType> builder)
        {
            builder.Property(p=>p.BookId)
                .IsRequired();
            builder.Property(p=>p.BTypeId)
                .IsRequired();
            builder.HasData(
                new BookBType
                {
                    Id = 1,
                    BTypeId = 1,
                    BookId = 1
                }

                );
        }
    }
}
