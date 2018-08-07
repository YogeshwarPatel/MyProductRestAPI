using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Store.Core.DataLayer.Contracts;
using Store.Core.EntityLayer.myProduct;

namespace Store.Core.DataLayer.Repositories
{
    public class BranchRepository : Repository, IBranchRepository
    {
        public BranchRepository(IUserInfo userInfo, myProductDBContext dbContext)
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

        public  IQueryable<Branch> GetBranches(int pageSize, int pageNumber)
        {
            return DbContext.Set<Branch>().AsQueryable();
        }


        public Task<Branch> GetBranchByBranchCodeAsync(string BranchCode)
        {

            var query = DbContext.Set<Branch>().AsQueryable();

            query = query.Where(item => item.branch_code == BranchCode);

            return query.FirstAsync();

        }
    }
}
