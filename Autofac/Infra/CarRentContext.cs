using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class CarRentContext : DbContext
    {
        public CarRentContext(DbContextOptions<CarRentContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Rent> Rents { get; set; }
    }
}
