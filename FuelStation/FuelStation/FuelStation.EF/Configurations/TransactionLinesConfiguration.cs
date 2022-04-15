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
    public class TransactionLinesConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLines");
            builder.HasKey(trLine => trLine.ID);
            builder.Property(trLine => trLine.ID).ValueGeneratedOnAdd();
            builder.Property(trLine => trLine.ItemPrice).HasPrecision(9, 2);
            builder.Property(trLine => trLine.DiscountPercent).HasPrecision(4, 2);
            builder.Property(trLine => trLine.NetValue).HasPrecision(9, 2);
            builder.Property(trLine => trLine.DiscountValue).HasPrecision(9, 2);
            builder.Property(trLine => trLine.TotalValue).HasPrecision(9, 2);
            builder.HasOne(trLine => trLine.Transaction).WithMany(transaction => transaction.TransactionLines).HasForeignKey(trLine => trLine.TransactionID).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(trLine => trLine.Item).WithMany(item =>item.TransactionLines).HasForeignKey(trLine => trLine.ItemID).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
