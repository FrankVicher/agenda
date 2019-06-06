using agenda.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace agenda.Data.Configurations
{
    public class PhoneTypeConfiguration : IEntityTypeConfiguration<PhoneType>
    {
        public void Configure(EntityTypeBuilder<PhoneType> builder)
        {
            builder.ToTable("PhoneTypes");
            builder.HasKey(p => p.PhoneTypeId);
            builder.Property(p => p.Name)
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(p => p.IsActive)
                .IsRequired();
            builder.HasData(
                new PhoneType { IsActive = true, Name = "Movil", PhoneTypeId = 1 },
                new PhoneType { IsActive = true, Name = "Trabajo", PhoneTypeId = 2 },
                new PhoneType { IsActive = true, Name = "Casa", PhoneTypeId = 3 },
                new PhoneType { IsActive = true, Name = "Fax", PhoneTypeId = 4 },
                new PhoneType { IsActive = true, Name = "Localizador", PhoneTypeId = 5 },
                new PhoneType { IsActive = true, Name = "Otro", PhoneTypeId = 6 }
                );
        }
    }
}
