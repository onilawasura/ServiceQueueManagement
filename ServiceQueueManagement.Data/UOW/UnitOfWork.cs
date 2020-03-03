using ServiceQueueManagement.Core.Repositories;
using ServiceQueueManagement.Data.Context;
using ServiceQueueManagement.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceQueueManagement.Data.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ServiceQueueDbContext _context;
        private CustomerRepository _customerRepository;
        private CustomerServiceRepositry _customerServiceRepositry;
        private EmployeeServiceRepository _employeeServiceRepository;
        private AppoinmentRepository _appoinmentRepository;

        public UnitOfWork(ServiceQueueDbContext context)
        {
            this._context = context;
        }

        public ICustomerServiceRepositry CustomerService => _customerServiceRepositry ?? new CustomerServiceRepositry(_context);

        public IEmployeeServiceRepository employeeService => _employeeServiceRepository ?? new EmployeeServiceRepository(_context);

        public IAppoinmentRepository appoinmentRepository => _appoinmentRepository ?? new AppoinmentRepository(_context);

        //public CustomerRepository Customerr => _customerRepository ?? new CustomerRepository(_context);

        ICustomerRepository IUnitOfWork.Customer => _customerRepository ?? new CustomerRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void CommitChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
