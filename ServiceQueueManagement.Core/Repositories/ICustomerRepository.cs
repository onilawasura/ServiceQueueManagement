using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceQueueManagement.Core.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {

        Task<IEnumerable<Customer>> GetAllWithServiceAsync();

        Task<IEnumerable<Customer>> GetCustomerLikeAddress(string aaa);

        /// <summary>
        /// Retrieves list of customers available
        /// </summary>
        /// <returns>List of cutomers</returns>
        List<Customer> GetAllCustomers();
    }
}
