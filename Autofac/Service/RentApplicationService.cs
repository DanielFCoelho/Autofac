using Domain;
using Domain.Repositories;
using Domain.Services;
using System;
using System.Threading.Tasks;

namespace Service
{
    public class RentApplicationService : IRentApplicationService
    {
        private readonly IRentRepository _rentRepository;

        public RentApplicationService(IRentRepository rentRepository)
        {
            _rentRepository = rentRepository;
        }

        public async Task CancelARentAsync(long rentId)
        {
            Rent rent = await _rentRepository.GetByIdAsync(rentId);
            rent.Cancel();
        }

        public async Task<Car> CheckoutRentAsync(long rentId, DateTime date)
        {
            Rent rent = await _rentRepository.GetByIdAsync(rentId);
            rent.Checkout(date);
            return rent.Car;
        }

        public async Task ClearRentAsync(long rentId)
        {
            Rent rent = await _rentRepository.GetByIdAsync(rentId);
            rent.ClearRent();
        }

        public async Task<Rent> MakeARentAsync(Rent rent)
        {
            
        }
    }
}
