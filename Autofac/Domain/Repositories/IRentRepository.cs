using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IRentRepository
    {
        Task SaveRentAsync(Rent rent);
        Task DeleteRentAsync(Rent rent);
    }
}
