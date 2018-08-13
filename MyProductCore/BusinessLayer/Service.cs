using Microsoft.Extensions.Logging;
using MyProductCore.BusinessLayer.Contracts;
using MyProductCore.DataLayer;
using MyProductCore.DataLayer.Contracts;
using MyProductCore.DataLayer.Repositories;

namespace MyProductCore.BusinessLayer
{
    public abstract class Service : IService
    {
        protected ILogger Logger;
        protected IUserInfo UserInfo;
        protected bool Disposed;
        protected readonly myProductDBContext myPDBContext;
        protected IBranchRepository m_branchRepository;
        protected ICustomerRepository m_customerRepository;

        public Service(ILogger logger, IUserInfo userInfo,  myProductDBContext myprodPDBContext) 
        {
            Logger = logger;
            UserInfo = userInfo;
            myPDBContext = myprodPDBContext;
        }

        public void Dispose()
        {
            if (!Disposed)
            {
                myPDBContext?.Dispose();
                Disposed = true;
            }
        }
        
        protected IBranchRepository branchRepository
            => m_branchRepository ?? (m_branchRepository = new BranchRepository(UserInfo, myPDBContext));

        protected ICustomerRepository customerRepository
            => m_customerRepository ?? (m_customerRepository = new CustomerRepository(UserInfo, myPDBContext));
    }
}
