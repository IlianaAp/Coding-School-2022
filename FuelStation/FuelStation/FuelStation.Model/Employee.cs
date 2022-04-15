using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStation.Models.Enums;

namespace FuelStation.Models
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public decimal SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
