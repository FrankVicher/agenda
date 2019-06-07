using agenda.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace agenda.Data.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(p => p.ContactId);
            builder.Property(p => p.Company)
                .HasMaxLength(50);
            builder.Property(p => p.Name)
                .HasMaxLength(255)
                .IsRequired();
            builder.HasMany(p => p.Addresses)
                .WithOne();
            builder.HasMany(p => p.Mails);
            builder.HasMany(p => p.Phones);

        }
    }
}
