using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface ICarApplicationService
    {
        Task<Car> AddACarAsync(Car car);
        IEnumerable<Car> GetCarsAsync();
        Task<Car> GetCarAsync(long idCar);
        Task<Car> UpdateCarAsync(long idCar, Car car);
        Task DeleteCarAsync(long idCar);
    }
}
