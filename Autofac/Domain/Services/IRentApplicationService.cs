using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IRentApplicationService
    {
        Task<Rent> MakeARentAsync (Rent rent);

        Task CancelARentAsync(long idRent);
    }
}
