using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy_Final_Project.Configurations
{
    public class SettingKeyValueConfiguration : IEntityTypeConfiguration<SettingKeyValue>
    {
        public void Configure(EntityTypeBuilder<SettingKeyValue> builder)
        {
            builder.Property(p => p.Key)
                .IsRequired();
            builder.Property(p=>p.Value)
                .IsRequired();
            builder.HasData(
                new SettingKeyValue
                {
                    Id=1,
                    Key="Number",
                    Value= "+612 9045 4394"
                }
                );
        }
    }
}
