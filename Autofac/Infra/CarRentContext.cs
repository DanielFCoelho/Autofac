using Domain;
using Microsoft.EntityFrameworkCore;
using Infra.DatabaseExtensions;

namespace Infra
{
    public class CarRentContext : DbContext
    {
        public CarRentContext(DbContextOptions<CarRentContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Rent> Rents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("RentCar");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddCar();
            modelBuilder.AddRent();
            base.OnModelCreating(modelBuilder);
        }
    }
}
