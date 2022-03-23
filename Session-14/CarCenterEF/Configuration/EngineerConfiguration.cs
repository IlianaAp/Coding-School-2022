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
    public class EngineerConfiguration : IEntityTypeConfiguration<Engineer>
    {
        public void Configure(EntityTypeBuilder<Engineer> builder)
        {
            builder.ToTable("Engineer");
            builder.HasKey(engineer => engineer.ID);
            builder.Property(engineer => engineer.Name).HasMaxLength(30);
            builder.Property(engineer => engineer.Surname).HasMaxLength(50);
            builder.HasOne(engineer => engineer.Manager).WithMany(manager => manager.Engineers).HasForeignKey(engineer => engineer.ManagerID);
            builder.Property(engineer => engineer.SallaryPerMonth).HasPrecision(9, 2);
        }
    }
}
