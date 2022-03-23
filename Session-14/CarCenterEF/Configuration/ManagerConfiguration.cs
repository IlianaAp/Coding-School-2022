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
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.ToTable("Manager");
            builder.HasKey(manager => manager.ID);
            builder.Property(manager => manager.Name).HasMaxLength(30);
            builder.Property(manager => manager.Surname).HasMaxLength(50);
            builder.HasMany(manager => manager.Engineers).WithOne(engineer => engineer.Manager).HasForeignKey(engineer => engineer.ManagerID);
            builder.Property(manager => manager.SallaryPerMonth).HasColumnType("decimal(9,2)");
        }
    }
}
