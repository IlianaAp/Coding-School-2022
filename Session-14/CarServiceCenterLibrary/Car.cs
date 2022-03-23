using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLibrary
{
    [Serializable]
    public class Car
    {
        public Guid ID { get; set; }
        public Brands Brand { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }

        public Car()
        {
            ID = Guid.NewGuid();

        }
    }        
}
