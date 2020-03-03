using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceQueueManagement.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customer { get; }
        ICustomerServiceRepositry CustomerService { get; }
        IEmployeeServiceRepository employeeService { get; }
        IAppoinmentRepository appoinmentRepository { get; }
        Task<int> CommitAsync();
        void CommitChanges();
    }
}
