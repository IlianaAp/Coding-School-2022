using FuelStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Shared
{
    public class TransactionViewModel
    {
        public Guid ID { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid CustomerID { get; set; }
        public DateTime Date { get; set; }
        public CustomerViewModel? Customer { get; set; }
        public string? EmployeeName { get; set; }
        public string? CustomerName { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
        public List<TransactionLineViewModel> TransactionLineViewModels { get; set; } = new List<TransactionLineViewModel>();
    }
    public class TransactionListViewModel
    {
        public List<TransactionViewModel> TransactionViewModels { get; set; } = new List<TransactionViewModel>();
    }
}
