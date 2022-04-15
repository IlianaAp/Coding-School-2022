using FuelStation.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Win.Calculations
{
    public class TotalValueCalculation
    {
        public void CalculateTotalValue(TransactionViewModel _transactionView)
        {
            decimal totalValue = 0;
            foreach (TransactionLineViewModel trLine in _transactionView.TransactionLineViewModels)
            {
                totalValue += trLine.TotalValue;
            }
            _transactionView.TotalValue = totalValue;
        }
    }
}
