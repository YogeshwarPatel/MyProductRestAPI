using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Store.Core.DataLayer.DataContracts;
using Store.Core.EntityLayer.myProduct;
using Store.Core.BusinessLayer.Requests;
using Store.Core.BusinessLayer.Responses;




namespace Store.Core.BusinessLayer.Contracts
{
    public interface IBranchService : IService
    {

        Task<IPagedResponse<Branch>> GetBranches(Int32 pageSize = 10, Int32 pageNumber = 1);

        //Task<ISingleResponse<Branch>> GetBranchAsync(Branch entity);
        Task<ISingleResponse<Branch>> GetBranchByBranchCodeAsync(string branchCode);

    }
}



