using Domain;
using Domain.Repositories;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class RentRepository : IRentRepository
    {
        private readonly CarRentContext _context;

        public RentRepository(CarRentContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Rent rent)
        {
            await _context.AddAsync(rent);
        }

        public void DeleteAsync(Rent rent)
        {
            _context.Remove(rent);
        }

        public async Task<Rent> GetByIdAsync(long rentId)
        {
            return await _context.Rents.Include(r => r.Car).FirstOrDefaultAsync(r => r.Id == rentId);
        }

        public void Update(Rent rent)
        {
            _context.Update(rent);
        }
    }
}
