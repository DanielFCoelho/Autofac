using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DatabaseExtensions
{
    public static class CarModelBuilder
    {
        public static ModelBuilder AddCar(this ModelBuilder modelBuilder)
        {
            EntityTypeBuilder<Car> EntityCar = modelBuilder.Entity<Car>();
            EntityCar.ToTable("Car").HasKey(k => k.Id);
            EntityCar.Property(k => k.Model);
            EntityCar.Property(k => k.Brand);
            EntityCar.Property(k => k.Color);
            EntityCar.HasMany(k => k.Rents).WithOne(k => k.Car);

            return modelBuilder;
        }
    }
}
