using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(p => p.ImgUrl)
                .IsRequired();
            builder.Property(p=>p.DetailImageUrl)
                .IsRequired();
            builder.HasData(
                new Promotion
                {
                    Id=1,
                    Name="New Year Discount",
                    Title="Amasing new year discount",
                    Description="Look at our fantasting promotion.This is amasing!!!",
                    ImgUrl= "promotion-image1.jpg",
                    DetailImageUrl= "promotion-detail1.jpg",
                    EndTime= DateTime.Now
                }
                );

        }
    }
}
