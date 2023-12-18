﻿using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.Property(p => p.Name)
                .IsRequired();
            builder.HasData(
                new { Name = "Azerbaijany" },
                new { Name = "English" }

                );
        }
    }
}
