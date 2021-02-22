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
        IQueryable<Car> GetCarsAsync();
        Task<Car> GetCarAsync(long carId);
        void DeleteCarAsync(Car car);
        void UpdateCarAsync(Car car);       
    }
}
