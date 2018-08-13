using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProductCore.EntityLayer.myProduct;


namespace MyProductCore.DataLayer.Mapping.myProduct
{
    class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Mapping for table
            builder.ToTable("Customers", "myProduct");

            // Set key for entity
            builder.HasKey(b => b.CustomerCode);

            // Set mapping for columns
            builder.Property(b => b.CustomerCode).HasColumnType("varchar(20)").IsRequired();
            builder.Property(b => b.CustomerName).HasColumnType("varchar(50)");
            builder.Property(b => b.BillingAddress).HasColumnType("varchar(200)");
            builder.Property(b => b.DeliveryAddress).HasColumnType("varchar(200)");
            builder.Property(b => b.DeliveryPhone).HasColumnType("varchar(20)");
            builder.Property(b => b.BillingState).HasColumnType("varchar(10)");
            builder.Property(b => b.BillingPostcode).HasColumnType("varchar(10)");
        }
    }
}
