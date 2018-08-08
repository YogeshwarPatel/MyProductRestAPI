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
    public interface IBranchService : IService
    {

        Task<IPagedResponse<Branch>> GetBranches(Int32 pageSize = 10, Int32 pageNumber = 1);

        //Task<ISingleResponse<Branch>> GetBranchAsync(Branch entity);
        Task<ISingleResponse<Branch>> GetBranchByBranchCodeAsync(string branchCode);

    }
}



