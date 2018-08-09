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
    public class BranchService : Service, IBranchService
    {
        public BranchService(ILogger<BranchService> logger, IUserInfo userInfo,  myProductDBContext myPDBContext) 
            : base(logger, userInfo,  myPDBContext)
        {
        }

        public async Task<ISingleResponse<Branch>> GetBranchByBranchCodeAsync(string branchCode)
        {
            //throw new NotImplementedException();
            Logger?.LogDebug("{0} has been invoked", nameof(GetBranchByBranchCodeAsync));

            var response = new SingleResponse<Branch>();

            try
            {
                // Retrieve order by id
                response.Model = await branchRepository.GetBranchByBranchCodeAsync(branchCode);
            }
            catch (Exception ex)
            {
                response.SetError(ex, Logger);
            }

            return response;


        }



        public async Task<IPagedResponse<Branch>> GetBranches(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetBranches));

            var response = new PagedResponse<Branch>();

            try
            {
                // Get query
                var query = branchRepository.GetBranches(pageSize, pageNumber);

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
    }
}


