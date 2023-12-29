﻿using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations.ReletionTableConfiguration
{
    public class BookBaseAuthorConfiguration : IEntityTypeConfiguration<BookBaseAuthor>
    {
        public void Configure(EntityTypeBuilder<BookBaseAuthor> builder)
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

            builder.HasOne(ba => ba.Author)
                .WithMany()
                .HasForeignKey(ba => ba.AuthorId)
                .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired(false);
            builder.HasData(
                 new BookBaseAuthor
                 {
                     Id = 1,
                     AuthorId = 1,
                     BookBaseId = 1,
                     TypeId = 1
                   

                 },
            new BookBaseAuthor
            {
                Id = 2,
                AuthorId = 1,
                BookBaseId = 1,
                TypeId = 2

            },
            new BookBaseAuthor
            {
                Id = 3,
                AuthorId = 1,
                BookBaseId = 1,
                TypeId = 3

            }
            );



        }
    }
}