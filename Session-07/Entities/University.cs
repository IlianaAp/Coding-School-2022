using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class University : Institute
    {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourses { get; }
        public List<Professor> Professors { get; set; }

        public University()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
            Grades = new List<Grade>();
            ScheduledCourses = new List<Schedule>();
            Professors = new List<Professor>();
        }

        
       
    }
}
