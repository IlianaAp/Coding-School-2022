using System.ComponentModel;
using CarServiceCenterLibrary;

namespace Session_11
{
    [Serializable]
    public class ServiceCenter
    {
        public List<Customer> Customers { get; set; }
        public List<Car> Cars { get; set; }
        public List<ServiceTask> ServiceTasks { get; set; }
        public List<Manager> Managers { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Engineer> Engineers { get; set; }
        public List<MonthlyLedger> MonthlyLedgers { get; set; }

        public ServiceCenter()
        {   
            Engineers = new List<Engineer>();
            Cars = new List<Car>();
            Customers = new List<Customer>();
            ServiceTasks = new List<ServiceTask>();
            Managers = new List<Manager>();
            Transactions = new List<Transaction>();
            MonthlyLedgers = new List<MonthlyLedger>();
        }
    }
}