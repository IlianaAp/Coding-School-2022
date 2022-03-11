using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Institute
    {
        public Guid Id { get; }
        private string name { get; set; }
        public int YearsInService { get; set; }

        public Institute()
        {
            Id = Guid.NewGuid();
        }
        public string GetName() => name;

        public void SetName(string _name) => name = _name;
    }
}
