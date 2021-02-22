using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IRentApplicationService
    {
        Task<Rent> MakeARentAsync(Rent rent);
        Task CancelARentAsync(long rentId);
        Task ClearRentAsync(long rentId);
        Task<Car> CheckoutRentAsync(long rentId, DateTime date);
    }
}
