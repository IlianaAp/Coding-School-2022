using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLibrary
{
    [Serializable]
    public class Manager : Person
    {
        public decimal SallaryPerMonth { get; set; }        
        public Manager()
        {

        }
    }
}
