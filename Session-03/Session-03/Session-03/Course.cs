using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Course
    {
        public Guid Id { get; }
        public string Code { get; set; }
        public string Subject { get; set; }

        public Course()
        {
            Id = Guid.NewGuid();
        }
    }
}
