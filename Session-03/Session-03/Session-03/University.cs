using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University
    {
        public Student[] Students { get => GetStudents(); set { Students = value; } }
        public Course[] Courses { get => GetCourses(); set { Courses = value; } }
        public Grade[] Grades { get => GetGrades(); set { Grades = value; } }
        public Schedule[] ScheduledCourses { get; }
        public Professor[] Professors { get; set;}

        public University()
        {   
            Students = new Student[30];
            Courses = new Course[20];
            Professors = new Professor[5];
            ScheduledCourses = new Schedule[60];
        }

        private Student[] GetStudents() { return Students; }
        private Course[] GetCourses() { return Courses; }
        private Grade[] GetGrades() { return Grades; }
        public void SetSchedule(Guid courseId, Guid professorId, DateTime datetime )
        {
            Schedule scheduleObj = new Schedule(courseId, professorId, datetime);
            // implementation logic to insert into db
        }
    }
}
