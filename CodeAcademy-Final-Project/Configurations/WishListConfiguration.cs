using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations
{
    public class WishListConfiguration : IEntityTypeConfiguration<WishList>
    {
        public void Configure(EntityTypeBuilder<WishList> builder)
        {
            builder.Property(wl => wl.Name)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(wl => wl.IsPrivate)
                .IsRequired()
                .HasDefaultValue(false);
            builder.Property(wl => wl.IsMain)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}
