using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStation.Models.Enums;

namespace FuelStation.EF.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(item  => item.ID);
            builder.Property(item => item.ID).ValueGeneratedOnAdd();
            builder.Property(item => item.ItemType).HasConversion<int>();
            builder.Property(item => item.Code).HasMaxLength(30);
            builder.Property(item => item.Description).HasMaxLength(30);
            builder.Property(item => item.Price).HasPrecision(9, 2);
            builder.Property(item => item.Cost).HasPrecision(9, 2);
            builder.HasIndex(item => item.Code).IsUnique();
        }
    }
}
