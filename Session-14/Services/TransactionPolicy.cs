using CarServiceCenterLibrary;
using Session_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services
{
    public class TransactionPolicy
    {
        private ServiceCenter _serviceCenter;

        public TransactionPolicy(ServiceCenter serviceCenter)
        {
            _serviceCenter = serviceCenter;
        }


        public bool IsTransactionLineValid(TransactionLine transactionLine)
        {
            var transactionDailyInfo = GetDailyTransactionsInfo();

            var maxDailyWorkload = new MaxDailyWorkLoad();
            if (!CheckIfServiceTaskCanBeAssigned())
            {
                return false;
                //transactionline is invalid (max task)
            }

            if ((transactionDailyInfo.TotalWorkedHours + transactionLine.Hours) >= maxDailyWorkload.GetMaxDailyWorkload())
            {
                return false;
                //transactionline is invalid (max workload)
            }
            return true;
        }

        public bool CheckIfServiceTaskCanBeAssigned()
        {
            var transactionDailyInfo = GetDailyTransactionsInfo();
            var maxServiceTasksPerDay = new MaxServiceTasksPerDay();
            return !(transactionDailyInfo.TotalServiseTasks >= maxServiceTasksPerDay.GetMaxDailyServiceTasks());
        }

        private (decimal TotalWorkedHours, int TotalServiseTasks) GetDailyTransactionsInfo()
        {
            decimal totalWorkedHours = 0;
            int totalServiseTasks = 0;

            var listOfTransactions = _serviceCenter.Transactions.Where(n => n.Date == DateTime.Today).ToList();
            foreach (Transaction tr in listOfTransactions)
            {
                var trLines = tr.TransactionLines;
                totalWorkedHours = tr.TransactionLines.Sum(n => n.Hours);
                totalServiseTasks = tr.TransactionLines.Count();
            }

            return (totalWorkedHours, totalServiseTasks);
        }
       
    }
}
