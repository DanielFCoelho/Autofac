using Domain;
using Domain.Services;
using System;
using System.Threading.Tasks;

namespace Service
{
    public class RentApplicationService : IRentApplicationService
    {
        public Task CancelARentAsync(long idRent)
        {
            throw new NotImplementedException();
        }

        public Task<Rent> MakeARentAsync(Rent rent)
        {
            throw new NotImplementedException();
        }
    }
}
