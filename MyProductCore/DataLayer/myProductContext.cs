using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyProductCore.DataLayer.Mapping;
using MyProductCore.DataLayer.Mapping.myProduct;


namespace MyProductCore.DataLayer
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
            modelBuilder
                .ApplyConfiguration(new CustomerConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
