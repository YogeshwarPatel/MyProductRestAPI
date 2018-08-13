using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyProductCore.DataLayer.Contracts;
using MyProductCore.EntityLayer.myProduct;

namespace MyProductCore.DataLayer.Repositories
{
    public class CustomerRepository : Repository, ICustomerRepository
    {
        public CustomerRepository(IUserInfo userInfo, myProductDBContext dbContext)
            : base(userInfo, dbContext)
        {
        }

        int IRepository.CommitChanges()
        {
            throw new NotImplementedException();
        }

        Task<int> IRepository.CommitChangesAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> GetAllCustomers(int pageSize, int pageNumber)
        {
            return DbContext.Set<Customer>().AsQueryable();
        }

        public Task<Customer> GetCustomer(string CustomerCode)
        {
            var query = DbContext.Set<Customer>().AsQueryable();

            query = query.Where(item => item.CustomerCode == CustomerCode);

            return query.FirstAsync();
        }

        public IQueryable<Customer> SearchCustomers(string SearchText, int pageSize, int pageNumber)
        {
            return DbContext.Set<Customer>().AsQueryable(); // TODO
        }

        
    }
}
