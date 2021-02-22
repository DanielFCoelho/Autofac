using Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace Domain
{
    public class Rent
    {
        private readonly IRentRepository _rentRepository;

        public Rent(IRentRepository rentRepository)
        {
            _rentRepository = rentRepository;
        }

        public long Id { get; set; }
        public Car Car { get; set; }
        public DateTime RentDate { get; set; }
        public double RentPrice { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public bool IsActive { get; set; }

        public async Task Save(Rent rent)
        {
            await _rentRepository.AddAsync(rent);
        }

        public void Checkout(DateTime date)
        {
            CheckoutDate = date;
            _rentRepository.Update(this);
        }

        public void ClearRent()
        {
            DeliveryDate = DateTime.Now;
            IsActive = false;
            _rentRepository.Update(this);
        }

        public void Cancel()
        {
            IsActive = false;
            _rentRepository.Update(this);
        }
    }
}
