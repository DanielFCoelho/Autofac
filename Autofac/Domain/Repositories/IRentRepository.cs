using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IRentRepository
    {
        Task AddAsync(Rent rent);
        Task<Rent> GetByIdAsync(long rentId);
        void DeleteAsync(Rent rent);
        void Update(Rent rent);
    }
}
