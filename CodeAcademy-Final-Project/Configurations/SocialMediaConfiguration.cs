using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations
{
    public class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
    {
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            builder.HasData(
                new SocialMedia
                {
                    Id = 1,
                    Facebook= "https://www.facebook.com/",
                    Twitter= "https://twitter.com/",
                    Pinterest= "https://www.pinterest.com/"
                }
                );
        }
    }
}
