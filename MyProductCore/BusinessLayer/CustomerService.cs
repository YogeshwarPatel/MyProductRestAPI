using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyProductCore.BusinessLayer.Contracts;
using MyProductCore.BusinessLayer.Responses;
using MyProductCore.DataLayer;
using MyProductCore.EntityLayer.myProduct;
using MyProductCore.DataLayer.Repositories;


namespace MyProductCore.BusinessLayer
{
    public class CustomerService : Service, ICustomerService
    {

        public CustomerService(ILogger<CustomerService> logger, IUserInfo userInfo, myProductDBContext myPDBContext)
            : base(logger, userInfo, myPDBContext)
        {

        }

        public async Task<IPagedResponse<Customer>> GetAllCustomers(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogDebug("{0} has been invoked", nameof(GetAllCustomers));
            
            var response = new PagedResponse<Customer>();

            try
            {
                // Get query
                var query = customerRepository.GetAllCustomers(pageSize, pageNumber);
                // Set information for paging
                response.PageSize = pageSize;
                response.PageNumber = pageNumber;
                response.ItemsCount = await query.CountAsync();
                // Retrieve items, set model for response
                response.Model = await query.Paging(pageSize, pageNumber).ToListAsync();
            }
            catch (Exception ex)
            {
                response.SetError(ex, Logger);
            }

            return response;
        }

        public async Task<ISingleResponse<Customer>> GetCustomer(string CustomerCode)
        {
            //throw new NotImplementedException();
            Logger?.LogDebug("{0} has been invoked", nameof(GetCustomer));

            var response = new SingleResponse<Customer>();

            try
            {
                // Retrieve order by id
                response.Model = await customerRepository.GetCustomer(CustomerCode);
            }
            catch (Exception ex)
            {
                response.SetError(ex, Logger);
            }

            return response;
        }

        public Task<Customer> SearchCustomers(string SearchText, int pageSize = 10, int pageNumber = 1)
        {
            throw new NotImplementedException();
        }
    }
}

