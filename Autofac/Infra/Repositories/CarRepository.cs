using Domain;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class CarRepository : ICarRepository
    {
        public Task DeleteCarAsync(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetCarAsync(long idCar)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Car>> GetCarsAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveCarAsync(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
