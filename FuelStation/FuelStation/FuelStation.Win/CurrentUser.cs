using FuelStation.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Win
{
    public class CurrentUser
    {
        public string UserName { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public bool IsLogedIn { get; set; }
    }
}
