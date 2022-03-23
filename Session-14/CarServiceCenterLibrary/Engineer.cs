using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLibrary
{
    public class Engineer : Person
    {
        public Guid ManagerID { get; set; }
        public decimal SallaryPerMonth { get; set; }

        public Engineer(Guid managerID)
        {
            ManagerID = managerID;            
        }

        public Engineer()
        {

        }
    }
}
