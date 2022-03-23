using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceCenterLibrary;

namespace Services
{
    internal class ExpensesPerMonth
    {
        public decimal SalaryExpenses()
        {
            var storageService = new StorageService();
            var serviceCenter = storageService.GetSeviceCenter();
            var engineers = serviceCenter.Engineers;
            var managers = serviceCenter.Managers;
            decimal salary=0.0m;
            foreach (var item in managers)
                salary += item.SallaryPerMonth;
            foreach (var item in engineers)
                salary += item.SallaryPerMonth;
            return salary;
        }
        public decimal IncomePerMonth() {
            var storageService = new StorageService();
            var serviceCenter = storageService.GetSeviceCenter();

            decimal incomeList = 0.0m;
            foreach (var transaction in serviceCenter.Transactions)
                incomeList += transaction.TotalPrice;
            return incomeList;
        }
        public decimal MonthlyIncome()
        {
            return IncomePerMonth() - SalaryExpenses();  
        }


    }
}
