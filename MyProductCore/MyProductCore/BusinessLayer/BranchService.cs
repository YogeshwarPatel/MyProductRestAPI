using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Store.Core.BusinessLayer.Contracts;
using Store.Core.BusinessLayer.Responses;
using Store.Core.DataLayer;
using Store.Core.EntityLayer.myProduct;
using Store.Core.DataLayer.Repositories;



namespace Store.Core.BusinessLayer
{
    public class BranchService : Service, IBranchService
    {
        public BranchService(ILogger<BranchService> logger, IUserInfo userInfo, myProductDBContext dbContext, myProductDBContext myPDBContext) //TODO Yogesh remove duplicate parameter
            : base(logger, userInfo, dbContext, myPDBContext)
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


