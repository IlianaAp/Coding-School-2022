using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professor : Person
    {   
        public enum Ranks { Full, Associate, Assistant_Professor }
        public Ranks Rank { get; set; }
        public Course[] Courses { get; set; } = new Course[20];

        public Professor()
        {
            
        }
        public void SetGrade(Guid studentId, Guid courseId, int grade)
        {
           
            Grade gradeObj = new Grade(studentId, courseId, grade);
            // implementation logic to insert into db
        }

        public void Teach(Course course, DateTime dateTime)
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

        public string GetName()
        {
            return "Dr." + base.GetName();
        }

    }
}
