using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStation.Models.Enums;

namespace FuelStation.Models
{
    public class Transaction : BaseEntity
    {
        public DateTime Date { get; set; }
        public Employee Employee { get; set; }
        public Guid EmployeeID { get; set; }
        public Customer Customer { get; set; }
        public Guid CustomerID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
    }
}
