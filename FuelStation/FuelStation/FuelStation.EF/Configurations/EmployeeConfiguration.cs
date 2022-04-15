using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.ID).ValueGeneratedOnAdd();
            builder.Property(employee => employee.Name).HasMaxLength(30);
            builder.Property(employee => employee.Surname).HasMaxLength(30);
            builder.Property(employee => employee.SallaryPerMonth).HasPrecision(9, 2);
            builder.Property(employee => employee.EmployeeType).HasConversion<int>();
            builder.Property(employee => employee.Username).HasMaxLength(30);
            builder.Property(employee => employee.Password).HasMaxLength(40);
            builder.HasIndex(employee => employee.Username).IsUnique();
        }
    }
}
