using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using planter.Domain.Entities;

namespace planter.Domain.Common;
public interface ICustomerRepository
{
    Task<Customer> GetByIdAsync(Guid id);

    Task AddAsync(Customer customer);
}