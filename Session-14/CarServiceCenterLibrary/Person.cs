using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLibrary
{
    public class Person
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            ID = Guid.NewGuid();
        }
    }
}
