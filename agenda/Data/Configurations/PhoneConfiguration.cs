using agenda.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace agenda.Data.Configurations
{
    public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.ToTable("Phones");
            builder.HasKey(p => p.PhoneId);
            builder.Property(p => p.Number)
                .HasMaxLength(15)
                .IsRequired();
            builder.Property(p => p.PhoneTypeId)
                .IsRequired();
            builder.Property(p => p.IsActive)
                .IsRequired();
            builder.HasOne(p => p.PhoneType);
        }
    }
}
