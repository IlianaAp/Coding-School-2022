using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Person
    {   
        public Guid Id { get; }
        
        private string name;
        public int Age { get; set; }

        

        public Person()
        {
            Id = Guid.NewGuid();
        }

        public string GetName() => name;
        public void SetName(string _name) => name = _name;
    }
}
