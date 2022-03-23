using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLibrary
{
    [Serializable]
    
    public class Transaction
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid CarID { get; set; }
        public Guid ManagerID { get; set; }
        public decimal TotalPrice { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
        public Transaction()
        {            
            ID = Guid.NewGuid();
            Date = DateTime.Now;
            TransactionLines = new List<TransactionLine>();
        }
        public Transaction(Guid customerID, Guid carID, Guid managerID, DateTime date)
        {   
            ID = Guid.NewGuid();
            Date = date;
            CustomerID = customerID;
            CarID = carID;
            ManagerID = managerID;
            TransactionLines = new List<TransactionLine>();
        }
    }
}
