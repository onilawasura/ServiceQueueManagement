using ServiceQueueManagement.Core.Models;
using ServiceQueueManagement.Core.Repositories;
using ServiceQueueManagement.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceQueueManagement.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ServiceQueueDbContext context)
            : base(context)
        { }

        public List<Customer> GetAllCustomers()
        {
            return _Context.Customers.ToList();
        }

        public Task<IEnumerable<Customer>> GetAllWithServiceAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetCustomerLikeAddress(string aaa)
        {
            throw new NotImplementedException();
        }
    }
}
