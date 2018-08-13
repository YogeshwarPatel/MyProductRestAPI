using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProductRestAPI.RequestModels;
using MyProductRestAPI.Responses;
using MyProductCore.BusinessLayer.Contracts;

namespace MyProductRestAPI.Controllers
{

    [Route("api/v1/[controller]")]
    public class CustomerController : Controller
    {
        protected ILogger Logger;
        protected ICustomerService CustomerBusinessObject;

        public CustomerController(ILogger<CustomerController> logger, ICustomerService customerBusinessObject)
        {
            Logger = logger;
            CustomerBusinessObject = customerBusinessObject;
        }

        protected override void Dispose(bool disposing)
        {
            CustomerBusinessObject?.Dispose();

            base.Dispose(disposing);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetCustomers(int? pageSize = 10, int? pageNumber = 1)
        {
            Logger?.LogDebug("{0} has been invoked", nameof(GetCustomers));

            // Get response from business logic
            var response = await CustomerBusinessObject.GetAllCustomers((int)pageSize, (int)pageNumber);

            // Return as http response
            return response.ToHttpResponse();
        }


        [HttpGet("{CustomerCode}")]
        public async Task<IActionResult>  GetCustomer(string CustomerCode)
        {
            Logger?.LogDebug("{0} has been invoked", nameof(GetCustomer));

            // Get response from business logic
            var response = await CustomerBusinessObject.GetCustomer(CustomerCode);

            // Return as http response
            return response.ToHttpResponse();
        }
    }

}