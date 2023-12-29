using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class BookBaseGenreConfiguration : IEntityTypeConfiguration<BookBaseGenre>
    {
        public void Configure(EntityTypeBuilder<BookBaseGenre> builder)
        {
            builder.HasOne(ba => ba.Book)
                    .WithMany()
                    .HasForeignKey(ba => ba.BookBaseId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired(false);

            builder.HasOne(ba => ba.ABook)
                .WithMany()
                .HasForeignKey(ba => ba.BookBaseId)
                .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired(false);

            builder.HasOne(ba => ba.EBook)
                .WithMany()
                .HasForeignKey(ba => ba.BookBaseId)
                .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired(false);

            builder.HasOne(ba => ba.Genre)
                .WithMany()
                .HasForeignKey(ba => ba.GenreId)
                .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired(false);
            builder.HasData(
                 new BookBaseGenre
                 {
                     Id = 1,
                     GenreId = 1,
                     BookBaseId = 1,
                     TypeId = 1
                 },
            new BookBaseGenre
            {
                Id = 2,
                GenreId = 1,
                BookBaseId = 1,
                TypeId = 2

            },
            new BookBaseGenre
            {
                Id = 3,
                GenreId = 1,
                BookBaseId = 1,
                TypeId = 3

            }
            );
        }
    }
}
