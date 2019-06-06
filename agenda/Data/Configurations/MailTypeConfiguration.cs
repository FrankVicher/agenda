using agenda.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace agenda.Data.Configurations
{
    public class MailTypeConfiguration : IEntityTypeConfiguration<MailType>
    {
        public void Configure(EntityTypeBuilder<MailType> builder)
        {
            builder.ToTable("MailTypes");
            builder.HasKey(p => p.MailTypeId);
            builder.Property(p => p.Name)
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(p => p.IsActive)
                .IsRequired();
            builder.HasData(
                new MailType { IsActive = true, MailTypeId = 1, Name = "Trabajo" },
                new MailType { IsActive = true, MailTypeId = 2, Name = "Personal" },
                new MailType { IsActive = true, MailTypeId = 3, Name = "Otro" }
                );
        }
    }
}
