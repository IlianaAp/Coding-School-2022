using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceCenterLibrary;

namespace Services
{
    public class CalculateTotalPrice
    {        
        public void SetTotalPrice(Transaction transaction)
        {
            decimal totalPrice = 0;
            var transactionLines = transaction.TransactionLines;
            foreach (TransactionLine transactionLine in transactionLines)
            {
                SetPrice(transactionLine);
                totalPrice += transactionLine.Price;
            }
            transaction.TotalPrice = totalPrice;
            
        }

        public void SetPrice(TransactionLine transactionLine)
        {
            transactionLine.Price = transactionLine.Hours * transactionLine.PRICE_PER_HOUR;
        }
    }
}
