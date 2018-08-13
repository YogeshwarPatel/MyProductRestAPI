using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyProductCore.DataLayer.DataContracts;
using MyProductCore.EntityLayer.myProduct;
using MyProductCore.BusinessLayer.Requests;
using MyProductCore.BusinessLayer.Responses;




namespace MyProductCore.BusinessLayer.Contracts
{
    public interface ICustomerService : IService
    {

        Task<IPagedResponse<Customer>> GetAllCustomers(Int32 pageSize = 10, Int32 pageNumber = 1);

        Task<Customer> SearchCustomers(string SearchText, Int32 pageSize = 10, Int32 pageNumber = 1);

        Task<Customer> GetCustomer(string CustomerCode);

    }
}



