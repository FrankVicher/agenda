using agenda.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace agenda.Data.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(p => p.AddressId);
            builder.Property(p => p.City)
                .HasMaxLength(50)
                .IsRequired(false);
            builder.Property(p => p.Code)
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(p => p.Country)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(p => p.Number)
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(p => p.State)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(p => p.Street)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
