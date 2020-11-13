using Domain;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class RentRepository : IRentRepository
    {
        public Task DeleteRentAsync(Rent rent)
        {
            throw new NotImplementedException();
        }

        public Task SaveRentAsync(Rent rent)
        {
            throw new NotImplementedException();
        }
    }
}
