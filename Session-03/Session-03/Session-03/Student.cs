using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Student
    {
        public int ResgistrationNumber { get; set; } 
        public Course[] Courses { get; set; } = new Course[20];

        public Student()
        {
            
        }

        public void Attend(Course course, DateTime datetime)
        {
            for (int i = 0; i < Courses.Length; i++)
            {
                if (Courses[i] == course)
                    break;
                if (Courses[i] == null)
                {
                    Courses[i] = course;
                    break;
                }
            }
        }
        private void WriteExam(Course course, DateTime datetime)
        {

        }
    }
}
