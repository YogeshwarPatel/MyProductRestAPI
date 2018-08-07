using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Core.EntityLayer.myProduct;


namespace Store.Core.DataLayer.Mapping.myProduct
{
    class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            // Mapping for table
            builder.ToTable("Branches", "myProduct");

            // Set key for entity
            builder.HasKey(b => b.branch_code);

            // Set mapping for columns
            builder.Property(b => b.branch_code).HasColumnType("varchar(25)").IsRequired();
            builder.Property(b => b.branch_desc).HasColumnType("varchar(150)").IsRequired();
            builder.Property(b => b.branch_name).HasColumnType("varchar(255)");
            builder.Property(b => b.area_code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(b => b.area_desc).HasColumnType("varchar(255)").IsRequired();
            builder.Property(b => b.state).HasColumnType("varchar(50)").IsRequired();
            builder.Property(b => b.business_unit_code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(b => b.business_unit_desc).HasColumnType("varchar(255)");
            builder.Property(b => b.business_unit_group).HasColumnType("varchar(16)");
        }
    }
}
