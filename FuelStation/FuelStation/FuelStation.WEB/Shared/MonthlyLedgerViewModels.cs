using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Shared
{
    public class MonthlyLedgerViewModel
    {
        public int Year { get; set; } = 2020;
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses {get; set; }
        public decimal Total { get; set; }
        public decimal Rent { get; set; } = 5000;
    }

    public class MonthlyLedgerListViewModel
    {
        public List<MonthlyLedgerViewModel> MonthlyLedgerViewModels { get; set; } = new List<MonthlyLedgerViewModel>();
    }
}
