using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ICarRepository
    {
        Task SaveCarAsync(Car car);
        Task<IQueryable<Car>> GetCarsAsync();
        Task<Car> GetCarAsync(long idCar);
        Task DeleteCarAsync(Car car);
    }
}
