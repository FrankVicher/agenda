

namespace agenda.Data
{
    using agenda.Data.Configurations;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MailTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PhoneTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
