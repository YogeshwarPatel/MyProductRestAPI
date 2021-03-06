﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using MyProductCore.EntityLayer.myProduct;


namespace MyProductCore.DataLayer.Contracts
{
    public interface  IBranchRepository : IRepository
    {
        IQueryable<Branch> GetBranches(Int32 pageSize = 10, Int32 pageNumber = 1);

        Task<Branch> GetBranchByBranchCodeAsync(string BranchCode);
    }
}

