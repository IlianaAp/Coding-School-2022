using FuelStation.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Win.Calculations
{
    public class TransactionLineCalculation
    {
        private TransactionLineViewModel _transactionLineViewModel;
        public TransactionLineCalculation()
        {
            
        }
        public void CalcAll(TransactionLineViewModel transactionLineViewModel, ItemType itemType)
        {
            _transactionLineViewModel = transactionLineViewModel;
            CalcNetValue();
            if (itemType == ItemType.Fuel)
            {
                
                if (_transactionLineViewModel.NetValue > 20)
                {
                    _transactionLineViewModel.DiscountPercent = 10;
                }
            }
            else
            {
                _transactionLineViewModel.DiscountPercent = 0;
            }
            CalcDiscountValue();
            CalcTotalValue();
        }
        private void CalcNetValue()
        {
            _transactionLineViewModel.NetValue = _transactionLineViewModel.Quantity * _transactionLineViewModel.ItemPrice;
        }
        private void CalcDiscountValue()
        {
            if(_transactionLineViewModel.DiscountPercent > 0)
            {
                _transactionLineViewModel.DiscountValue = (_transactionLineViewModel.DiscountPercent / 100) * _transactionLineViewModel.NetValue;
            }
            else
            {
                _transactionLineViewModel.DiscountValue = 0;
            }
        }
        private void CalcTotalValue()
        {

            _transactionLineViewModel.TotalValue = _transactionLineViewModel.NetValue - (_transactionLineViewModel.DiscountValue ?? 0);
            
        }
    }
}
