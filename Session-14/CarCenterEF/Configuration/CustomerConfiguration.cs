using CarServiceCenterLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterEF.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.Name).HasMaxLength(30);
            builder.Property(customer => customer.Surname).HasMaxLength(50);
            builder.Property(customer => customer.TIN).HasMaxLength(10);
            builder.Property(customer => customer.Phone).HasMaxLength(10);

        }
    }
}
