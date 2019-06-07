using agenda.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace agenda.Data.Configurations
{
    public class MailConfiguration : IEntityTypeConfiguration<Mail>
    {
        public void Configure(EntityTypeBuilder<Mail> builder)
        {
            builder.HasKey(p => p.MailId);
            builder.Property(p => p.MailAddress)
                .HasMaxLength(254)
                .IsRequired();
            builder.Property(p => p.IsActive)
                .IsRequired();
            builder.HasOne(p => p.Type);

        }
    }
}
