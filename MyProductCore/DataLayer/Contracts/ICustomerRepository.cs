using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using MyProductCore.EntityLayer.myProduct;


namespace MyProductCore.DataLayer.Contracts
{
    public interface  ICustomerRepository : IRepository
    {
        IQueryable<Customer> SearchCustomers(string SearchText, Int32 pageSize = 10, Int32 pageNumber = 1);

        Task<Customer> GetCustomer(string CustomerCode);

        IQueryable<Customer> GetAllCustomers(Int32 pageSize = 10, Int32 pageNumber = 1);
    }
}

