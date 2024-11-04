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
            // Set up primary key for Estate
            modelBuilder.Entity<Estate>()
                .Property(e => e.ID)
                .ValueGeneratedOnAdd();

            // Configure one-to-one relationship between Estate and Address
            modelBuilder.Entity<Estate>()
                .HasOne(e => e.Address)
                .WithMany()
                .HasForeignKey(e => e.AddressId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
