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
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLine");
            builder.HasKey(transactionLine => transactionLine.ID);
            builder.HasOne(transactionLine => transactionLine.Transaction).WithMany(transaction =>transaction.TransactionLines).HasForeignKey(transactionLine => transactionLine.TransactionID).IsRequired(false);
            builder.HasOne(transactionLine => transactionLine.ServiceTask).WithMany(serviseTask => serviseTask.TransactionLines).HasForeignKey(transactionLine => transactionLine.ServiceTaskID);
            builder.HasOne(transactionLine => transactionLine.Engineer).WithMany(engineer => engineer.TransactionLines).HasForeignKey(transactionLine => transactionLine.EngineerID);
            builder.Property(transactionLine => transactionLine.PRICE_PER_HOUR).HasDefaultValue(44.5m).HasPrecision(9, 2);
            builder.Property(transactionLine => transactionLine.Hours).HasPrecision(2, 2);
            builder.Property(transactionLine => transactionLine.Price).HasPrecision(9, 2);
        }
    }
}
