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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");
            builder.HasKey(transaction => transaction.ID);
            builder.HasMany(transaction => transaction.TransactionLines).WithOne(transactionLine => transactionLine.Transaction).HasForeignKey(transactionLine => transactionLine.ID);
            builder.HasOne(transaction => transaction.Customer).WithMany(customer => customer.Transactions).HasForeignKey(transaction => transaction.CustomerID);
            builder.HasOne(transaction => transaction.Car).WithMany(car => car.Transactions).HasForeignKey(transaction => transaction.CarID);
            builder.HasOne(transaction => transaction.Manager).WithMany(manager => manager.Transactions).HasForeignKey(transaction => transaction.ManagerID);
            builder.Property(transaction => transaction.TotalPrice).HasPrecision(9, 2);
        }
    }
}
