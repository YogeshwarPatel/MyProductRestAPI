﻿using Microsoft.Extensions.Logging;
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
        protected readonly myProductDBContext DbContext; //TODO Yogesh remmove this
        protected IBranchRepository m_branchRepository;

        public Service(ILogger logger, IUserInfo userInfo, myProductDBContext dbContext, myProductDBContext myprodPDBContext) // TODO Yogesh remove duplicate parameter
        {
            Logger = logger;
            UserInfo = userInfo;
            DbContext = dbContext;
            myPDBContext = myprodPDBContext;
        }

        public void Dispose()
        {
            if (!Disposed)
            {
                DbContext?.Dispose();

                Disposed = true;
            }
        }
        
        protected IBranchRepository branchRepository
            => m_branchRepository ?? (m_branchRepository = new BranchRepository(UserInfo, myPDBContext));
    }
}