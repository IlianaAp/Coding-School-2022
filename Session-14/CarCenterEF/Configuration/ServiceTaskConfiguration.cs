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
    public class ServiceTaskConfiguration : IEntityTypeConfiguration<ServiceTask>
    {
        public void Configure(EntityTypeBuilder<ServiceTask> builder)
        {

            builder.ToTable("ServiceTask");
            builder.HasKey(serviceTask => serviceTask.ID);
            builder.Property(serviceTask => serviceTask.Code).HasMaxLength(50).IsRequired();
            builder.Property(serviceTask => serviceTask.Description).HasMaxLength(100).IsRequired();
            builder.Property(serviceTask => serviceTask.Hours).HasPrecision(2,2).IsRequired();
        }
    }
}
