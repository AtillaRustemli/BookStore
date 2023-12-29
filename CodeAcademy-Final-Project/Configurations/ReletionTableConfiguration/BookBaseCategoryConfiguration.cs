using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class BookBaseCategoryConfiguration : IEntityTypeConfiguration<BookBaseCategory>
    {
        public void Configure(EntityTypeBuilder<BookBaseCategory> builder)
        {
            builder.Property(bc => bc.BookBaseId).IsRequired();
            builder.Property(bc => bc.CategoryId).IsRequired();
            builder.Property(bc => bc.TypeId).IsRequired();
            builder.HasOne(bc => bc.Book).
                WithMany()
                .HasForeignKey(bc => bc.BookBaseId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(bc => bc.ABook).
                WithMany()
                .HasForeignKey(bc => bc.BookBaseId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(bc => bc.EBook).
                WithMany()
                .HasForeignKey(bc => bc.BookBaseId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(bc => bc.Category).
                WithMany()
                .HasForeignKey(bc => bc.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasData(
                 new BookBaseCategory
                 {
                     Id = 1,
                     BookBaseId = 1,
                     CategoryId = 1,
                     TypeId = 1


                 },
            new BookBaseCategory
            {
                Id = 2,
                BookBaseId = 1,
                CategoryId = 1,
                TypeId = 1

            },
            new BookBaseCategory
            {

                Id = 3,
                BookBaseId = 1,
                CategoryId = 1,
                TypeId = 1

            }
            );
        }
    }
}
