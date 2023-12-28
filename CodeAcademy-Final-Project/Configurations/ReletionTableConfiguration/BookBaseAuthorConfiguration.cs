using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class BookBaseAuthorConfiguration : IEntityTypeConfiguration<BookBaseAuthor>
    {
        public void Configure(EntityTypeBuilder<BookBaseAuthor> builder)
        {
            builder.HasOne(ba => ba.Book)
                    .WithMany(b=>b.BookBaseAuthor) 
                    .HasForeignKey(ba => ba.BookId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ba => ba.ABook)
                .WithMany(b => b.BookBaseAuthor) 
                .HasForeignKey(ba => ba.ABookId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ba => ba.EBook)
                .WithMany(b => b.BookBaseAuthor)  
                .HasForeignKey(ba => ba.EBookId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ba => ba.Author)
                .WithMany(b => b.BookBaseAuthor)
                .HasForeignKey(ba => ba.AuthorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
            new BookBaseAuthor
            {
                Id = 1,
                BookId = 1,
                ABookId = null,
                EBookId = null,
                AuthorId=1

            };
            new BookBaseAuthor
            {
                Id = 1,
                BookId = null,
                ABookId = 1,
                EBookId = null,
                AuthorId = 1

            };
            new BookBaseAuthor
            {
                Id = 1,
                BookId = null,
                ABookId = null,
                EBookId = 1,
                AuthorId = 1

            };


        }
    }
}
