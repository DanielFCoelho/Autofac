using Domain;
using Domain.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarRentContext _context;

        public CarRepository(CarRentContext context)
        {
            _context = context;
        }

        public void DeleteCarAsync(Car car)
        {
            _context.Remove(car);
        }

        public async Task<Car> GetCarAsync(long idCar)
        {
            return await _context.Cars.FindAsync( idCar);
        }

        public IQueryable<Car> GetCarsAsync()
        {
            return _context.Cars;
        }

        public async Task SaveCarAsync(Car car)
        {
            await _context.AddAsync(car);
        }

        public void UpdateCarAsync(Car car)
        {
            _context.Update(car);
        }
    }
}
