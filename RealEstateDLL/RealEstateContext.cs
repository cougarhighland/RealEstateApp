using Microsoft.EntityFrameworkCore;
using RealEstateDLL.Entities;

namespace RealEstateDLL
{
    public class RealEstateContext : DbContext
    {
        public DbSet<Estate> Estates { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RealEstateDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure one-to-one relationship between Estate and Address
            modelBuilder.Entity<Estate>()
                 .HasOne(e => e.Address)
                 .WithOne(a => a.Estate)
                .HasForeignKey<Estate>(e => e.AddressId);
        }
    }
}
