using Domain;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CarApplicationService : ICarApplicationService
    {
        public Task<Car> AddACarAsync(Car car)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCarAsync(long idCar)
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetCarAsync(long idCar)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetCarsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Car> UpdateCarAsync(long idCar, Car car)
        {
            throw new NotImplementedException();
        }
    }
}
