using Domain;
using Domain.Repositories;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CarApplicationService : ICarApplicationService
    {
        private readonly ICarRepository _carRepository;

        public CarApplicationService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<Car> AddACarAsync(Car car)
        {
            await car.Save();
            return car;
        }

        public async Task DeleteCarAsync(long idCar)
        {
            Car car = await _carRepository.GetCarAsync(idCar);
            car.Delete();
        }

        public async Task<Car> GetCarAsync(long idCar)
        {
            return await _carRepository.GetCarAsync(idCar);
        }

        public IEnumerable<Car> GetCarsAsync()
        {
            return _carRepository.GetCarsAsync();
        }

        public async Task<Car> UpdateCarAsync(long idCar, Car car)
        {
            Car repositoryCar = await _carRepository.GetCarAsync(idCar);
            repositoryCar.Update(car);

            return repositoryCar;

        }
    }
}
