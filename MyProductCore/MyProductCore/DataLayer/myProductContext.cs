using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Store.Core.DataLayer.Mapping;
using Store.Core.DataLayer.Mapping.myProduct;


namespace Store.Core.DataLayer
{
    public class myProductDBContext : DbContext
    {
        public myProductDBContext(DbContextOptions<myProductDBContext> options)
          : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply all configurations

            modelBuilder
                .ApplyConfiguration(new BranchConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
