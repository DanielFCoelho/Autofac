using Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain
{
    public class Car
    {
        private readonly ICarRepository _carRepository;

        public long Id { get; set; }
        public string Model { get; set; }
        public Color Color { get; set; }
        public Type Type { get; set; }
        public Brand Brand { get; set; }
        public IEnumerable<Rent> Rents { get; set; }

        public Car(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        private Car()
        {

        }

        public async Task Save()
        {
            await _carRepository.SaveCarAsync(this);
        }

        public void Delete()
        {
            _carRepository.DeleteCarAsync(this);
        }

        public void Update(Car newCar)
        {
            Model = newCar.Model;
            Color = newCar.Color;
            Type = newCar.Type;
            Brand = newCar.Brand;

            _carRepository.UpdateCarAsync(this);
        }

        public async Task Rent()
        {
            await _carRepository.RentCarAsync(this);
        }

        public async Task Delivery()
        {
            await _carRepository.DeliveryCarAsync(this);
        }

        public static class CarFactory
        {
            public static Car CreateCar(string model, Color color, Type type, Brand brand)
            {
                return new Car()
                {
                    Model = model,
                    Color = color,
                    Type = type,
                    Brand = brand
                };
            }
        }
    }
}
