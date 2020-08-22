using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DatabaseExtensions
{
    public static class RentModelBuilder
    {
        public static ModelBuilder AddRent(this ModelBuilder modelBuilder)
        {
            EntityTypeBuilder<Rent> EntityRent = modelBuilder.Entity<Rent>();
            EntityRent.ToTable("Rent").HasKey(k => k.Id);
            EntityRent.Property(k => k.RentDate);
            EntityRent.Property(k => k.RentPrice);
            EntityRent.HasOne(k => k.Car).WithMany(k => k.Rents);

            return modelBuilder;
        }
    }
}
